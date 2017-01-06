using System;
using System.Collections.Generic;
using System.Linq;

namespace ResharperDemo
{
    public class Demo4CodeAnalysis
    {
        /// <summary>
        /// 1 - Unreachable Code
        /// </summary>
        public void Warnings()
        {
            if (true)
            {
                var x = true;
            }
            else
            {
                var x = false;
            }
        }

        /// <summary>
        /// 2 - Linq Suggestions - Foreach loops
        /// </summary>
        public void LinqSuggestions()
        {
            var favoriteCars = new List<Car>();
            foreach (var car in GetCars())
            {
                if (car.Model == "Ford")
                {
                    favoriteCars.Add(car);
                }
            }
        }

        /// <summary>
        /// 3 - Hints Converting (convert code to just return stamtments)
        /// </summary>
        public Car Hints()
        {
            var car = GetCar();

            if (car == null)
            {
                return car;
            }

            return new Car();
        }

        /// <summary>
        /// 4 - Multiple Possilbe Multiple Enumeration of IEnumerable
        /// </summary>
        public void MultipleEnumerationsOfIEnumberable()
        {
            var cars = GetCars();
            foreach (var car in cars)
            {
                Console.WriteLine("Car " + car.Make);
            }

            foreach (var car in cars)
            {
                Console.WriteLine("Car" + car.Model);
            }
        }

        /// <summary>
        /// 5 - Multiple Enumarations Expanded
        /// a is a bottleneck
        /// </summary>
        public void MultipleEnumerationsExpanded()
        {
            var test = Enumerable.Range(1, 100);
            var a = test.Where(n => n%2 == 0);
            var b = a.Sum();
            var c = a.Count();
            var d = from x in a where x%2 == 0 select x;
        }

        public static IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car {Make = "Ford", Model = "Fiesta"},
                new Car {Make = "Fiat", Model = "500"}
            };
        }

        public Car GetCar()
        {
            return new Car {Make = "Ford", Model = "Fiesta"};
        }
    }
}