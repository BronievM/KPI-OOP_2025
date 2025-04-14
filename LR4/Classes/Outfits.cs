using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4.Classes
{
    internal class Outfits
    {
        public List<Outfit> outfits { get; set; }

        public Outfits()
        {
            outfits = new List<Outfit>();
        }

        public List<Outfit> sortOutfitsTopByAZ()
        {
            return outfits.OrderBy(o => o.Top).ToList();
        }

        public List<Outfit> sortOutfitBottomByZA()
        {
            return outfits.OrderByDescending(o => o.Bottom).ToList();
        }
    }
}
