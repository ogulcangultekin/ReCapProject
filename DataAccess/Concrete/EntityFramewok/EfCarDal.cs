using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (EfDbContext context=new EfDbContext())
            {
                context.Cars.Add(entity);
                
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public List<Car> GetAll(Expression<Func<Car, bool>> filter)
        {
            using (EfDbContext context = new EfDbContext())
            {
                return context.Cars.ToList();
            }
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

    

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
