using AutoMapper;
using ERP.Common;
using ERP.Data;
using ERP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services
{
    public abstract class BaseEFService
    {
        protected ERPContext DbContext { get; private set; }
        protected IMapper Mapper { get; private set; }
        protected IHttpContextAccessor HttpContextAccessor { get; set; }
        protected DateTimeService DateTimeService { get; set; }
        protected IEmailSender EmailSender { get; set; }

        public BaseEFService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService)
            :this(dbContext, mapper, httpContextAccessor, dateTimeService, null)
        {

        }

        public BaseEFService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService, IEmailSender emailSender)
        {
            DbContext = dbContext;
            Mapper = mapper;
            HttpContextAccessor = httpContextAccessor;
            DateTimeService = dateTimeService;
            EmailSender = emailSender;
        }

        public UserSession GetUserSession()
        {
            var userSessionValue = HttpContextAccessor.HttpContext.Session.GetString("__UserSession");
            if (string.IsNullOrEmpty(userSessionValue))
                return null;

            return JsonConvert.DeserializeObject<UserSession>(userSessionValue);
        }

        public virtual void SetBaseModelFieldsOnCreate(BaseModel instance)
        {
            var userSession = GetUserSession();

            instance.OrganizationID = userSession.OrganizationID;
            instance.UserID = userSession.UserID;
            instance.CreateBy = userSession.UserFullName;
            instance.UpdateBy = userSession.UserFullName;

            instance.CreateDate = DateTimeService.ProvideDateTime();
            instance.UpdateDate = DateTimeService.ProvideDateTime();

        }

        protected virtual async Task<UserLoginData> CreateSuperAdmin(UserAdminInputData input, UserManager<User> userManager)
        {

            User superAdmin = new User()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Super",
                LastName = "Admin",
                OrganizationID = input.OrganizationID,
                Email = input.Email,
                UserName = input.Email,
                CreateBy = "Provider Organization",
                UpdateBy = "Provider Organization",
                CreateDate = DateTimeService.ProvideDateTime(),
                UpdateDate = DateTimeService.ProvideDateTime()
            };

            string password = Guid.NewGuid().ToString();

            await userManager.CreateAsync(superAdmin, password);
            await userManager.AddToRoleAsync(superAdmin, "SuperAdmin");

            UserLoginData userLogin = new UserLoginData() { Password = password, UserName = input.Email };
            return userLogin;
        }


        public virtual void SetBaseModelFieldOnUpdate(BaseModel instance)
        {
            var userSession = GetUserSession();

            instance.UpdateBy = userSession.UserFullName;
            instance.UpdateDate = DateTimeService.ProvideDateTime();
            instance.OrganizationID = userSession.OrganizationID;
        }

        public virtual void SetBaseModelFieldOnDelete(BaseModel instance)
        {
            var userSession = GetUserSession();

            instance.UpdateBy = userSession.UserFullName;
            instance.UpdateDate = DateTimeService.ProvideDateTime();
            instance.OrganizationID = userSession.OrganizationID;
            instance.Deleted = 1;
        }
    }
}
