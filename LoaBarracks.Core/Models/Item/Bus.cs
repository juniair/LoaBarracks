using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Core.Models
{
    public class Bus : Item
    {
        public override double TotalPrice => base.TotalPrice * (-1);
    }
}
