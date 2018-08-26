using Dtos.OrderProcess;
using ERP.Common;
using ERP.Data;
using ERP.Services;
using ERP.Services.OrderProcess;
using Microsoft.EntityFrameworkCore;
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
    public class CheckAmountNetOfNewRecord
    {
        private readonly int quantity = 5;
        private readonly int price = 15;

        [TestMethod]
        public async Task CheckAmontNet()
        {
            var dbContext = Helper.GetDBInMemory();
            DateTimeService service = new DateTimeService();
            var userSession = Helper.SetUserSession();
            var accessor = Helper.SetUpHttpContextAccessor(userSession);

            var mock = new Mock<IStringLocalizer<OrderInputModel>>();

            var model = SetUpData(userSession, dbContext);

            var orderService = new OrderService(dbContext, AutoMapper.Mapper.Instance, accessor, service, mock.Object);

            await orderService.CreateNewRecord(model);

            var order = await dbContext.Orders.FirstOrDefaultAsync(x => x.ID == model.ID);

            Assert.AreEqual(75, order.AmountNet);
        }

        private OrderInputModel SetUpData(UserSession userSession, ERPContext dbContext)
        {
             
            var result = new OrderInputModel() {
                    ID = Guid.NewGuid(),
                    Quantity = quantity,
                    Price = price,
                    OrganizationID = Guid.NewGuid(),
                    Title = "Unit Test",
                    NrIntern = "Unit Test",
                    DeliveryDate = DateTime.Now, SupplierID = Guid.NewGuid() };

            return result;

        }
    }
}
