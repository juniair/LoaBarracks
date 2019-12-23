using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Infra.Models
{
    public class WeekRaidOne : Item
    {
        public override double TotalPrice => 200 * Count;
    }
}
