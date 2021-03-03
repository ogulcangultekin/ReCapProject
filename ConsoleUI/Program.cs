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

            CarManager carManager = new CarManager(new EfCarDal());

            //Car car = new Car
            //{
             
            //    ColorId = 1,
            //    BrandId = 1,
            //    Name = "Dogan",
            //    ModelYear = 1992,
            //    DailyPrice = 25,
            //    Description = "Gercek bir araba"


            //};
            //carManager.Add(car);


            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Name);
            }

            Console.WriteLine("------");


        }
    }
}
