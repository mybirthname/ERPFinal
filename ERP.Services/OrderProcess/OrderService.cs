using AutoMapper;
using Dtos.OrderProcess;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.OrderProcess
{
    public class OrderService: BaseEFService, IOrderService
    {

        public OrderService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService)
            :base(dbContext, mapper, httpContextAccessor, dateTimeService)
        {

        }

        public Task CreateNewRecord(OrderInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRecord(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public Task<OrderInputModel> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRecord(OrderInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
