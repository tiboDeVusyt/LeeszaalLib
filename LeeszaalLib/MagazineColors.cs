using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public static class MagazineColors
    {
        public static List<string> Colors()
        {
            List<string> MagazineColors = new List<string>();
            MagazineColors.Add("Geel");
            MagazineColors.Add("Oranje");
            MagazineColors.Add("Groen");
            MagazineColors.Add("Blauw");
            MagazineColors.Add("Rood");
            return MagazineColors;
        }
    }
}
