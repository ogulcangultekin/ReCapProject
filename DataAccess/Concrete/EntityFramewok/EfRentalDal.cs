using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, EfDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (EfDbContext context=new EfDbContext())
            {

                var result = from c in context.Cars
                             join d in context.Rentals on
                             c.CarId equals d.CarId
                             join b in context.Brands on c.BrandId equals b.Id
                             join m in context.Customers on d.CustomerId equals m.Id
                             join u in context.Users on m.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.Name,
                                 BrandName = b.Name,
                                 CustomerId = m.UserId,
                                 CustomerName=u.FirstName,
                                 RentDate = d.RentDate,
                                 ReturnDate = d.ReturnDate
                             };
                return result.ToList();
            }



    }
    }
}
