using Business.Concrete;
using DataAccess.Concrete.EntityFramewok;
using DataAccess.Concrete.EntityFramewok.Context;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAddTest();
            //CarDeleteTest();
            //CarUpdateTest();
            //CarGetIdTest();
            //CarGetAllTest();
            CarGetDetails();

        }

        private static void CarGetDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "---" + car.CarName + "---" + car.BrandName + "---" + car.ColorName + "---" + car.DailyPrice);
            }
        }

        private static void CarGetIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = carManager.Get(4);
            Console.WriteLine(car.Name);
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 5,
                Name = "Mercedes",

            };
            carManager.Update(car);
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 6,
                ColorId = 1,
                BrandId = 1,
                Name = "Mercedes",
                ModelYear = 1995,
                DailyPrice = 25,
                Description = "Aksaray"


            };
            carManager.Delete(car);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Name);
            }

            Console.WriteLine("------");
        }

        private static CarManager CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car
            {

                ColorId = 1,
                BrandId = 1,
                Name = "Mercedes",
                ModelYear = 1995,
                DailyPrice = 25,
                Description = "Aksaray"


            };
            carManager.Add(car);
            return carManager;
        }
    }
}
