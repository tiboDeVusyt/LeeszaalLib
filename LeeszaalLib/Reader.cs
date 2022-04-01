using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public class Reader
    {
        public int ReferenceNumber { get; set; }
        public string Hat { get; set; }
        public Magazine magazine { get; set; }
        public Person person { get; set; }

        public static List<Reader> readers { get; set; } = new List<Reader>();
        //public List<Reader> readers = new List<Reader>();

        public void AddReader( Reader reader)
        {
            readers.Add(reader);
        }

        public override string ToString()
        {
            return $" {person.Age} {Hat} {magazine}";
        }
    }
}
