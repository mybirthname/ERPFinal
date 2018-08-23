using Dtos.Supplier;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Interfaces
{
    public interface ISupplierService
    {
        Task<List<ERP.Models.Supplier>> GetAllRecords();
        Task CreateNewRecord(SupplierInputModel model);
        Task<SupplierInputModel> GetByID(Guid id);
        Task UpdateRecord(SupplierInputModel inputModel);
        Task DeleteRecord(Guid id);
    }
}
