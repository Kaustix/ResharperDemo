



namespace ResharperDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Demo5CodeFormating
    {
        private readonly ICarService                                          _carServer;
        private readonly ICustomFormatter                                     _customFormatter;
        private readonly IAppDomainSetup                                      _appDomainSetup;
        private readonly IFormatProvider                                      _formatProvider;

        public Demo5CodeFormating(          
            ICarService carServer, 
                         ICustomFormatter customFormatter, 
            IAppDomainSetup appDomainSetup, 
                        IFormatProvider formatProvider)
        {
            _carServer = carServer;
            _customFormatter = customFormatter;
            _appDomainSetup = appDomainSetup;
            _formatProvider = formatProvider;
        }

        private string _someNumber;
        public string SomeNumber
        {
            get { return _someNumber; }
            set { _someNumber = value; }
        }

        public void AMethod()
        {
            bool isEven = true;
            if (3 % 3 == 0) { isEven = false; isEven = true;}

            var numbersToCompare =      new List<string> {"A long string right here", "Another Long Stirng right here", "Another Long String right here thats possibly hard to read cause it's past the point of the screen"};
        }
        
    }





}
