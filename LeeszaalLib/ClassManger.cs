using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeeszaalLib
{
    public static class ClassManger
    {
        public static List<Person> people = new List<Person>();
        public static List<Magazine> magazines = new List<Magazine>();
        


        public static void Lanch()
        {

            List<string> Colors =new List<string>( MagazineColors.Colors());
            List<string> hats = new List<string>(Hat.Hats());

                people.Add(new Person() { Name = "Tibo" });
                people.Add(new Person() { Name = "Mark" });
                people.Add(new Person() { Name = "Dave" });
                people.Add(new Person() { Name = "Padro" });
                people.Add(new Person() { Name = "WAles" });
                people.Add(new Person() { Name = "David" });
                people.Add(new Person() { Name = "Potter" });
                people.Add(new Person() { Name = "Clyde" });
                people.Add(new Person() { Name = "Bass" });
                people.Add(new Person() { Name = "Nan" });
                people.Add(new Person() { Name = "Ann" });
                people.Add(new Person() { Name = "anelise" });
                people.Add(new Person() { Name = "Hanne" });
                people.Add(new Person() { Name = "Marte" });
                people.Add(new Person() { Name = "Marius" });
                people.Add(new Person() { Name = "Wauter" });

            foreach (var item in Colors)
            {
                magazines.Add(new Magazine() {Color = item});
            }
            //Reader reader1 = new Reader() {ReferenceNumber = 1,Hat = hats[randHat],magazine = Colors[randColor] };
                Add(20);
        }
        public static void Add( int AmountOfReaders/*,int startindex*/)
        {
            Reader reader = new Reader();
            Random rand = new Random();
            /*if (startindex <= 0)*/ int startindex = Reader.readers.Count;
            AmountOfReaders += startindex;
            for (int i = startindex; i < AmountOfReaders; i++)
            {

                List<string> hats = new List<string>(Hat.Hats());

                int randHat = rand.Next(0, 4);
                int randColor = rand.Next(0, 5);
                int randPerson = rand.Next(0, 14);
                Reader temp = new Reader() { ReferenceNumber = i, Hat = hats[randHat], magazine = magazines[randColor], person = people[randPerson] };
                reader.AddReader(temp);
            }
        }
    }
}
