using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    class Hotitem : RentableDecorator
    {
        private readonly double HotItemBonus = 1.99;
        public Hotitem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() + this.HotItemBonus;
        }
        public override String Description
        {
            get
            {
                return "Hot: " + base.Description;
            }
        }
    }
}
