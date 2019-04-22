using System;
using System.Collections.Generic;
using System.Text;

namespace CatLady
{
   public class Cat
    {
        public string type;
        public string name;
        public double furSize;

        public Cat(string type, string name, double furSize)
        {
            this.type = type;
            this.name = name;
            this.furSize = furSize;
        }
    }
}
