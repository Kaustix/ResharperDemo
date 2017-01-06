using System;
using System.Collections.Generic;
using System.Linq;

namespace ResharperDemo
{
    /// <summary>
    /// 1 - Constructor Generation
    /// 2 - Interface Construction Generation
    /// 3 - Generate private members in constructor
    /// </summary>
    public class Demo3CodeGeneration
    {
        private readonly ICarService _carService;

        public void DoSomething()
        {
        }

        /// <summary>
        /// 4 - Generate Types
        /// </summary>
        //public SuperCar GetSuperCars()
        //{
        //    return new SuperCar();
        //}

        /// 5 - Generate Methods
        //public void GenerateMethods()
        //{
        //    var x = SomeCoolMethod();
        //}

        /// 6 = Extract Methods
        public void ExtractMethod()
        {
            var x = Math.Cos(6);
            var isEven = Math.Abs(x%2) <= 0;
        }
    }

    /// <summary>
    /// 7 - Generate IEquality Code
    /// </summary>
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    public interface ICarService
    { }

    /// <summary>
    /// 8 - Move Classes to another file
    /// </summary>
    public class CarService : ICarService
    { }

    /// <summary>
    /// 9 - Importing Missing Assemblies
    /// </summary>
    public class ImportStatements
    {
        //private IInterfaceINeed _interfaceINeed;
    }

    // 10 - Generating / Surrounding Code
    // Ctrl E + U
    public class GenerateCode
    {
        public IEnumerable<int> Numbers = new List<int> {1, 2, 3}; 
        public void Code()
        {
            var x = Numbers.FirstOrDefault();   
        }
    }
}