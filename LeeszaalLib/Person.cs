using System;

namespace LeeszaalLib
{
    public class Person
    {
        public static Random random = new Random();
        public int Age { get; set; } = random.Next(12, 70);
        public string Name { get; set; } 
    }
}
