using Business.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            using (EfDbContext context=new EfDbContext())
            {
                return context.Brands.Where(b => b.Id == id).ToList();
            }
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
