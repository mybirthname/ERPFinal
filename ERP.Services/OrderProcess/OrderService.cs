using AutoMapper;
using Dtos.OrderProcess;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.OrderProcess
{
    public class OrderService: BaseEFService, IOrderService
    {

        public OrderService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService)
            :base(dbContext, mapper, httpContextAccessor, dateTimeService)
        {

        }

        public async Task CreateNewRecord(OrderInputModel model)
        {
            var instance = Mapper.Map<Order>(model);
            SetBaseModelFieldsOnCreate(instance);

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

        public async Task<OrderInputModel> GetByID(Guid id)
        {
            var order = await DbContext.OrderPositions.FirstOrDefaultAsync(m => m.ID == id);
            var instance = this.Mapper.Map<OrderInputModel>(order);

            return instance;
        }

        public async Task UpdateRecord(OrderInputModel inputModel)
        {
            var order = await DbContext.Orders.FirstOrDefaultAsync(m => m.ID == inputModel.ID);

            Mapper.Map<OrderInputModel, Order>(inputModel, order);
            SetBaseModelFieldOnUpdate(order);

            DbContext.Attach(order).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }
    }
}
