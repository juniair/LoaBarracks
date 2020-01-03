using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Core.Models
{
    public class WeekRaidOne : Item
    {
        public override double TotalPrice => 200 * Count;
    }
}
