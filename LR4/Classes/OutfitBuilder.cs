using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4.Classes
{
    class OutfitBuilder
    {
        private string accessories = string.Empty;
        private string hat = string.Empty;
        private string top = string.Empty;
        private string bottom = string.Empty;
        private string shoes = string.Empty;

        public OutfitBuilder SetAccessories(string value)
        {
            accessories = value;
            return this;
        }

        public OutfitBuilder SetHat(string value)
        {
            hat = value;
            return this;
        }

        public OutfitBuilder SetTop(string value)
        {
            top = value;
            return this;
        }

        public OutfitBuilder SetBottom(string value)
        {
            bottom = value;
            return this;
        }

        public OutfitBuilder SetShoes(string value)
        {
            shoes = value;
            return this;
        }

        public Outfit Build()
        {
            return new Outfit(accessories, hat, top, bottom, shoes);
        }
    }

}
