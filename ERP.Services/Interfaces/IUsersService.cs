using Dtos.User;
using ERP.Models;
using ERP.Services.Administration;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Interfaces
{
    public interface IUsersService
    {
        Task<List<User>> GetAllUsersRecords();
        Task<IEnumerable<IdentityError>> CreateRecord(ManageAccountInputModel model);
        Task<ManageAccountInputModel> GetUserByID(string id);
        Task UpdateRecord(ManageAccountInputModel inputModel);
        Task DeleteRecord(string id);
        Task<UserRoleResultObject> AddRole(UserRoleTransferObject userRoleTransferObject);
        Task<UserRoleResultObject> RemoveRole(UserRoleTransferObject userRoleTransferObject);
    }
}
