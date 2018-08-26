using Dtos.Administration.News;
using ERP.Common;
using ERP.Data;
using ERP.Services;
using ERP.Services.Administration;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Test.News
{
    [TestClass]
    public class UpdateRecord
    {
        [TestMethod]
        public async Task UpdateSpecificRecord()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            Guid id = await SetUpData(userSession, dbContext);

            var news = new NewsService(dbContext, AutoMapper.Mapper.Instance, accessor, service);
            var updatedData = GetInputModel(id);
            await news.UpdateRecord(updatedData);

            var record = await dbContext.News.FirstOrDefaultAsync(x => x.ID == id);

            Assert.AreEqual(updatedData.NrIntern, record.NrIntern);
            Assert.AreEqual(updatedData.Title, record.Title);
        }

        private NewsInputModel GetInputModel(Guid id)
        {
            var model = new NewsInputModel() { ID = id, NrIntern = "Test Change", Title="Test Change" };
            return model;
        }

        private async Task<Guid> SetUpData(UserSession userSession, ERPContext dbContext)
        {
            Guid id = Guid.NewGuid();
            dbContext.News.Add(new Models.News() { ID = id, OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test" });

            await dbContext.SaveChangesAsync();

            return id;
        }

    }
}
