using AutoMapper;
using Dtos.Organization;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Provider
{
    public class OrganizationService : BaseEFService, IOrganizationService
    {

        public OrganizationService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService)
            : base(dbContext, mapper, httpContextAccessor, dateTimeService)
        {
        }

        public async Task<List<Organization>> GetAllOrganizationRecords()
        {
            var result = await DbContext.Organizations.Where(x => x.Deleted == 0).ToListAsync();

            return result;
        }

        public async Task<Organization> GetOrganizationByID(Guid id)
        {
            var result = await DbContext.Organizations.FirstOrDefaultAsync(x => x.ID == id);

            return result;
        }

        public async Task<OrganizationInputeModel> GetModelByID(Guid id)
        {
            var result = await DbContext.Organizations.FirstOrDefaultAsync(x => x.ID == id);

            var instance = Mapper.Map<OrganizationInputeModel>(result);

            return instance;
        }

        public async Task Update(OrganizationInputeModel model)
        {
            var usersession = GetUserSession();
            var organization = await DbContext.Organizations.FirstOrDefaultAsync(x => x.ID == model.ID);

            Mapper.Map<OrganizationInputeModel, Organization>(model, organization);
            organization.CreateBy = organization.UpdateBy = usersession.UserFullName;
            organization.UpdateDate = organization.CreateDate = DateTimeService.ProvideDateTime();


            DbContext.Attach(organization).State = EntityState.Modified;

            var customers = await DbContext.Customers.Where(x => x.CustomerOrganizationID == organization.ID).ToListAsync();
            var suppliers = await DbContext.Suppliers.Where(x => x.SupplierOrganizationID == organization.ID).ToListAsync();


            foreach(var item in customers)
            {
                Mapper.Map<OrganizationInputeModel, Models.Customer>(model, item);

                DbContext.Attach(item).State = EntityState.Modified;
            }

            foreach (var item in suppliers)
            {
                Mapper.Map<OrganizationInputeModel, Models.Supplier>(model, item);
                DbContext.Attach(item).State = EntityState.Modified;
            }

            await DbContext.SaveChangesAsync();

        }
    }
}
