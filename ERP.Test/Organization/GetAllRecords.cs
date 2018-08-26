using ERP.Common;
using ERP.Data;
using ERP.Services;
using ERP.Services.Provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Test.Organization
{
    [TestClass]
    public class GetAllRecords
    {

        [TestMethod]
        public async Task ReturnAllOrganizations()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            await SetUpData(userSession, dbContext);

            var organizationService =  new OrganizationService(dbContext, AutoMapper.Mapper.Instance, accessor, service);

            var result = await organizationService.GetAllOrganizationRecords();

            Assert.AreEqual(4, result.Count);

        }

        private async Task SetUpData(UserSession userSession, ERPContext dbContext)
        {
            dbContext.Organizations.Add(new Models.Organization() { ID = Guid.NewGuid(), Title = "Unit Test", City = "Sofia", Email= "testemail1@abv.bg" });
            dbContext.Organizations.Add(new Models.Organization() { ID = Guid.NewGuid(), Title = "Unit Test", City = "Sofia", Email = "testemail2@abv.bg" });
            dbContext.Organizations.Add(new Models.Organization() { ID = Guid.NewGuid(), Title = "Unit Test", City = "Sofia", Email = "testemail3@abv.bg" });
            dbContext.Organizations.Add(new Models.Organization() { ID = Guid.NewGuid(), Title = "Unit Test", City = "Sofia", Email = "testemail4@abv.bg" });

            await dbContext.SaveChangesAsync();

        }
    }
}
