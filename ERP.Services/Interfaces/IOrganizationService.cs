using Dtos.Organization;
using ERP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Interfaces
{
    public interface IOrganizationService
    {
        Task<List<Organization>> GetAllOrganizationRecords();
        Task<Organization> GetOrganizationByID(Guid id);
        Task Update(OrganizationInputeModel model);
        Task<OrganizationInputeModel> GetModelByID(Guid id);
    }
}
