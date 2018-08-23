using AutoMapper;
using Dtos.User;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Administration
{
    public class UsersService : BaseEFService, IUsersService
    {

        private readonly UserManager<User> _manager;

        public UsersService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService, UserManager<User> manager)
            : base(dbContext, mapper, httpContextAccessor, dateTimeService)
        {
            _manager = manager;
        }

        public async Task<IEnumerable<IdentityError>> CreateRecord(ManageAccountInputModel model)
        {
            var instance = this.Mapper.Map<User>(model);
            instance.UserName = instance.Email;
            SetBaseFields(instance);

            var result = await _manager.CreateAsync(instance, model.NormalPassword);

            return result.Errors;

        }

        private void SetBaseFields(User instance)
        {
            var userSession = GetUserSession();

            instance.OrganizationID = userSession.OrganizationID;
            instance.CreateDate = DateTimeService.ProvideDateTime();
            instance.UpdateDate = DateTimeService.ProvideDateTime();
            instance.CreateBy = userSession.UserFullName;
            instance.UpdateBy = userSession.UserFullName;

        }

        public async Task DeleteRecord(string id)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            var result = await _manager.DeleteAsync(user);

        }

        public async Task<List<User>> GetAllUsersRecords()
        {
            var userSession = GetUserSession();
            var users = await DbContext.Users
                .Where(x=> x.OrganizationID == userSession.OrganizationID)
                .OrderByDescending(x => x.CreateDate)
                .ToListAsync();

            return users;
        }

        public async Task<UserRoleResultObject> AddRole(UserRoleTransferObject role)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x => x.Id == role.UserID);

            var roles = await _manager.GetRolesAsync(user);
            UserRoleResultObject result = new UserRoleResultObject();

            if(roles.Contains(role.Role))
            {
                result.HasAddRoleException = true;
                result.Message = "CantAdd";

                return result;
            }

            await _manager.AddToRoleAsync(user, role.Role);
            result.Role = role.Role;

            return result;
        }

        public async Task<UserRoleResultObject> RemoveRole(UserRoleTransferObject role)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x => x.Id == role.UserID);

            var roles = await _manager.GetRolesAsync(user);
            UserRoleResultObject result = new UserRoleResultObject();

            if(!roles.Contains(role.Role))
            {
                result.HasRemoveRoleException = true;
                result.Message = "CantRemove";

                return result;
            }

            await _manager.RemoveFromRoleAsync(user, role.Role);
            result.Role = role.Role;

            return result;
        }

        public async Task<ManageAccountInputModel> GetUserByID(string id)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            var instance = this.Mapper.Map<ManageAccountInputModel>(user);

            StringBuilder builder = new StringBuilder();
            IList<string> roles = await _manager.GetRolesAsync(user);
            foreach (var item in roles)
            {
                builder.AppendLine(item);
            }

            instance.Roles = builder.ToString();

            return instance;

        }

        public async Task UpdateRecord(ManageAccountInputModel inputModel)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(m => m.Id == inputModel.ID);

            Mapper.Map<ManageAccountInputModel, User>(inputModel, user);
            await _manager.UpdateAsync(user);
        }
    }
}
