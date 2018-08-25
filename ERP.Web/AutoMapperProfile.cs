using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Dtos.Administration.News;
using Dtos.Customer;
using Dtos.OrderProcess;
using Dtos.Organization;
using Dtos.Supplier;
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
            this.CreateMap<CustomerInputeModel, Customer>().ReverseMap();
            this.CreateMap<SupplierInputModel, Supplier>().ReverseMap();
            this.CreateMap<OrganizationInputeModel, Organization>().ReverseMap();

            this.CreateMap<OrderInputModel, Order>().ForMember(x => x.CreateBy, opt => opt.Ignore()).ReverseMap();

            this.CreateMap<CustomerInputeModel, Organization>().ForMember(x => x.ID, opt => opt.Ignore());
            this.CreateMap<SupplierInputModel, Organization>().ForMember(x => x.ID, opt => opt.Ignore());
            this.CreateMap<OrganizationInputeModel, Customer>().ForMember(x => x.ID, opt => opt.Ignore());
            this.CreateMap<OrganizationInputeModel, Supplier>().ForMember(x => x.ID, opt => opt.Ignore());

        }
    }
}
