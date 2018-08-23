using ERP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Common
{
    public class SettingUserSessionFilter : IAsyncActionFilter
    {
        private readonly UserManager<User> _userManager;
        private UserSession _userSession;

        public SettingUserSessionFilter(UserManager<User> userManager, UserSession userSession)
        {
            _userManager = userManager;
            _userSession = userSession;
        }


        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                await next();
                return;
            }

            var currentUser = await _userManager.GetUserAsync(context.HttpContext.User);

            if (context.HttpContext.Session.GetString("__UserSession") != null)
            {
                _userSession = JsonConvert.DeserializeObject<UserSession>(context.HttpContext.Session.GetString("__UserSession"));

                if (_userSession.UserID != currentUser.Id)
                    SetUserSession(context, currentUser);

                await next();
                return;
            }

            SetUserSession(context, currentUser);

            await next();
        }

        private void SetUserSession(ActionExecutingContext context, User currentUser)
        {
            _userSession.OrganizationID = currentUser.OrganizationID;
            _userSession.UserID = currentUser.Id;
            _userSession.UserFullName = currentUser.LastName + ", " + currentUser.FirstName;

            var result = JsonConvert.SerializeObject(_userSession);

            context.HttpContext.Session.SetString("__UserSession", result);

        }
    }
}
