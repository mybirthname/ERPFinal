using Common;
using Dtos.Administration.News;
using ERP.Common;
using ERP.Services;
using ERP.Services.Administration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Test.News
{
    [TestClass]
    public class AddRecord
    {
        [TestMethod]
        public async Task AddOneRecord()
        {
            var dbContext = Helper.GetDBInMemory();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            var input = ProvideInputData();

            var news = new NewsService(dbContext, AutoMapper.Mapper.Instance, accessor, service);

            await news.CreateNewsRecord(input);
            var result = dbContext.News.Where(x=> x.OrganizationID == userSession.OrganizationID).Count();

            Assert.AreEqual(1, result);

        }

        private NewsInputModel ProvideInputData()
        {
            var data = new NewsInputModel() { ID = Guid.NewGuid(), NrIntern = "Test", Description = "Test2", Title = "Test" };
            return data;
        }

    }
}
