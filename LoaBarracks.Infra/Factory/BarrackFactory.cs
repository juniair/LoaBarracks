using LoaBarracks.Infra.Enums;
using LoaBarracks.Infra.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoaBarracks.Infra.Factory
{
    public class BarrackFactory : IFactory
    {
        public Barrack MakeBarrack(ClassType classType, string name, double level = 600)
        {
            return new Barrack
            {
                ClassType = classType,
                Name = name,
                Contents = new ObservableCollection<Content>(),
                Level = level
            };
        }

        public Content MakeContent(ContentType contentType, UseType useType)
        {
            throw new NotImplementedException();
        }

        public Item MakeItem(ItemType itemType)
        {
            throw new NotImplementedException();
        }
    }
}
