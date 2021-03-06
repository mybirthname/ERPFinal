﻿using AutoMapper;
using Dtos.OrderProcess;
using ERP.Common;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.OrderProcess
{
    public class OrderService: BaseEFService, IOrderService
    {
        private readonly IStringLocalizer<OrderInputModel> _localizedString;

        private static readonly Dictionary<int, string> StatusTexts = new Dictionary<int, string>()
        {
            {(int)Enumerations.OrderStatus.InProcess, "_InProcess" },
            {(int)Enumerations.OrderStatus.Sent, "_Sent" },
            {(int)Enumerations.OrderStatus.Confirm, "_Confirm" },
            {(int)Enumerations.OrderStatus.Rejected, "_Rejected" }

        };


        public OrderService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService, IStringLocalizer<OrderInputModel> localizedString)
            :base(dbContext, mapper, httpContextAccessor, dateTimeService)
        {
            _localizedString = localizedString;
        }

        public async Task CreateNewRecord(OrderInputModel model)
        {

            var instance = Mapper.Map<Order>(model);
            SetBaseModelFieldsOnCreate(instance);

            var supplier = await DbContext.Suppliers.FirstOrDefaultAsync(x => x.ID == model.SupplierID);

            if (supplier != null)
                instance.SupplierOrganizationID = supplier.SupplierOrganizationID;

            instance.AmountNet = instance.Price * instance.Quantity;

            await DbContext.Orders.AddAsync(instance);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteRecord(Guid id)
        {
            var order = await DbContext.Orders.FindAsync(id);

            if (order == null)
                return;

            SetBaseModelFieldOnDelete(order);

            DbContext.Attach(order).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllRecords()
        {
            var userSession = GetUserSession();

            var orders = await DbContext.Orders.Where(x => x.OrganizationID == userSession.OrganizationID && x.Deleted == 0).ToListAsync();

            return orders;
        }

        public async Task<List<ERP.Models.Supplier>> GetSupplierAsync()
        {
            var userSession = GetUserSession();
            var supplier = await DbContext.Suppliers
                            .Where(x => x.OrganizationID == userSession.OrganizationID && x.Deleted == 0).ToListAsync();

            return supplier;
        }

        public async Task<OrderInputModel> GetByID(Guid id)
        {

            var result = await (from item in DbContext.Orders
                         join org in DbContext.Organizations on item.OrganizationID equals org.ID
                         where item.ID == id
                         select new 
                         {
                             OrderInstance = item,
                             CompanyName = org.Title,
                         }).FirstOrDefaultAsync();

            var instance = this.Mapper.Map<OrderInputModel>(result.OrderInstance);
            instance.CompanyName = result.CompanyName;

            string key = StatusTexts[result.OrderInstance.Status];
            instance.StatusText = _localizedString[key];

            return instance;
        }

        public async Task UpdateRecord(OrderInputModel inputModel)
        {
            var order = await DbContext.Orders.FirstOrDefaultAsync(x => x.ID == inputModel.ID);

            Mapper.Map<OrderInputModel, Order>(inputModel, order);

            SetBaseModelFieldOnUpdate(order);
            order.AmountNet = order.Price * order.Quantity;

            var supplier = await DbContext.Suppliers.FirstOrDefaultAsync(x => x.ID == order.SupplierID);
            order.SupplierOrganizationID = supplier.SupplierOrganizationID;

            DbContext.Attach(order).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllSalesRecords()
        {
            var userSession = GetUserSession();

            var orders = await DbContext.Orders
                .Where(x => 
                        x.SupplierOrganizationID == userSession.OrganizationID && 
                        x.Deleted == 0 && 
                        x.Status > (int)Enumerations.OrderStatus.InProcess)
                .ToListAsync();

            return orders;
        }

        public async Task<List<Order>> GetFilterRecords(string searchTerm)
        {
            var userSession = GetUserSession();
            var result = await DbContext.Orders.Where(x =>
                        x.OrganizationID == userSession.OrganizationID &&
                        x.Deleted == 0 &&
                        (x.Title.Contains(searchTerm) || x.NrIntern.Contains(searchTerm))).ToListAsync();

            return result;
        }

        public async Task<OrderInputModel> SetStatus(int status, Guid id)
        {
            var item = await DbContext.Orders.FirstOrDefaultAsync(x => x.ID == id);
            item.Status = status;

            DbContext.Attach(item).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();


            var result = await GetByID(id);

            return result;
        }
    }
}
