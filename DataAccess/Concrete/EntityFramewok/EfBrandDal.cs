using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public List<Brand> Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById(int carId)
        {
            throw new NotImplementedException();
        }

    
        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
