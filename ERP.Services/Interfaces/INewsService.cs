using Dtos.Administration.News;
using ERP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Interfaces
{
    public interface INewsService
    {
        Task<List<News>> GetAllNewsRecords();
        Task CreateNewsRecord(NewsInputModel model);
        Task<NewsInputModel> GetNewsByID(Guid id);
        Task<List<News>> GetTop3();
        Task UpdateRecord(NewsInputModel inputModel);
        Task DeleteRecord(Guid id);
    }
}
