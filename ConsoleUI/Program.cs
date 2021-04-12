using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());




            Car car1 = new Car() { BrandId = 1, ColorId = 1, CarName = "Mercede C180", ModelYear = "2007", DailyPrice = 1000, Description = "Lüks Araç" };
            Car car2 = new Car() { BrandId = 2, ColorId = 3, CarName = "BMW i8", ModelYear = "2010", DailyPrice = 400, Description = "Konfor Araç" };
            Car car3 = new Car() { BrandId = 3, ColorId = 2, CarName = "Doğan SLX", ModelYear = "1994", DailyPrice = 100, Description = "Ekonomik Araç" };
            
            
            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);

            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.CarName);
            }
        }

        
    }
}
