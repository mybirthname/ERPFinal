using AutoMapper;
using ERP.Common;
using ERP.Data;
using ERP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Services
{
    public abstract class BaseEFService
    {
        protected ERPContext DbContext { get; private set; }
        protected IMapper Mapper { get; private set; }
        protected IHttpContextAccessor HttpContextAccessor { get; set; }
        protected DateTimeService DateTimeService { get; set; }

        public BaseEFService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService)
        {
            DbContext = dbContext;
            Mapper = mapper;
            HttpContextAccessor = httpContextAccessor;
        }

        public UserSession GetUserSession()
        {
            var userSessionValue = HttpContextAccessor.HttpContext.Session.GetString("__UserSession");
            if (string.IsNullOrEmpty(userSessionValue))
                return null;

            return JsonConvert.DeserializeObject<UserSession>(userSessionValue);
        }
    }
}
