using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Services.Abstractions;
using Taxi.Services;
using Taxi.Helpers.Comparers;
using Taxi.Helpers.Extensions;
using Taxi.Models.MovableProperty;

namespace Taxi
{
    public class Starter
    {
        public Starter()
        {
            CarService = new CarService();
        }

        public CarService CarService { get; set; }

        public void Run()
        {
            CarCompare();
            Console.WriteLine("--------------");
            Display(CarService.Cars);
            var temp = TaxiCarsExtensions.FindCar(CarService.Cars, 1500);
            Console.WriteLine("\nCars list with the weight less than 1500 kg: ");
            Display(temp);
        }

        public void Display(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Name: {cars[i].Name} Weight: {cars[i].Weight} Price: {cars[i].InitCost}");
            }
        }

        private void CarCompare()
        {
            CarComparer cc = new CarComparer();
            int result = cc.Compare(CarService.Cars[0], CarService.Cars[3]);
            Console.WriteLine($"Name's length compare result of {CarService.Cars[0].Name}, and {CarService.Cars[3].Name} is {result}");
        }
    }
}
