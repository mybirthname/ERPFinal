using AutoMapper;
using ERP.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Services
{
    public abstract class BaseEFService
    {
        protected ERPContext DbContext { get; private set; }
        protected IMapper Mapper { get; private set; }

        public BaseEFService(ERPContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }
    }
}
