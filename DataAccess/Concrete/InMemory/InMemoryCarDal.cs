using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 600, Description = "BMW", ModelYear = new DateTime(2010)},
                new Car{Id = 2, BrandId = 3, ColorId = 1, DailyPrice = 800, Description = "Mercedes", ModelYear = new DateTime(2020) },
                new Car{Id = 3, BrandId = 4, ColorId = 1, DailyPrice = 250, Description = "Hyundai", ModelYear = new DateTime(2008) },
                new Car{Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Toyota", ModelYear = new DateTime(2005) },
                new Car{Id = 5, BrandId = 5, ColorId = 1, DailyPrice = 150, Description = "Fiat", ModelYear = new DateTime(2012) }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car car = _cars.SingleOrDefault(c => c.Id == id);
            return car;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
