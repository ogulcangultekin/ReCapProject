using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfCarDal : EfEntityRepositoryBase<Car, EfDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (EfDbContext context=new EfDbContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors on
                             ca.ColorId equals co.Id
                             join b in context.Brands on ca.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 CarId=ca.CarId,
                                 CarName=ca.Name,
                                 BrandName=b.Name,
                                 ColorName=co.Name,
                                 DailyPrice=ca.DailyPrice
                             };
                return result.ToList();
    }
        }
    }
}
