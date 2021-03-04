using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand, EfDbContext> ,IBrandDal
    {
        
    }
}
