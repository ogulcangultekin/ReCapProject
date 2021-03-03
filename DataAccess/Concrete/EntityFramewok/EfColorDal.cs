using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public List<Color> Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById(int carId)
        {
            throw new NotImplementedException();
        }

     

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
