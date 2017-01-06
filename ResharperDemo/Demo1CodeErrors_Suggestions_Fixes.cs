namespace ResharperDemo
{
    /// <summary>
    /// 1 - Class / Method / Variable Name Suggestions
    /// </summary>
    public class Demo1CodeErrors_Suggestions_Fixes
    {
        private string supercar = "SuperCar";
        private ICarService CarService;

        /// <summary>
        /// 2 - Method Naming suggestions
        /// </summary>
        public void badNameFormat()
        {    
            //Variable Name Suggestions
            var SUPERCAR = supercar;
        }

        /// 3 - Errors Function doesn't return anything
        //public bool ShouldReturnABool()
        //{
        //}

        /// <summary>
        /// 3 - String interpolation hints + variables to const hints
        /// </summary>
        public string StringInterpolation()
        {
            var number = 2;
            return string.Format("Number of times this is used is {0}", number);
        }

        /// <summary>
        /// 4 - Fix Null Reference Exceptions
        /// </summary>
        public string NullReference(bool condition)
        {
            var iAmNullSometimes = condition ? "Not null value" : null;
            return iAmNullSometimes.ToUpper();
        }

        /// <summary>
        /// 5 - C# 6 - Expression Bodys
        /// </summary>
        public string GetAString
        {
            get { return "A Cool String"; }
        }
    }
}
