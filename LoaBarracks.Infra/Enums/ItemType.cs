using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoaBarracks.Infra.Enums
{
    public enum ItemType
    {
        [Description("우마늄")]
        Umanum,
        [Description("갈라토늄")]
        Garatonum,
        [Description("주간레이드2 입장권")]
        WeekRaidTicket1,
        [Description("주간레이드2 입장권")]
        WeekRaidTicket2,
        [Description("버스")]
        Bus,
    }
}
