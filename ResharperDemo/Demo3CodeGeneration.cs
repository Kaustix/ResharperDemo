using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResharperDemo.DemoModels;

namespace ResharperDemo
{
    /// <summary>
    /// 1 - Constructor Generation / Equality 
    /// 2 - Interface Construction Generation
    /// </summary>
    public class Demo3CodeGeneration
    {
        //private readonly IMathUtils _mathUtils;

        public void DoSomething()
        {
        }
    }


    /// <summary>
    /// 2 - Generate IEquality Code
    /// </summary>
    public class Car 
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
