﻿namespace TeraFinder.Core;

public enum TeraShiny : int
{
    Any = 0,
    No = 1,
    Yes = 2,
    Star = 3,
    Square = 4,
}

public enum GameProgress : byte
{
    Beginning = 0,
    UnlockedTeraRaids = 1,
    Unlocked3Stars = 2,
    Unlocked4Stars = 3,
    Unlocked5Stars = 4,
    Unlocked6Stars = 5,
}

public enum EventProgress : int
{
    Stage0 = 0,
    Stage1 = 1,
    Stage2 = 2,
    Stage3 = 3,
}

public enum RaidContent : byte
{
    Standard = 0,
    Black = 1,
    Event = 2,
    Event_Mighty = 3,
}

public enum RewardCategory : int
{
    ItemNone = 0,
    Poke = 1,
    Gem = 2,
}
