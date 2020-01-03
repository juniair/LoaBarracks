using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Core.Models
{
    public class WeekRaidTwo : Item
    {
        public override double TotalPrice => base.TotalPrice * (-1);
    }
}
