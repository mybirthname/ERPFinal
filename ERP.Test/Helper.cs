using ERP.Common;
using ERP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.AspNetCore.Session;

namespace ERP.Test
{
    internal class Helper
    {
        internal static ERPContext GetDBInMemory()
        {
            DbContextOptionsBuilder<ERPContext> buidler = new DbContextOptionsBuilder<ERPContext>();
            buidler.UseInMemoryDatabase(Guid.NewGuid().ToString());

            var dbContext = new ERPContext(buidler.Options);
            
            return dbContext;
        }

        internal static UserSession SetUserSession()
        {
            Guid organizationID = Guid.NewGuid();
            string userID = Guid.NewGuid().ToString();
            var userSession = new UserSession();
            userSession.OrganizationID = organizationID;
            userSession.UserID = userID;
            userSession.UserFullName = "Test User";

            return userSession;
        }

        internal static HttpContextAccessor SetUpHttpContextAccessor(UserSession userSession)
        {
            var httpContext = new DefaultHttpContext();
            var userSessionTextValue = JsonConvert.SerializeObject(userSession);
            var value = Encoding.UTF8.GetBytes(userSessionTextValue);

            var sessionMock = new Mock<ISession>();

            sessionMock.Setup(x => x.Set("__UserSession", It.IsAny<byte[]>()))
                .Callback<string, byte[]>((k, v) => v = value);

            sessionMock.Setup(x => x.TryGetValue("__UserSession", out value))
                .Returns(true);

            httpContext.Session = sessionMock.Object;

            HttpContextAccessor accessor = new HttpContextAccessor();
            accessor.HttpContext = httpContext;

            return accessor;
        }
    }
}
