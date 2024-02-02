using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;


#region SODataType
public enum SODataType
{
    None,
    GlobalDefine,
    DailyBonus,
    Price,
    Contents,
    ServerInfo,

    AccountLevel,
    AccountGold,
    AccountProperty,
    AccountRank,
    AccountDiceSlot,
    AccountDiceOption,
    AccountArtifact,
    AccountProficiency,
    AccountProficiencyLevel,
    AccountPromotion,
    AccountPromotionTraining,
    AccountUnityCommander,
    AccountUnitySpecies,
    AccountArtifactOoparts,
    AccountArtifactOopartsType,

    Buff,
    BuffCombat,
    BuffDesc,
    HelpDice,
    DeckBuff,

    Shrine,

    MonsterDraw,
    GachaRate,
    EntityGachaRate,
    ExchangeDraw,
    SpiritGachaRate,
    GachaDraw,

    GameString,
    ServerString,
    Slang,
    ErrorCode,

    Item,
    SPUMRes,
    SpineRes,
    Exchange,
    Acquire,
    EntityEquipment,
    EquipmentPromotion,
    EquipmentLevelup,
    EquipmentOption,

    Entity,
    EntityStatus,
    EntityCover,
    EntitySkill,
    EntitySkillAdditional,
    EntityLevel,
    EntityPromotion,
    EntityEvolution,
    EntityBreakThrough,
    EntitySkillLevel,
    EntityPassive,

    Ride,
    RideLevel,
    RidePromotion,

    Projectile,
    SkillProjectile,

    Stage,
    MazeDungeon,
    NestRanking,
    WarehouseDungeon,
    ChestDungeon,
    HorsePlainDungeon,
    VerseDungeon,
    TowerDungeon,
    WorldBossDungeon,
    WorldBossReward,
    NestDungeon,
    ExtraDungeon,

    Monster,
    MonsterGroup,

    GachaLevel,
    ShopProduct,
    InApp,
    SpiritGachaLevel,
    ShopType,

    Quest,
    Newbie,
    SeasonQuest,
    TutorialQuestText,

    PassType,
    PassStep,
    SeasonEvent,
    VerseEvent,
    SeasonBoard,
    SeasonLevelBoard,
    SuperCharge,
    ExtraDungeonEvent,


    PVPRanking,
    PVPScarecrow,
    PVPTimeBuff,

    Spirit,
    SpiritLevel,
    SpiritPromotion,
    SpiritTactic,
    SpiritTacticInfo,
    SpiritSlot,

    Mission,

    GuildLevel,
    GuildPropertyCommander,
    GuildPropertySpecies,
    GuildTowerReward,
    GuildRaid,
    GuildRaidReward,
    RecommendType,

    Anniversary,
    AnniversaryQuest,

    ComebackEvent,
    ComebackCharge,
    ComebackQuest,

    EventDungeon,
    EventDungeonReward,

    EventTriggerPopup,
    ShopEventTrigger,

    Card,
    CardLevel,
    CardDraw,

    MAX
}

#endregion

public class SODataManager : SingletonMonoBehaviour<SODataManager>
{
    public void DataClearAll()
    {

    }
}