using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Task2
{
    public class BaseClass
    {
        PublicClass publicClass = new PublicClass();
        public void Method()
        {
            publicClass.Method();
        }
    }
}
