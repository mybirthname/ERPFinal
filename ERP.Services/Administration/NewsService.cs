using AutoMapper;
using Dtos.Administration.News;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Services.Administration
{
    public class NewsService: BaseEFService, INewsService
    {
        public NewsService(ERPContext dbContext, IMapper mapper)
            :base(dbContext, mapper)
        {

        }

        public async Task<List<News>> GetAllNewsRecords()
        {
            var news = await DbContext.News.ToListAsync();

            return news;
        }

        public async Task CreateNewsRecord(NewsInputModel model)
        {
            var instance = this.Mapper.Map<News>(model);

            await DbContext.News.AddAsync(instance);
            await DbContext.SaveChangesAsync();
        }

        public async Task<NewsInputModel> GetNewsByID(int id)
        {
            var news = await DbContext.News.FirstOrDefaultAsync(m => m.ID == id);

            var instance = this.Mapper.Map<NewsInputModel>(news);

            return instance;
        }

        public async Task UpdateRecord(NewsInputModel model)
        {
            var instance = this.Mapper.Map<News>(model);
            DbContext.Attach(instance).State = EntityState.Modified;

            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteRecord(int id)
        {
            var news = await DbContext.News.FindAsync(id);

            if (news == null)
                return;

            DbContext.News.Remove(news);
            await DbContext.SaveChangesAsync();
           
        }
    }
}
