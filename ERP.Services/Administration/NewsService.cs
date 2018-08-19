using AutoMapper;
using Dtos.Administration.News;
using ERP.Data;
using ERP.Models;
using ERP.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ERP.Services.Administration
{
    public class NewsService: BaseEFService, INewsService
    {

        public NewsService(ERPContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor, DateTimeService dateTimeService)
            :base(dbContext, mapper, httpContextAccessor, dateTimeService)
        {
        }

        public async Task<List<News>> GetAllNewsRecords()
        {
            var userSession = GetUserSession();

            var news = await DbContext.News
                                    .Where(x=>x.OrganizationID == userSession.OrganizationID && x.Deleted == 0)
                                    .OrderBy(x=> x.NrIntern)
                                    .ToListAsync();

            return news;
        }

        public async Task<List<News>> GetTop3()
        {
            var userSession = GetUserSession();

            var news = await DbContext.News
                                    .Where(x => x.OrganizationID == userSession.OrganizationID && x.Deleted == 0)
                                    .OrderByDescending(x=> x.CreateDate)
                                    .Take(3)
                                    .ToListAsync();

            return news;
        }

        public async Task CreateNewsRecord(NewsInputModel model)
        {
            var instance = this.Mapper.Map<News>(model);
            SetBaseModelFieldsOnCreate(instance);

            await DbContext.News.AddAsync(instance);
            await DbContext.SaveChangesAsync();
        }

        public async Task<NewsInputModel> GetNewsByID(Guid id)
        {
            var news = await DbContext.News.FirstOrDefaultAsync(m => m.ID == id);
            var instance = this.Mapper.Map<NewsInputModel>(news);

            return instance;
        }

        public async Task UpdateRecord(NewsInputModel model)
        {
            var news = await DbContext.News.FirstOrDefaultAsync(m => m.ID == model.ID);

            Mapper.Map<NewsInputModel, News>(model, news);

            SetBaseModelFieldOnUpdate(news);

            DbContext.Attach(news).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteRecord(Guid id)
        {
            var news = await DbContext.News.FindAsync(id);

            if (news == null)
                return;

            SetBaseModelFieldOnDelete(news);

            DbContext.News.Update(news);
            await DbContext.SaveChangesAsync();
           
        }
    }
}
