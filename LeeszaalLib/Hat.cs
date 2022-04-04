using System.Collections.Generic;

namespace LeeszaalLib
{
    public static class Hat
    {
        public static string Name { get; set; }
        public static List<string> HatNames = new List<string>();
        public static List<string> Hats()
        {
            HatNames.Clear();
            HatNames.Add("pet");
            HatNames.Add("Bolhoed");
            HatNames.Add("Pruik");
            HatNames.Add("Niets");
            return HatNames;
        }
    }
}