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
        Task<NewsInputModel> GetNewsByID(int id);
        Task UpdateRecord(NewsInputModel inputModel);
        Task DeleteRecord(int id);
    }
}
