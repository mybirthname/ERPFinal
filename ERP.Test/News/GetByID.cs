﻿using Common;
using ERP.Common;
using ERP.Data;
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
    public class GetByID
    {
        [TestMethod]
        public async Task GetSpecificRecord()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            Guid id = await SetUpData(userSession, dbContext);

            var news = new NewsService(dbContext, AutoMapper.Mapper.Instance, accessor, service);
            var result = await news.GetNewsByID(id);

            Assert.AreEqual(id, result.ID);

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
