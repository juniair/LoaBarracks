using LoaBarracks.Core.Enums;
using LoaBarracks.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoaBarracks.Core.Factory
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
            Item item = null;
            switch (itemType)
            {
                case ItemType.WeaponMaterials:
                case ItemType.ArmorMaterials:
                    {
                        item = new Materials() { Type = itemType };
                        break;
                    }
                case ItemType.WeekRaidTicket1:
                    {
                        item = new WeekRaidOne() { Type = itemType };
                        break;
                    }
                case ItemType.WeekRaidTicket2:
                    {
                        item = new WeekRaidTwo() { Type = itemType };
                        break;
                    }
                case ItemType.Bus:
                    break;
                case ItemType.Soil:
                    break;
                case ItemType.Lava:
                    break;
                case ItemType.Arcturus:
                    break;
                case ItemType.Craving:
                    break;
                case ItemType.SlayerMark:
                    break;
                default:
                    break;
            }

            return item;
        }
    }
}
