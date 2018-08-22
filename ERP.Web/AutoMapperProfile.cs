using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Dtos.Administration.News;
using Dtos.User;
using ERP.Models;

namespace Common
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<NewsInputModel, News>().ReverseMap();
            this.CreateMap<ManageAccountInputModel, User>().ReverseMap();
        }
    }
}
