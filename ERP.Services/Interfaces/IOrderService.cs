using Dtos.OrderProcess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<ERP.Models.Order>> GetAllRecords();
        Task<List<ERP.Models.Order>> GetAllSalesRecords();
        Task CreateNewRecord(OrderInputModel model);
        Task<OrderInputModel> GetByID(Guid id);
        Task UpdateRecord(OrderInputModel inputModel);
        Task DeleteRecord(Guid id);
        Task<List<ERP.Models.Supplier>> GetSupplierAsync();
        Task<List<ERP.Models.Order>> GetFilterRecords(string searchTerm);
        Task<OrderInputModel> SetStatus(int status, Guid id);
    }
}
