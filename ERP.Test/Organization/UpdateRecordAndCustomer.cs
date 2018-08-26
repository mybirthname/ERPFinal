using Dtos.Organization;
using ERP.Common;
using ERP.Data;
using ERP.Services;
using ERP.Services.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Test.Organization
{
    [TestClass]
    public class UpdateRecordAndCustomer
    {
        private readonly string _title;

        public UpdateRecordAndCustomer()
        {
            _title = "Changed Organization name";
        }

        [TestMethod]
        public async Task UpdateOrganizationDataAndCustomerRecord()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            var organizationService = new OrganizationService(dbContext, AutoMapper.Mapper.Instance, accessor, service);

            await SetUpData(dbContext, userSession);

            var model = GetInputModel(userSession);
            await organizationService.Update(model);

            var organization = await dbContext.Organizations.FirstOrDefaultAsync(x => x.ID == userSession.OrganizationID);
            var customer = await dbContext.Customers.FirstOrDefaultAsync(x => x.CustomerOrganizationID == userSession.OrganizationID);

            Assert.AreEqual(_title, customer.Title);
            Assert.AreEqual(_title, organization.Title);

        }

        private async Task SetUpData(ERPContext dbContext, UserSession userSession)
        {
            dbContext.Organizations.Add(new Models.Organization() { ID = userSession.OrganizationID, Title = "Unit Test", City = "Sofia", Email = "testemail1@abv.bg" });
            dbContext.Customers.Add(new Models.Customer() { ID = Guid.NewGuid(), OrganizationID = Guid.NewGuid(), CustomerOrganizationID = userSession.OrganizationID, Title = "Test Supplier", UserID = Guid.NewGuid().ToString() });

            await dbContext.SaveChangesAsync();
        }

        private OrganizationInputeModel GetInputModel(UserSession userSession)
        {
            return new OrganizationInputeModel()
            {
                ID = userSession.OrganizationID,
                Title = _title
            };
        }

    }
}
