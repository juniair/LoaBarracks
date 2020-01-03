using LoaBarracks.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using LoaBarracks.Core.Models;

namespace LoaBarracks.Core.Factory
{
    public interface IFactory
    {
        Item MakeItem(ItemType itemType);
        Content MakeContent(ContentType contentType, UseType useType);
        Barrack MakeBarrack(ClassType classType, string Name, double level = 600);

    }
}
