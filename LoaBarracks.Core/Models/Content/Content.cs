using LoaBarracks.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Core.Models
{
    public class Content
    {
        public double AccessLevel { get; set; }

        public ContentType ContentType { get; set; }

        public UseType UseType { get; set; }

        public List<Item> Items { get; set; }

        public Content(ContentType contentType, UseType useType)
        {
            ContentType = contentType;
            UseType = UseType;
            Items = new List<Item>();
        }
    }
}
