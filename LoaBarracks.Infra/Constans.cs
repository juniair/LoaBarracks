using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoaBarracks.Infra
{
    public class Constans
    {
    }

    public enum ClassType
    {
        [Description("디스트로이어")]
        Destroyer,
        [Description("워로드")]
        Warlord,
        [Description("버서커")]
        Berserker,
        [Description("홀리나이트")]
        Holyknight,
        [Description("배틀마스터")]
        BattleMaster,
        [Description("인파이터")]
        Infighter,
        [Description("기공사")]
        SoulMaster,
        [Description("창술사")]
        LanceMaster,
        [Description("데빌헌터")]
        DevilHunter,
        [Description("블래스터")]
        Blaster,
        [Description("호크아이")]
        HawkEye,
        [Description("바드")]
        Bard,
        [Description("서머너")]
        Summoner,
        [Description("아르카나")]
        Arcana,
        [Description("블레이드")]
        Blade,
        [Description("데모닉")]
        Demonic
    }
}
