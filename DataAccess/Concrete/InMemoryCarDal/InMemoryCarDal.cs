using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1998,DailyPrice=15,Description="Son Model"},
                new Car{CarId=1,BrandId=2,ColorId=2,ModelYear=1997,DailyPrice=20,Description="Kazası var"},
                new Car{CarId=1,BrandId=1,ColorId=2,ModelYear=2000,DailyPrice=30,Description="Sıfır"},
            };
        }

        public void Add(Car car)
        {

            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

       
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
             
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate= _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
