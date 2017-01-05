using System;

namespace ResharperDemo
{
    /// <summary>
    /// 1 - Renaming Interfaces
    /// 2 - Renaming Methods
    /// 3 - Renaming Variables
    /// </summary>
    public class Pie : IPie
    {
        private const string PieName = "Cheese";

        public void MakePie()
        {
            Console.WriteLine(PieName);
        }
    }

    public class Pizza
    {
        private readonly IPie _pie;

        public Pizza(IPie pie)
        {
            _pie = pie;
        }

        public void MakePizza()
        {
            _pie.MakePie();
        }
    }

    public interface IPie
    {
        void MakePie();
    }
}