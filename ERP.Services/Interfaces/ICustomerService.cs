using Dtos.Customer;
using ERP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<ERP.Models.Customer>> GetAllRecords();
        Task CreateNewRecord(CustomerInputeModel model);
        Task<CustomerInputeModel> GetByID(Guid id);
        Task UpdateRecord(CustomerInputeModel inputModel);
        Task DeleteRecord(Guid id);

    }
}
