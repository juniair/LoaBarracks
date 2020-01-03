using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoaBarracks.Core.Enums
{
    public enum ContentType
    {
        [Description("레이드")]
        Raid,
        [Description("주간레이드")]
        WeekRaid,
        [Description("미스틱")]
        Mystic,
        [Description("카이슈테르")]
        Kaishuter,
        [Description("카오스 던전")]
        Chaos,
        [Description("작살")]
        Hunting,
        [Description("인양")]
        Salvage
    }
}
