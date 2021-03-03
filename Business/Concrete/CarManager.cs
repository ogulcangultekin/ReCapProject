using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Name.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                
            }
            
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        
    }
}
