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
            GetRentalDetailsTest();
            //RentalAddTest();
            //UserAddTest();
            //CustomerAddTest();

            //CarAddTest();
            //CarDeleteTest();
            //CarUpdateTest();
            //CarGetIdTest();
            //CarGetAllTest();
            //CarGetDetails();

        }

        private static void GetRentalDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental.CarId + "---" + rental.CarName + "---" + rental.BrandName + "---" + rental.CustomerName + rental.RentDate + "---" + rental.ReturnDate);
            }
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental()
            {
                CarId = 3,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Now
            };
            var result = rentalManager.Add(rental);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User()
            {
                FirstName = "Abuzittin",
                LastName = "TersGetirenOgullari",
                Email = "abuzittinTGO@gmail.com",
                Password = "123456"
            };
            var result = userManager.Add(user);
            Console.WriteLine(result.Message);
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer()
            {
                UserId = 1,
                CompanyName = "Vakvak Holding"
            };

            var result1 = customerManager.Add(customer);
            Console.WriteLine(result1.Message);
        }

        private static void CarGetDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + "---" + car.CarName + "---" + car.BrandName + "---" + car.ColorName + "---" + car.DailyPrice);
            }
        }

        private static void CarGetIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = carManager.Get(4).Data;
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

            foreach (var cars in carManager.GetAll().Data)
            {
                Console.WriteLine(cars.Name);
            }

            Console.WriteLine("------");
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car
            {

                ColorId = 1,
                BrandId = 1,
                Name = "Mercedes",
                ModelYear = 1995,
                DailyPrice = -1,
                Description = "Canavar"


            };
            var result = carManager.Add(car);
            
            if (result.Success==false)
            {
                Console.WriteLine(result.Message);
            }
            
         

           
        }
    }
}
