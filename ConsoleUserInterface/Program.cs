using Business.Concrete;
using System;
using System.Threading.Channels;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.Concrete;

namespace ConsoleUserInterface
{
    public class Program


    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());


            Console.WriteLine("\t\t Ne yapmak istiyorsunuz? \t\t");
            Console.WriteLine(" 1 - Yeni Araba Ekle\n 2 - Yeni Marka Ekle\n 3 - Yeni Renk Ekle\n 4 - Renk ID'sine göre getir.\n 5 - Marka ID'sine Göre Getir.\n 6 - Günlük Kiralama Fiyatına Göre Getir.\n 7 - Model Yılına Göre Getir.\n 8 - Hepsini Getir.");
            var deger = Convert.ToInt32(Console.ReadLine());
            string karakterselDeger = "";
            int degerInt = 0;

            switch (deger)
            { 
                case 1:
                    Car car1 = new Car();
                    
                    Console.Write("Marka İsmi: ");
                    car1.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nRenk: ");
                    car1.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nKiralama Fiyatı: ");
                    car1.DailyPrice = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nModel Yılı: ");
                    car1.ModelYear = Console.ReadLine();
                    Console.Write("\nBilgi: ");
                    car1.Description = Console.ReadLine();
                    carManager.Add(car1); 
                    break;
                case 2:
                    Brand brand1 = new Brand();
                    Console.WriteLine("Marka İsmi: ");
                    brand1.BrandName = Console.ReadLine();
                    brandManager.Add(brand1);
                    break;
                case 3:
                    Color color1 = new Color();
                    Console.Write("Renk: ");
                    color1.ColorName = Console.ReadLine();
                    colorManager.Add(color1);
                    break;
                case 4:
                    Console.Write("Renk ID Giriniz: ");
                    degerInt = Convert.ToInt32(Console.ReadLine());
                    foreach (var car in carManager.GetCarsByColorId(degerInt))
                    {
                        Console.WriteLine(car.CarId + car.BrandId + car.ColorId+car.DailyPrice+car.ModelYear+car.Description);
                    }
                    break;
                case 5:
                    Console.Write("Marka ID Giriniz: ");
                    degerInt = Convert.ToInt32(Console.ReadLine());
                    foreach (var car in carManager.GetCarsByBrandId(degerInt)) 
                    {
                        Console.WriteLine(car.CarId + car.BrandId + car.ColorId + car.DailyPrice + car.ModelYear + car.Description);
                    }
                    break;
                case 6:
                    Console.WriteLine("--Günlük Kiralama Fiyat Aralığı Giriniz--");
                    Console.Write("En Düşük: ");
                    var sayiMin = Convert.ToInt32(Console.ReadLine());
                    Console.Write("En Yüksek: ");
                    var sayiMax = Convert.ToInt32(Console.ReadLine());
                    foreach (var car in carManager.GetByDailyPrice(sayiMin,sayiMax))
                    {
                        Console.WriteLine(car.CarId + car.BrandId + car.ColorId + car.DailyPrice + car.ModelYear + car.Description);
                    }
                    break;
                case 7:
                    Console.Write("İstediğiniz Model Tarihi Giriniz: ");
                    karakterselDeger = Console.ReadLine();
                    foreach (var car in carManager.GetByModelYear(karakterselDeger))
                    {
                        Console.WriteLine(car.CarId + car.BrandId + car.ColorId + car.DailyPrice + car.ModelYear + car.Description);
                    }
                    break;
                case 8:
                    foreach (var car in carManager.GetAll())
                    {
                        Console.WriteLine(car.CarId + car.BrandId + car.ColorId + car.DailyPrice + car.ModelYear + car.Description);
                    }
                    break;
                default:break;
                    
                    
                    
                    
                    


            }

        }
    }
}
