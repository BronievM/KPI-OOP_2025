using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4.Classes
{
    internal class Outfit
    {
        public string Accessories { get; set; }
        public string Hat { get; set; }
        public string Top { get; set; }
        public string Bottom { get; set; }
        public string Shoes { get; set; }

        public Outfit()
        {
            Accessories = string.Empty;
            Hat = string.Empty;
            Top = string.Empty;
            Bottom = string.Empty;
            Shoes = string.Empty;
        }

        public Outfit(string accessories, string hat, string top, string bottom, string shoes)
        {
            Accessories = accessories;
            Hat = hat;
            Top = top;
            Bottom = bottom;
            Shoes = shoes;
        }
    }
}
