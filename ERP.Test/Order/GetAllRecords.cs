using Dtos.OrderProcess;
using ERP.Common;
using ERP.Data;
using ERP.Services;
using ERP.Services.OrderProcess;
using Microsoft.Extensions.Localization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Test.Order
{
    [TestClass]
    public class GetAllRecords
    {
        [TestMethod]
        public async Task GetSpecificOrdersForOrganization()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            var mock = new Mock<IStringLocalizer<OrderInputModel>>();

            await SetUpData(userSession, dbContext);

            var order = new OrderService(dbContext, AutoMapper.Mapper.Instance, accessor, service, mock.Object);

            var result = await order.GetAllRecords();

            Assert.AreEqual(4, result.Count);
        }



        private async Task SetUpData(UserSession userSession, ERPContext dbContext)
        {
            dbContext.Orders.Add(new Models.Order() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test", DeliveryDate = DateTime.Now, SupplierID = Guid.NewGuid() });
            dbContext.Orders.Add(new Models.Order() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test", DeliveryDate = DateTime.Now, SupplierID = Guid.NewGuid() });
            dbContext.Orders.Add(new Models.Order() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test", DeliveryDate = DateTime.Now, SupplierID = Guid.NewGuid() });
            dbContext.Orders.Add(new Models.Order() { ID = Guid.NewGuid(), OrganizationID = userSession.OrganizationID, Title = "Unit Test", NrIntern = "Unit Test", DeliveryDate = DateTime.Now, SupplierID = Guid.NewGuid() });
            dbContext.Orders.Add(new Models.Order() { ID = Guid.NewGuid(), OrganizationID = Guid.NewGuid(), Title = "Unit Test", NrIntern = "Unit Test", DeliveryDate = DateTime.Now, SupplierID = Guid.NewGuid() });

            await dbContext.SaveChangesAsync();

        }

    }
}
