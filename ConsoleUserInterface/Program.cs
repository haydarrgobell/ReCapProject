using Business.Concrete;
using System;
using System.Threading.Channels;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUserInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("\n========================================Car List========================================\n");
            Console.WriteLine("CarId\tCarBrand\tCarColor\tCarDailyPrice\tDescription\t\tModelYear");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId+ "--->\t|" + item.BrandId.BrandName+ "\t\t|" + item.ColorId.ColorName + "\t\t|" + item.DailyPrice + "\t\t" + item.Description + "\t|" + item.ModelYear);
            }

            Console.Write("\nAramak istediğiniz araba ID'sini giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            foreach (var car in carManager.GetById(sayi))
            {
                Console.WriteLine("----------------- Details Of Car Number "+sayi+ " -----------------");
                Console.WriteLine("ID \t\t: " + car.CarId);
                Console.WriteLine("Brand \t\t: " + car.BrandId.BrandName);
                Console.WriteLine("Color \t\t: " + car.ColorId.ColorName);
                Console.WriteLine("Daily Price \t: " + car.DailyPrice);
                Console.WriteLine("Description \t: " + car.Description);
                Console.WriteLine("Model \t\t: " + car.ModelYear);
            }

            Console.Write("\nAramak istediğiniz rengi yazınız : ");
            Color color = new Color();
            color.ColorName = Console.ReadLine();
            
            foreach (var car in carManager.GetByColor(color))
            {
                Console.WriteLine("\n----------------- Details Of The Car -----------------\n");
                Console.WriteLine("ID \t\t: " + car.CarId);
                Console.WriteLine("Brand \t\t: " + car.BrandId.BrandName);
                Console.WriteLine("Color \t\t: " + car.ColorId.ColorName);
                Console.WriteLine("daily Price \t: " + car.DailyPrice);
                Console.WriteLine("Description \t: " + car.Description);
                Console.WriteLine("Model \t\t: " + car.ModelYear);
            }
            Console.Write("\nAramak istediğiniz markayı yazınız : ");
            Brand brand = new Brand();
            brand.BrandName = Console.ReadLine();
            foreach (var car in carManager.GetByBrand(brand))
            {
                Console.WriteLine("\n----------------- Details Of The Car -----------------\n");
                Console.WriteLine("ID \t\t: " + car.CarId);
                Console.WriteLine("Brand \t\t: " + car.BrandId.BrandName);
                Console.WriteLine("Color \t\t: " + car.ColorId.ColorName);
                Console.WriteLine("Daily Price \t: " + car.DailyPrice);
                Console.WriteLine("Description \t: " + car.Description);
                Console.WriteLine("Model \t\t: " + car.ModelYear);
            }
        }
    }
}
