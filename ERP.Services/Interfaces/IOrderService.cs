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
        Task CreateNewRecord(OrderInputModel model);
        Task<OrderInputModel> GetByID(Guid id);
        Task UpdateRecord(OrderInputModel inputModel);
        Task DeleteRecord(Guid id);
    }
}
