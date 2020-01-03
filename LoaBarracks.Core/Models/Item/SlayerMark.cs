using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Core.Models
{
    public class SlayerMark : Item
    {
        public override double TotalPrice => Price * (int) (Count / 50);
    }
}
