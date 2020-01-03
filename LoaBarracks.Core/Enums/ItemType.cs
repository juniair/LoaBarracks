using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoaBarracks.Core.Enums
{
    public enum ItemType
    {
        [Description("우마늄")]
        WeaponMaterials,
        [Description("갈라토늄")]
        ArmorMaterials,
        [Description("주간레이드1 입장권")]
        WeekRaidTicket1,
        [Description("주간레이드2 입장권")]
        WeekRaidTicket2,
        [Description("버스")]
        Bus,
        [Description("대지의 숨결")]
        Soil,
        [Description("용암의 숨결")]
        Lava,
        [Description("아크투르스의 숨결")]
        Arcturus,
        [Description("갈망의 파편")]
        Craving,
        [Description("슬레이어 증표")]
        SlayerMark,
    }
}
