using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Infra.Models
{
    public class Star : Item
    {
        public override double TotalPrice => Price * (int) (Count / 50);
    }
}
