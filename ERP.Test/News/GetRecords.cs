using Common;
using ERP.Common;
using ERP.Data;
using ERP.Services;
using ERP.Services.Administration;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ERP.Test.News
{
    [TestClass]
    public class GetRecords
    {

        [TestMethod]
        public async Task GetSpecificNewsForOrganization()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            await SetUpData(userSession, dbContext);

            var news = new NewsService(dbContext, AutoMapper.Mapper.Instance, accessor, service);

            var result = await news.GetAllNewsRecords();

            Assert.AreEqual(3, result.Count);
        }



        private async Task SetUpData(UserSession userSession, ERPContext dbContext)
        {
            dbContext.News.Add(new Models.News() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test" });
            dbContext.News.Add(new Models.News() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test" });
            dbContext.News.Add(new Models.News() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test" });
            dbContext.News.Add(new Models.News() { ID = Guid.NewGuid(), OrganizationID = Guid.NewGuid(), Title = "Unit Test", NrIntern = "Unit Test" });
            dbContext.News.Add(new Models.News() { ID = Guid.NewGuid(), OrganizationID = Guid.NewGuid(), Title = "Unit Test", NrIntern = "Unit Test" });

            await dbContext.SaveChangesAsync();

        }
    }
}
