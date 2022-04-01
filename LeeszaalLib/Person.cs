using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public class Person
    {
        public static Random random = new Random();
        public int Age { get; set; } = random.Next(12, 70);
        public string Name { get; set; } 
    }
}
