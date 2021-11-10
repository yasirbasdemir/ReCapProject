using Business;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + " Markalı " + car.ColorId + " Renkli " + car.DailyPrice + 
                    " Günlük Ücretli "+ car.Description + " Arabamızdır.");
            }
        }
    }
}
