using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            CarDetailTest();

        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetCarDetails();
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "----" + car.BrandName + "----" + car.ColorName + "----" + car.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CDescription);
            }
        }
    }
}
