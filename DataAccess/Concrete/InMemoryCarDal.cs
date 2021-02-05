using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    //public class InMemoryCarDal : ICarDal
        public class InMemoryCarDal
    {
        //List<Car> _cars;

        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {
        //        new Car {CarId = 1, BrandId = new Brand{BrandId = 1,BrandName = "BMW"}, ColorId = new Color{ColorId = 1,ColorName = "BLACK"}, DailyPrice = 250, Description = "316i Diesel Manuel", ModelYear = 2020},
        //        new Car {CarId = 2, BrandId = new Brand{BrandId = 1,BrandName = "BMW"}, ColorId = new Color{ColorId = 2,ColorName = "GREY"}, DailyPrice = 300, Description = "320d Diesel Automatic", ModelYear = 2018},
        //        new Car {CarId = 3, BrandId = new Brand{BrandId = 2,BrandName = "FORD"}, ColorId = new Color{ColorId = 3,ColorName = "WHITE"}, DailyPrice = 150, Description = "Focus Diesel Manuel", ModelYear = 2019},
        //        new Car {CarId = 4, BrandId = new Brand{BrandId = 3,BrandName = "FIAT"}, ColorId = new Color{ColorId = 3,ColorName = "WHITE"}, DailyPrice = 100, Description = "Linea 1.6 Diesel Manuel", ModelYear = 2018},
        //        new Car {CarId = 5, BrandId = new Brand{BrandId = 4,BrandName = "FIAT"}, ColorId = new Color{ColorId = 1,ColorName = "BLACK"}, DailyPrice = 150, Description = "1.5 T3 Diesel Automatic", ModelYear = 2019},
        //        new Car {CarId = 6, BrandId = new Brand{BrandId = 4,BrandName = "VOLVO"}, ColorId = new Color{ColorId = 1,ColorName = "BLACK"}, DailyPrice = 250, Description = "150b T3 Diesel Manuel", ModelYear = 2019},
        //        new Car {CarId = 7, BrandId = new Brand{BrandId = 4,BrandName = "VOLVO"}, ColorId = new Color{ColorId = 4,ColorName = "RED"}, DailyPrice = 300, Description = "1.6 XQ Diesel Manuel", ModelYear = 2019}

        //    };
        //}

        //public void Add(Car car)
        //{
        //   _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    _cars.Remove(carToDelete);
        //}
        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Description = car.Description;
        //    carToUpdate.ModelYear = car.ModelYear;
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetById(int carId)
        //{
        //    return _cars.Where(c => c.CarId == carId).ToList();
        //}

        //public List<Car> GetByColor(Color color)
        //{
        //    return _cars.Where(c =>c.ColorId.ColorName == color.ColorName).ToList();
        //}

        //public List<Car> GetByBrand(Brand brand)
        //{
        //    return _cars.Where(c => c.BrandId.BrandName == brand.BrandName).ToList();
        //}
    }
}
