using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class CustomConverter()
    {
        public void Convert(string input, out int result)
        {
            result = System.Convert.ToInt32(input);
        }
        public void Convert(string input, out string result)
        {
            result = System.Convert.ToString(input);
        }
        public void Convert(string input, out double result)
        {
            result = System.Convert.ToDouble(input);
        }
    }
}
