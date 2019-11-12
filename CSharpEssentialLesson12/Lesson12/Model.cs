using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Model
    {
        public string Plus(int a, int b)
        {
            return $"Result= { (a + b).ToString()}";
        }

        public string Sub(int a, int b)
        {
            return $"Result= { (a - b).ToString()}";
        }

        public string Mul(int a, int b)
        {
            return $"Result= { (a * b).ToString()}";
        }

        public string Div(int a, int b)
        {
            if (b != 0)
                return $"Result= {((double)a / b).ToString()}";
            throw new Exception("Деление на ноль");
        }
    }
}
