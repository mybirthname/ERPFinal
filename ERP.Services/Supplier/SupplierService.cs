using AutoMapper;
using Dtos.Supplier;
using ERP.Common;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Supplier
{
    public class SupplierService : BaseEFService, ISupplierService
    {
        private readonly UserManager<User> _userManager;

        public SupplierService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService, IEmailSender emailSender, UserManager<User> userManager)
            : base(dbContext, mapper, httpContextAccessor, dateTimeService, emailSender)
        {
            _userManager = userManager;
        }

        public async Task CreateNewRecord(SupplierInputModel model)
        {
            using (var transaction = DbContext.Database.BeginTransaction())
            {
                Guid supplierOrganizationID = await CreateSupplierOrganization(model);
                UserAdminInputData data = new UserAdminInputData() { OrganizationID = supplierOrganizationID, Email = model.Email };

                var loginData = await CreateSuperAdmin(data, _userManager);
                await CreateSupplier(model, supplierOrganizationID);

                //await EmailSender.SendEmailAsync(model.Email, "Your Supplier Organization is created", $"Your logging credentials UserName:{loginData.UserName} and Password: {loginData.Password}");
                await EmailSender.SendEmailAsync("martin.stanchev87@gmail.com", "Your Supplier Organization is created", $"Your logging credentials UserName:{loginData.UserName} and Password: {loginData.Password}");

                transaction.Commit();
            }

        }

        private async Task CreateSupplier(SupplierInputModel model, Guid supplierOrganizationID)
        {
            var userSession = GetUserSession();
            var supplier = Mapper.Map<ERP.Models.Supplier>(model);
            supplier.SupplierOrganizationID = supplierOrganizationID;
            supplier.OrganizationID = userSession.OrganizationID;
            supplier.CreateBy = supplier.UpdateBy = userSession.UserFullName;
            supplier.UserID = userSession.UserID;
            supplier.CreateDate = supplier.UpdateDate = DateTimeService.ProvideDateTime();

            await DbContext.Suppliers.AddAsync(supplier);
            await DbContext.SaveChangesAsync();

        }

        private async Task<Guid> CreateSupplierOrganization(SupplierInputModel model)
        {
            var userSession = GetUserSession();

            Guid id = Guid.NewGuid();
            var instance = this.Mapper.Map<Organization>(model);
            instance.ProviderOrganizationID = userSession.OrganizationID;
            instance.ID = id;
            instance.CreateBy = userSession.UserFullName;
            instance.UpdateBy = userSession.UserFullName;
            instance.CreateDate = DateTimeService.ProvideDateTime();
            instance.UpdateDate = DateTimeService.ProvideDateTime();


            await DbContext.Organizations.AddAsync(instance);
            await DbContext.SaveChangesAsync();

            return id;

        }

        public async Task DeleteRecord(Guid id)
        {
            using (var transaction = DbContext.Database.BeginTransaction())
            {
                var userSession = GetUserSession();

                var supplier = await DbContext.Suppliers.FirstOrDefaultAsync(m => m.ID == id);
                var organization = await DbContext.Organizations.FirstOrDefaultAsync(m => m.ID == supplier.SupplierOrganizationID);

                supplier.Deleted = 1;
                organization.Deleted = 1;
                organization.UpdateBy = supplier.UpdateBy = userSession.UserFullName;
                organization.UpdateDate = supplier.UpdateDate = DateTimeService.ProvideDateTime();

                DbContext.Attach(supplier).State = EntityState.Modified;
                DbContext.Attach(organization).State = EntityState.Modified;

                await DbContext.SaveChangesAsync();

                var list = DbContext.Users.Where(x => x.OrganizationID == organization.ID);

                foreach (var item in list)
                {
                    await _userManager.DeleteAsync(item);
                }

                transaction.Commit();

            }
        }

        public async Task<List<Models.Supplier>> GetAllRecords()
        {
            var userSession = GetUserSession();

            var list = await DbContext.Suppliers.Where(x => x.OrganizationID == userSession.OrganizationID && x.Deleted == 0).ToListAsync();

            return list;
        }

        public async Task<SupplierInputModel> GetByID(Guid id)
        {
            var result = await DbContext.Suppliers.FirstOrDefaultAsync(x => x.ID == id);

            var instance = this.Mapper.Map<SupplierInputModel>(result);
            return instance;

        }

        public async Task UpdateRecord(SupplierInputModel inputModel)
        {
            var userSession = GetUserSession();
            var supplier = await DbContext.Suppliers.FirstOrDefaultAsync(m => m.ID == inputModel.ID);
            var organization = await DbContext.Organizations.FirstOrDefaultAsync(m => m.ID == supplier.SupplierOrganizationID);

            Mapper.Map<SupplierInputModel, ERP.Models.Supplier>(inputModel, supplier);
            Mapper.Map<SupplierInputModel, Organization>(inputModel, organization);

            organization.UpdateBy = supplier.UpdateBy = userSession.UserFullName;
            organization.UpdateDate = supplier.UpdateDate = DateTimeService.ProvideDateTime();

            DbContext.Attach(supplier).State = EntityState.Modified;
            DbContext.Attach(organization).State = EntityState.Modified;

            await DbContext.SaveChangesAsync();
        }
    }
}
