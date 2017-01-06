using System;

namespace ResharperDemo
{
    public interface IPie
    {
        void MakePie();
    }

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

        ///4 - Refactor Method Code Signatures
        public void PieSignature(int x, bool y)
        {   
        }

        /// 5 - Move Members Up (not apart of interface)
        public void NotApartOfInterface()
        {
        }
    }

    public class PieCrust
    {
        public void GetPieSignature()
        {
            var pie = new Pie();
            pie.PieSignature(2, true);
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
}