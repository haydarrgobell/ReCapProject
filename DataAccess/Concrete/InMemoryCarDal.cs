using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 250, Description = "HONDA", ModelYear = 2018},
                new Car {CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 300, Description = "MAZDA", ModelYear = 2016},
                new Car {CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 150, Description = "BMW", ModelYear = 2012},
                new Car {CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 100, Description = "FORD", ModelYear = 2008},
                new Car {CarId = 5, BrandId = 3, ColorId = 3, DailyPrice = 50, Description = "FIAT", ModelYear = 2006}

            };
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

       





    }
}
