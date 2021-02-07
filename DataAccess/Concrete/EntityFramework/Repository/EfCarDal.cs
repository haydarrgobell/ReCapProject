using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result =
                    from car in context.Cars
                    join brand in context.Brands
                        on car.BrandId equals brand.BrandId
                    join color in context.Colors
                        on car.ColorId equals color.ColorId
                    select new CarDetailDto
                    {
                        CarId = car.CarId,
                        BrandName = brand.BrandName, 
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice
                    };
                return result.ToList();


            }
        }
    }
}
