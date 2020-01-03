using LoaBarracks.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Core.Models
{
    public abstract class Item
    {
        public ItemType Type { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }

        public virtual double TotalPrice { get { return Price * Count; } }
    }
}
