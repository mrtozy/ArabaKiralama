using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
          
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine( car.ColorId + ". " + car.Description);
            }
            foreach (var car in carManager.GetCarsByBranddId(1))
            {
                Console.WriteLine(car.CarId + ". " + car.Description);
            }
        }
    }
}
