using Business.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        public void Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            using (EfDbContext context = new EfDbContext())
            {
                return context.Colors.Where(b => b.Id == id).ToList();
            }
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
