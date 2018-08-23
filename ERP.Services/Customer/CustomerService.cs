using AutoMapper;
using Dtos.Customer;
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

namespace ERP.Services.Customer
{
    public class CustomerService : BaseEFService, ICustomerService
    {
        private readonly UserManager<User> _userManager;

        public CustomerService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService, IEmailSender emailSender, UserManager<User> userManager)
            : base(dbContext, mapper, httpContextAccessor, dateTimeService, emailSender)
        {
            _userManager = userManager;
        }

        public async Task CreateNewRecord(CustomerInputeModel model)
        {
            using (var transaction = DbContext.Database.BeginTransaction())
            {
                Guid customerOrganizationID = await CreateCustomerOrganization(model);
                UserAdminInputData data = new UserAdminInputData() { OrganizationID = customerOrganizationID, Email = model.Email };

                var loginData = await CreateSuperAdmin(data, _userManager);

                await CreateCustomer(model, customerOrganizationID);
                // change it if you are going to production, password protection is needed too
                //await EmailSender.SendEmailAsync(model.Email, "Your Customer Organization is created", $"Your logging credentials UserName:{loginData.UserName} and Password: {loginData.Password}");
                await EmailSender.SendEmailAsync("martin.stanchev87@gmail.com", "Your Customer Organization is created", $"Your logging credentials UserName:{loginData.UserName} and Password: {loginData.Password}");

                transaction.Commit();
            }
        }

        private async Task CreateCustomer(CustomerInputeModel model, Guid customerOrganizationID)
        {
            var usersession = GetUserSession();

            var customer = Mapper.Map<ERP.Models.Customer>(model);
            customer.CustomerOrganizationID = customerOrganizationID;
            customer.OrganizationID = usersession.OrganizationID;
            customer.CreateBy = customer.UpdateBy = usersession.UserFullName;
            customer.UserID = usersession.UserID;
            customer.CreateDate = customer.UpdateDate = DateTimeService.ProvideDateTime();

            await DbContext.Customers.AddAsync(customer);
            await DbContext.SaveChangesAsync();

        }


        private async Task<Guid> CreateCustomerOrganization(CustomerInputeModel model)
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

                var customer = await DbContext.Customers.FirstOrDefaultAsync(m => m.ID == id);
                var organization = await DbContext.Organizations.FirstOrDefaultAsync(m => m.ID == customer.CustomerOrganizationID);

                customer.Deleted = 1;
                organization.Deleted = 1;
                organization.UpdateBy = customer.UpdateBy = userSession.UserFullName;
                organization.UpdateDate = customer.UpdateDate = DateTimeService.ProvideDateTime();

                DbContext.Attach(customer).State = EntityState.Modified;
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

        public async Task<List<Models.Customer>> GetAllRecords()
        {
            var userSession = GetUserSession();

            var list = await DbContext.Customers.Where(x => x.OrganizationID == userSession.OrganizationID && x.Deleted == 0).ToListAsync();

            return list;
        }

        public async Task<CustomerInputeModel> GetByID(Guid id)
        {
            var result = await DbContext.Customers.FirstOrDefaultAsync(x => x.ID == id);

            var instance = this.Mapper.Map<CustomerInputeModel>(result);
            return instance;
        }

        public async Task UpdateRecord(CustomerInputeModel inputModel)
        {
            var userSession = GetUserSession();
            var customer = await DbContext.Customers.FirstOrDefaultAsync(m => m.ID == inputModel.ID);
            var organization = await DbContext.Organizations.FirstOrDefaultAsync(m => m.ID == customer.CustomerOrganizationID);

            Mapper.Map<CustomerInputeModel, ERP.Models.Customer>(inputModel, customer);
            Mapper.Map<CustomerInputeModel, Organization>(inputModel, organization);

            organization.UpdateBy = customer.UpdateBy = userSession.UserFullName;
            organization.UpdateDate = customer.UpdateDate = DateTimeService.ProvideDateTime();

            DbContext.Attach(customer).State = EntityState.Modified;
            DbContext.Attach(organization).State = EntityState.Modified;

            await DbContext.SaveChangesAsync();
        }
    }
}
