using Business.Concrete;
using System;
using DataAccess.Concrete;

namespace ConsoleUserInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("CarId\tCarBrand\tCarColor\tCarDailyPrice\tDescription\tModelYear");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId+ "\t" + item.BrandId + "\t\t" + item.ColorId + "\t\t" + item.DailyPrice + "\t\t" + item.Description + "\t\t" + item.ModelYear);
            }

        }
    }
}
