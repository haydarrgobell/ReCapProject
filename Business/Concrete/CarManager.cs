using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal  _carDal;

        public CarManager(ICarDal carDal)
        {
            
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrand(Brand brand)
        {
            return _carDal.GetByBrand(brand);
        }

        public List<Car> GetByColor(Color color)
        {
            return _carDal.GetByColor(color);
        }
        public List<Car> GetById(int carId)
        {
            return _carDal.GetById(carId);
        }

        public IEnumerable<Car> GetByBrand(object brand)
        {
            throw new NotImplementedException();
        }
    }
}
