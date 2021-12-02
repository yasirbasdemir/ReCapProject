using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { new Car { Id = 1, BrandId = "Mercedes", ColorId = "Red", ModelYear = 1980, DailyPrice = 140, Description = "nostalgia" },
                new Car { Id = 2, BrandId = "BMW", ColorId = "Blue", ModelYear = 2002, DailyPrice = 100, Description = "Sport" },
                new Car { Id = 3, BrandId = "Citroën", ColorId = "Black", ModelYear = 2018, DailyPrice = 50, Description = "Price Performance" },
                new Car { Id = 4, BrandId = "rolls royce", ColorId = "White", ModelYear = 2021, DailyPrice = 700, Description = "Luxury" },
                
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.SingleOrDefault();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.Description = car.Description;
        }
    }
}
