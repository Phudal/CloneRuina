using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using Sirenix.OdinInspector;

public class GoogleSheetManager : MonoBehaviour
{

    // 에디터에서만 노출되게 수정
#if UNITY_EDITOR 
    // public string version = "";

    #region DATA_URL    
    public static string DATA_GLOBALDEFINE = "https://docs.google.com/spreadsheets/d/1-JQtz7tMZ6JpmudI4F1DyJshu7UeGTxrc8MgUBWA2ss";
    //public static string DATA_GAMESTRING = "https://docs.google.com/spreadsheets/d/1yqZHsS3BB59JXKTVDgSymHE-u_wVQHpdSIwUc7Iz028";
    //public static string DATA_ITEM = "https://docs.google.com/spreadsheets/d/1_detC8J1hWa9U4XDY3UbZnffQ3rdG9oimb_VZ2hIZuw";
    //public static string DATA_ACCOUNT = "https://docs.google.com/spreadsheets/d/1JdwoX1oxBdvizR-L1JIfqlK4nVBSfZMWTJ_a_f4qPuQ";
    //public static string DATA_BUFF = "https://docs.google.com/spreadsheets/d/1zFJHSSBYE3_YmxEVUnYzdGFZ-DEvMMKcYLTfQAK8q00";
    //public static string DATA_SHRINE = "https://docs.google.com/spreadsheets/d/1cORY0aJWxzm7-hhHvEsXSEJgdv2HxDUaZTXGhkgyAFA";
    //public static string DATA_ENTITY = "https://docs.google.com/spreadsheets/d/19M9-DvdHj4srmPjBqxlzjRtN87liOE_rpxNrmd3WBqw";
    //public static string DATA_STAGE = "https://docs.google.com/spreadsheets/d/1KE4DaoWEjrjGI57qGLPPQ9ozqUZPGOy6CNLKo3SamaE";
    //public static string DATA_MONSTER = "https://docs.google.com/spreadsheets/d/1Ql0XEuWERtdwWhfH8CedRqPIFt_imWCZel0CRQ2uEOQ";
    //public static string DATA_SHOP = "https://docs.google.com/spreadsheets/d/15jnzGHpnVbFmN0g6LSsH4MjPN8kasCCSCsEK8N9ntko";
    //public static string DATA_DRAW = "https://docs.google.com/spreadsheets/d/1-JhIjQE3uSu8KZcno_DNdu9pzohKeFcaG42aolOVkqA";
    //public static string DATA_QUEST = "https://docs.google.com/spreadsheets/d/1KpwMY7bKsrM6tHQyd3tl0Yx06z-nLQH-HE-Y6iKJYXU";
    //public static string DATA_PASS = "https://docs.google.com/spreadsheets/d/11Gbls4xNEKXNmG6NAXxPOue6t2FQ8j6o1WOth3Y9q-0";
    //public static string DATA_PVP = "https://docs.google.com/spreadsheets/d/1m8ZzLgYSOKaRcISH-S4oLVzCwUMCx3BWVlDJeLXu1dE";
    //public static string DATA_SPIRIT = "https://docs.google.com/spreadsheets/d/1VsdOYgOyevS3cC9zqElR3Qyn9gtB6tXewzwlUreUm4I";
    //public static string DATA_MISSION = "https://docs.google.com/spreadsheets/d/1i6vVLuQWlg11R6oTD_7EsbjSsklOlwBbHGO_hKYeRSc";
    //public static string DATA_GUILD = "https://docs.google.com/spreadsheets/d/13QCm4-9sjNPWUT28_9syS6GzHIX4yN6A-kJ9X0mpYXo";


    public static Dictionary<SODataType, int> dataGID = new Dictionary<SODataType, int>(new SODataTypeEnumComparer())
    {
        { SODataType.GlobalDefine,        184293170 },
        //{ SODataType.DailyBonus,          705538565 },
        //{ SODataType.Price,               1879042444 },
        //{ SODataType.Contents,            2143685827 },
        //{ SODataType.ServerInfo,          1590580123 },

        //{ SODataType.GameString,          1502115186 },
        ////{ DataType.GameString,          2073988602 },
        //{ SODataType.ServerString,        142427867 },
        //{ SODataType.Slang,               1164774037 },
        //{ SODataType.ErrorCode,           529363710 },

        //{ SODataType.Item,                1793409338 },
        //{ SODataType.SPUMRes,             829366207 },
        //{ SODataType.SpineRes,            620846404 },
        //{ SODataType.Exchange,            1009303428 },
        //{ SODataType.Acquire,             274393468 },
        //{ SODataType.EntityEquipment,     1781050265 },
        //{ SODataType.EquipmentPromotion,  1733316161 },
        //{ SODataType.EquipmentLevelup,  69413595 },
        //{ SODataType.EquipmentOption,  1331034026 },


        //{ SODataType.AccountLevel,        68502745 },
        //{ SODataType.AccountGold,         607170293},
        //{ SODataType.AccountProperty,     117992023},
        //{ SODataType.AccountRank,         1988372005 },
        //{ SODataType.AccountDiceSlot,     82119573 },
        //{ SODataType.AccountDiceOption,   558787155 },
        //{ SODataType.AccountArtifact,     1705460264 },
        //{ SODataType.AccountProficiency,      1644787525 },
        //{ SODataType.AccountProficiencyLevel, 1348901886 },
        //{ SODataType.AccountPromotion,        676324796 },
        //{ SODataType.AccountPromotionTraining,378282685 },
        //{ SODataType.AccountUnityCommander,       1612256846 },
        //{ SODataType.AccountUnitySpecies,         1674561476 },
        //{ SODataType.AccountArtifactOoparts,     496477467 },
        //{ SODataType.AccountArtifactOopartsType,     165735875 },

        //{ SODataType.Buff,                684860371 },
        //{ SODataType.BuffCombat,          1459844025 },
        //{ SODataType.BuffDesc,            47173562 },
        //{ SODataType.HelpDice,            1022094881 },
        //{ SODataType.DeckBuff,            1564906521 },

        //{ SODataType.Shrine,              1909911737 },

        //{ SODataType.MonsterDraw,         1277523456 },
        //{ SODataType.GachaRate,           693688990 },
        //{ SODataType.EntityGachaRate,     1199127134 },
        //{ SODataType.ExchangeDraw,        1229827018 },
        //{ SODataType.SpiritGachaRate,     1726232085 },
        //{ SODataType.GachaDraw,           1031952888 },


        //{ SODataType.Entity,              918482862 },
        //{ SODataType.EntityStatus,        489847094 },
        //{ SODataType.EntitySkill,         347803143 },
        //{ SODataType.EntitySkillAdditional, 715718971 },
        //{ SODataType.EntityCover,         2114359118 },
        //{ SODataType.EntityLevel,         734023326 },
        //{ SODataType.EntityBreakThrough,  1798206656 },
        //{ SODataType.EntityPromotion,     659363 },
        //{ SODataType.EntityEvolution,     978961820 },
        //{ SODataType.EntitySkillLevel,    1794814823 },
        //{ SODataType.EntityPassive,       547412989 },

        //{ SODataType.Ride,                1982304608 },
        //{ SODataType.RideLevel,           1579883390 },
        //{ SODataType.RidePromotion,       567045497 },

        //{ SODataType.Projectile,          620826406 },
        //{ SODataType.SkillProjectile,     546229084 },

        //{ SODataType.Card,                375750076 },
        //{ SODataType.CardLevel,           1630643226 },
        //{ SODataType.CardDraw,            1984983523 },

        //{ SODataType.Stage,               1946528653 },
        //{ SODataType.MazeDungeon,         1172846369 },
        //{ SODataType.NestRanking,         837495653 },
        //{ SODataType.WarehouseDungeon,    1789480618 },
        //{ SODataType.ChestDungeon,        678872741 },
        //{ SODataType.HorsePlainDungeon,   284096039 },
        //{ SODataType.VerseDungeon,        2026742156 },
        //{ SODataType.TowerDungeon,        756160853 },
        //{ SODataType.WorldBossDungeon,    335484708 },
        //{ SODataType.WorldBossReward,     1341036184 },
        //{ SODataType.NestDungeon,         1176060710 },
        //{ SODataType.EventDungeon,        1397868598 },
        //{ SODataType.EventDungeonReward,     1670883761 },
        //{ SODataType.ExtraDungeon,        2006264368 },

        //{ SODataType.Monster,             772845429 },
        //{ SODataType.MonsterGroup,        445278313 },

        //{ SODataType.GachaLevel,          837139222 },
        //{ SODataType.ShopProduct,         332476682 },
        //{ SODataType.InApp,               857428666 },
        //{ SODataType.SpiritGachaLevel,    2002143755 },
        //{ SODataType.ShopType,            1155372439 },
        //{ SODataType.RecommendType,       1430494260 },
        //{ SODataType.ShopEventTrigger,       324092239 },
        //{ SODataType.EventTriggerPopup,       1912395292 },

        //{ SODataType.Quest,               2083838708 },
        //{ SODataType.Newbie,              1163770131 },
        //{ SODataType.SeasonQuest,         1970323119 },
        //{ SODataType.TutorialQuestText,   896379235 },

        //{ SODataType.PassType,            2014889199 },
        //{ SODataType.PassStep,            385333003 },
        //{ SODataType.SeasonEvent,         1537751438 },
        //{ SODataType.VerseEvent,          750360469 },
        //{ SODataType.SeasonBoard,         1025286227 },
        //{ SODataType.SeasonLevelBoard,    83342995 },
        //{ SODataType.SuperCharge,         146498489 },
        //{ SODataType.ExtraDungeonEvent,          1918962434 },

        //{ SODataType.PVPRanking,          2047205024 },
        //{ SODataType.PVPScarecrow,        1165213773 },
        //{ SODataType.PVPTimeBuff,         2027810587 },

        //{ SODataType.Spirit,              0 },
        //{ SODataType.SpiritLevel,         1067466392 },
        //{ SODataType.SpiritPromotion,     201043178 },
        //{ SODataType.SpiritTactic,        1115319746 },
        //{ SODataType.SpiritTacticInfo,    767963078 },
        //{ SODataType.SpiritSlot,          1746034499 },

        //{ SODataType.Mission,             0 },

        //{ SODataType.GuildLevel,                 0 },
        //{ SODataType.GuildPropertyCommander,     1997465489 },
        //{ SODataType.GuildPropertySpecies,       213076244 },
        //{ SODataType.GuildTowerReward,           937158408 },
        //{ SODataType.GuildRaid,           1887698650 },
        //{ SODataType.GuildRaidReward,           148192800 },

        //{ SODataType.Anniversary,           187743555 },
        //{ SODataType.AnniversaryQuest,           1014079996 },

        //{ SODataType.ComebackEvent,           344113540 },
        //{ SODataType.ComebackCharge,           1133120422 },
        //{ SODataType.ComebackQuest,           1811903243 },
    };
    #endregion


    #region Data URL
    public static Dictionary<SODataType, string> dataUrl = new Dictionary<SODataType, string>(new SODataTypeEnumComparer())
    {
        { SODataType.GlobalDefine,  $"{DATA_GLOBALDEFINE}/export?format=tsv&gid={dataGID[SODataType.GlobalDefine]}" },
        //{ SODataType.Monster,      $"{DATA_MONSTER}/export?format=tsv&gid={dataGID[SODataType.Monster]}" },
        //{ SODataType.MonsterGroup, $"{DATA_MONSTER}/export?format=tsv&gid={dataGID[SODataType.MonsterGroup]}" },

        //{ SODataType.GlobalDefine, $"{DATA_GLOBALDEFINE}/export?format=tsv&gid={dataGID[SODataType.GlobalDefine]}" },
        //{ SODataType.DailyBonus,   $"{DATA_GLOBALDEFINE}/export?format=tsv&gid={dataGID[SODataType.DailyBonus]}" },
        //{ SODataType.Price,        $"{DATA_GLOBALDEFINE}/export?format=tsv&gid={dataGID[SODataType.Price]}" },
        //{ SODataType.Contents,     $"{DATA_GLOBALDEFINE}/export?format=tsv&gid={dataGID[SODataType.Contents]}" },
        //{ SODataType.ServerInfo,   $"{DATA_GLOBALDEFINE}/export?format=tsv&gid={dataGID[SODataType.ServerInfo]}" },

        //{ SODataType.GameString,   $"{DATA_GAMESTRING}/export?format=tsv&gid={dataGID[SODataType.GameString]}" },
        //{ SODataType.ServerString, $"{DATA_GAMESTRING}/export?format=tsv&gid={dataGID[SODataType.ServerString]}" },
        //{ SODataType.Slang,        $"{DATA_GAMESTRING}/export?format=tsv&gid={dataGID[SODataType.Slang]}" },
        //{ SODataType.ErrorCode,    $"{DATA_GAMESTRING}/export?format=tsv&gid={dataGID[SODataType.ErrorCode]}" },

        //{ SODataType.Item,         $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.Item]}" },
        //{ SODataType.SPUMRes,      $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.SPUMRes]}" },
        //{ SODataType.SpineRes,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.SpineRes]}" },
        //{ SODataType.Exchange,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.Exchange]}" },
        //{ SODataType.Acquire,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.Acquire]}" },
        //{ SODataType.EntityEquipment,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.EntityEquipment]}" },
        //{ SODataType.EquipmentPromotion,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.EquipmentPromotion]}" },
        //{ SODataType.EquipmentLevelup,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.EquipmentLevelup]}" },
        //{ SODataType.EquipmentOption,     $"{DATA_ITEM}/export?format=tsv&gid={dataGID[SODataType.EquipmentOption]}" },

        //{ SODataType.AccountLevel, $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountLevel]}" },
        //{ SODataType.AccountGold, $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountGold]}" },
        //{ SODataType.AccountProperty, $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountProperty]}" },
        //{ SODataType.AccountRank,     $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountRank]}" },
        //{ SODataType.AccountDiceSlot,  $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountDiceSlot]}" },
        //{ SODataType.AccountDiceOption,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountDiceOption]}" },
        //{ SODataType.AccountArtifact,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountArtifact]}" },
        //{ SODataType.AccountArtifactOoparts,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountArtifactOoparts]}" },
        //{ SODataType.AccountArtifactOopartsType,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountArtifactOopartsType]}" },
        //{ SODataType.AccountProficiency,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountProficiency]}" },
        //{ SODataType.AccountProficiencyLevel,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountProficiencyLevel]}" },
        //{ SODataType.AccountPromotion,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountPromotion]}" },
        //{ SODataType.AccountPromotionTraining,$"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountPromotionTraining]}" },
        //{ SODataType.AccountUnityCommander,   $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountUnityCommander]}" },
        //{ SODataType.AccountUnitySpecies, $"{DATA_ACCOUNT}/export?format=tsv&gid={dataGID[SODataType.AccountUnitySpecies]}" },

        //{ SODataType.Buff,         $"{DATA_BUFF}/export?format=tsv&gid={dataGID[SODataType.Buff]}" },
        //{ SODataType.BuffCombat,   $"{DATA_BUFF}/export?format=tsv&gid={dataGID[SODataType.BuffCombat]}" },
        //{ SODataType.BuffDesc,     $"{DATA_BUFF}/export?format=tsv&gid={dataGID[SODataType.BuffDesc]}" },
        //{ SODataType.HelpDice,     $"{DATA_BUFF}/export?format=tsv&gid={dataGID[SODataType.HelpDice]}" },
        //{ SODataType.DeckBuff,     $"{DATA_BUFF}/export?format=tsv&gid={dataGID[SODataType.DeckBuff]}" },

        //{ SODataType.Shrine,       $"{DATA_SHRINE}/export?format=tsv&gid={dataGID[SODataType.Shrine]}" },

        //{ SODataType.MonsterDraw,  $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.MonsterDraw]}" },
        //{ SODataType.GachaRate,    $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.GachaRate]}" },
        //{ SODataType.EntityGachaRate, $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.EntityGachaRate]}" },
        //{ SODataType.ExchangeDraw, $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.ExchangeDraw]}" },
        //{ SODataType.SpiritGachaRate, $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.SpiritGachaRate]}" },
        //{ SODataType.GachaDraw,   $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.GachaDraw]}" },

        //{ SODataType.Entity,       $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.Entity]}" },
        //{ SODataType.EntityStatus, $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityStatus]}" },
        //{ SODataType.EntitySkill,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntitySkill]}" },
        //{ SODataType.EntitySkillAdditional,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntitySkillAdditional]}" },
        //{ SODataType.EntityCover,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityCover]}" },
        //{ SODataType.EntityLevel,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityLevel]}" },
        //{ SODataType.EntityBreakThrough,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityBreakThrough]}" },
        //{ SODataType.EntityPromotion,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityPromotion]}" },
        //{ SODataType.EntityEvolution,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityEvolution]}" },
        //{ SODataType.EntitySkillLevel,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntitySkillLevel]}" },
        //{ SODataType.EntityPassive,  $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.EntityPassive]}" },

        //{ SODataType.Ride,        $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.Ride]}" },
        //{ SODataType.RideLevel,   $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.RideLevel]}" },
        //{ SODataType.RidePromotion,   $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.RidePromotion]}" },

        //{ SODataType.Projectile,   $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.Projectile]}" },
        //{ SODataType.SkillProjectile,   $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.SkillProjectile]}" },

        //{ SODataType.Card,        $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.Card]}" },
        //{ SODataType.CardLevel,   $"{DATA_ENTITY}/export?format=tsv&gid={dataGID[SODataType.CardLevel]}" },
        //{ SODataType.CardDraw,   $"{DATA_DRAW}/export?format=tsv&gid={dataGID[SODataType.CardDraw]}" },

        //{ SODataType.Stage,        $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.Stage]}" },
        //{ SODataType.MazeDungeon,  $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.MazeDungeon]}" },
        //{ SODataType.NestRanking,  $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.NestRanking]}" },
        //{ SODataType.WarehouseDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.WarehouseDungeon]}" },
        //{ SODataType.ChestDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.ChestDungeon]}" },
        //{ SODataType.HorsePlainDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.HorsePlainDungeon]}" },
        //{ SODataType.VerseDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.VerseDungeon]}" },
        //{ SODataType.TowerDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.TowerDungeon]}" },
        //{ SODataType.WorldBossDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.WorldBossDungeon]}" },
        //{ SODataType.WorldBossReward, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.WorldBossReward]}" },
        //{ SODataType.NestDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.NestDungeon]}" },
        //{ SODataType.GuildRaid,          $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.GuildRaid]}" },
        //{ SODataType.GuildRaidReward,          $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.GuildRaidReward]}" },
        //{ SODataType.EventDungeon,          $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.EventDungeon]}" },
        //{ SODataType.EventDungeonReward,          $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.EventDungeonReward]}" },
        //{ SODataType.ExtraDungeon, $"{DATA_STAGE}/export?format=tsv&gid={dataGID[SODataType.ExtraDungeon]}" },

        //{ SODataType.GachaLevel,  $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.GachaLevel]}" },
        //{ SODataType.ShopProduct, $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.ShopProduct]}" },
        //{ SODataType.InApp,       $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.InApp]}" },
        //{ SODataType.SpiritGachaLevel,  $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.SpiritGachaLevel]}" },
        //{ SODataType.ShopType,    $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.ShopType]}" },
        //{ SODataType.RecommendType,    $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.RecommendType]}" },
        //{ SODataType.ShopEventTrigger,    $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.ShopEventTrigger]}" },
        //{ SODataType.EventTriggerPopup,    $"{DATA_SHOP}/export?format=tsv&gid={dataGID[SODataType.EventTriggerPopup]}" },

        //{ SODataType.Quest,       $"{DATA_QUEST}/export?format=tsv&gid={dataGID[SODataType.Quest]}" },
        //{ SODataType.Newbie,      $"{DATA_QUEST}/export?format=tsv&gid={dataGID[SODataType.Newbie]}" },
        //{ SODataType.SeasonQuest, $"{DATA_QUEST}/export?format=tsv&gid={dataGID[SODataType.SeasonQuest]}" },
        //{ SODataType.TutorialQuestText, $"{DATA_QUEST}/export?format=tsv&gid={dataGID[SODataType.TutorialQuestText]}" },

        //{ SODataType.PassType,    $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.PassType]}" },
        //{ SODataType.PassStep,    $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.PassStep]}" },
        //{ SODataType.SeasonEvent, $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.SeasonEvent]}" },
        //{ SODataType.VerseEvent,  $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.VerseEvent]}" },
        //{ SODataType.SeasonBoard, $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.SeasonBoard]}" },
        //{ SODataType.SeasonLevelBoard, $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.SeasonLevelBoard]}" },
        //{ SODataType.SuperCharge, $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.SuperCharge]}" },
        //{ SODataType.ExtraDungeonEvent,  $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.ExtraDungeonEvent]}" },

        //{ SODataType.PVPRanking,    $"{DATA_PVP}/export?format=tsv&gid={dataGID[SODataType.PVPRanking]}" },
        //{ SODataType.PVPScarecrow,  $"{DATA_PVP}/export?format=tsv&gid={dataGID[SODataType.PVPScarecrow]}" },
        //{ SODataType.PVPTimeBuff,  $"{DATA_PVP}/export?format=tsv&gid={dataGID[SODataType.PVPTimeBuff]}" },

        //{ SODataType.Spirit,          $"{DATA_SPIRIT}/export?format=tsv&gid={dataGID[SODataType.Spirit]}" },
        //{ SODataType.SpiritLevel,     $"{DATA_SPIRIT}/export?format=tsv&gid={dataGID[SODataType.SpiritLevel]}" },
        //{ SODataType.SpiritPromotion, $"{DATA_SPIRIT}/export?format=tsv&gid={dataGID[SODataType.SpiritPromotion]}" },
        //{ SODataType.SpiritTactic,    $"{DATA_SPIRIT}/export?format=tsv&gid={dataGID[SODataType.SpiritTactic]}" },
        //{ SODataType.SpiritTacticInfo,$"{DATA_SPIRIT}/export?format=tsv&gid={dataGID[SODataType.SpiritTacticInfo]}" },
        //{ SODataType.SpiritSlot,      $"{DATA_SPIRIT}/export?format=tsv&gid={dataGID[SODataType.SpiritSlot]}" },

        //{ SODataType.Mission,         $"{DATA_MISSION}/export?format=tsv&gid={dataGID[SODataType.Mission]}" },

        //{ SODataType.GuildLevel,                $"{DATA_GUILD}/export?format=tsv&gid={dataGID[SODataType.GuildLevel]}" },
        //{ SODataType.GuildPropertyCommander,    $"{DATA_GUILD}/export?format=tsv&gid={dataGID[SODataType.GuildPropertyCommander]}" },
        //{ SODataType.GuildPropertySpecies,      $"{DATA_GUILD}/export?format=tsv&gid={dataGID[SODataType.GuildPropertySpecies]}" },
        //{ SODataType.GuildTowerReward,          $"{DATA_GUILD}/export?format=tsv&gid={dataGID[SODataType.GuildTowerReward]}" },

        //{ SODataType.Anniversary,          $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.Anniversary]}" },
        //{ SODataType.AnniversaryQuest,          $"{DATA_QUEST}/export?format=tsv&gid={dataGID[SODataType.AnniversaryQuest]}" },

        //{ SODataType.ComebackEvent,          $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.ComebackEvent]}" },
        //{ SODataType.ComebackCharge,          $"{DATA_PASS}/export?format=tsv&gid={dataGID[SODataType.ComebackCharge]}" },
        //{ SODataType.ComebackQuest,          $"{DATA_QUEST}/export?format=tsv&gid={dataGID[SODataType.ComebackQuest]}" },
    };

    #endregion

    System.DateTime createTime;

    int resCount = 0;

    #region GOOGLE_SHEET
    public SODataType googleType;

    //[Button]
    //public void Google_SOGenerationSelect()
    //{
    //    Logger.Log($"StartSOGeneration : {googleType}");

    //    if (dataUrl.ContainsKey(googleType) == false)
    //    {
    //        Logger.LogError($"Request Type is not Define ({googleType})");
    //        return;
    //    }

    //    if (dataUrl[googleType] == string.Empty)
    //    {
    //        Logger.LogError($"Request url is empty ({googleType})");
    //        return;
    //    }
    //    resCount = 0;
    //    StartCoroutine(GetDataCo(googleType, dataUrl[googleType]));
    //}

    [Button("Google_SOGenerationALL")]
    public void Google_SOGenerationALL()
    {
        Logger.Log($"StartSOGenerationALL : {dataUrl.Count}");
        createTime = System.DateTime.Now;
        resCount = 0;

        // long timestamp = (long)CoffeeLibrary.TimeUtil.CurTimestamp();
        // AuthHelper.Instance.authDataVersion = timestamp.ToString();

        SODataManager.Instance.DataClearAll();

        foreach (var item in dataUrl)
        {
            StartCoroutine(GetDataCo(item.Key, item.Value));
        }
    }

    //[NaughtyAttributes.Button]
    //public void Google_VersionSave()
    //{
    //    SaveVersion();
    //}
    #endregion

    IEnumerator GetDataCo(SODataType type, string url)
    {
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        Logger.Log($"{type} : {url}");

        if (www.error != null)
        {
            Logger.LogError($"{url} : {www.error}");
        }
        else
        {
            resCount++;
            Logger.Log($"data : {resCount}/{dataUrl.Count}");

            // FileUtil.WriteFileLine(www.downloadHandler.text, Application.dataPath + $"/../Documents/SheetData/{createTime.ToString("yyyy-MM-dd HH-mm-ss")}/", $"{type}.tsv");



            if (type == SODataType.GlobalDefine)
            {
                // StartCoroutine(SODataManager.Instance.SetData<DefineData>(type, www.downloadHandler.text));
            }
            else if (type == SODataType.DailyBonus)
            {
                // StartCoroutine(SODataManager.Instance.SetData<DailyBonusData>(type, www.downloadHandler.text));
            }
            else
            {
                Logger.LogError($"Request type is Not define ({type})");
            }
        }
    }

    //void SaveVersion()
    //{
    //    string path = Path.Combine(Application.streamingAssetsPath, "version.txt");
    //    if (!File.Exists(path))
    //    {
    //        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
    //        {
    //            // Create a StreamWriter for writing to the file
    //            using (StreamWriter writer = new StreamWriter(fs))
    //            {
    //                writer.Write(version);
    //            }
    //        }
    //    }
    //    else
    //    {
    //        // Open or create the file in write mode
    //        using (FileStream fs = File.OpenWrite(path))
    //        {
    //            // Create a StreamWriter for writing to the file
    //            using (StreamWriter writer = new StreamWriter(fs))
    //            {
    //                writer.Write(version);
    //            }
    //        }
    //    }
    //}
#endif
}