using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


#region Araba Sınıfı
Console.WriteLine("------Araba Sınıfı-------");

CarManager carManager = new CarManager(new EfCarDal());
Console.WriteLine("Araba ekleme deneme - 1");
carManager.Add(new Car() { BrandId = 1, ColorId = 2, DailyPrice = 0,Description="Hasarlı",ModelYear=2019 });

Console.WriteLine("Araba ekleme deneme - 2");
carManager.Add(new Car() { BrandId = 1, ColorId = 2, DailyPrice = 22,Description="Hasarlı",ModelYear=2019 });

Console.WriteLine("--------------------------");
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}


Console.WriteLine("------Marka ID Göre Getirmek-------");


foreach (var car in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine(car.Description);
}


#endregion

#region Marka Sınıfı
Console.WriteLine("------Marka Sınıfı -----------");
BrandManager brandManager = new BrandManager(new EfBrandDal());

foreach (var item in brandManager.GetAll())
{
    Console.WriteLine("Marka Adı :" + item.Name);
}

Console.WriteLine("----- Yeni Marka Ekleme ----------");

Brand brand1 = new Brand();
brand1.Name = "A";
brandManager.Add(brand1);

Brand brand2 = new Brand();
brand2.Name = "Audi";
brandManager.Add(brand2);


#endregion

