using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountedPercentage = 30;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * 1 - this.DiscountedPercentage/100;
        }
        public override String Description
        {
            get
            {
                return base.Description + " now at [" + this.DiscountedPercentage + "]% off!";
            }
        }
    }
}
