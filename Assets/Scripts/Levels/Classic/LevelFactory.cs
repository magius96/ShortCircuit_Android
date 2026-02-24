using Assets.Scripts;
using Assets.Scripts.Levels;

internal class LevelFactory
{
    public static GameLevel GetClassicLevel(ClassicLevels level)
    {
        switch (level)
        {
            case ClassicLevels.Classic11: return new Classic11();
            case ClassicLevels.Classic12: return new Classic12();
            case ClassicLevels.Classic13: return new Classic13();
            case ClassicLevels.Classic14: return new Classic14();
            case ClassicLevels.Classic15: return new Classic15();
            case ClassicLevels.Classic16: return new Classic16();
            case ClassicLevels.Classic17: return new Classic17();

            case ClassicLevels.Classic21: return new Classic21();
            case ClassicLevels.Classic22: return new Classic22();
            case ClassicLevels.Classic23: return new Classic23();
            case ClassicLevels.Classic24: return new Classic24();
            case ClassicLevels.Classic25: return new Classic25();
            case ClassicLevels.Classic26: return new Classic26();
            case ClassicLevels.Classic27: return new Classic27();

            case ClassicLevels.Classic31: return new Classic31();
            case ClassicLevels.Classic32: return new Classic32();
            case ClassicLevels.Classic33: return new Classic33();
            case ClassicLevels.Classic34: return new Classic34();
            case ClassicLevels.Classic35: return new Classic35();
            case ClassicLevels.Classic36: return new Classic36();
            case ClassicLevels.Classic37: return new Classic37();

            case ClassicLevels.Classic41: return new Classic41();
            case ClassicLevels.Classic42: return new Classic42();
            case ClassicLevels.Classic43: return new Classic43();
            case ClassicLevels.Classic44: return new Classic44();
            case ClassicLevels.Classic45: return new Classic45();
            case ClassicLevels.Classic46: return new Classic46();
            case ClassicLevels.Classic47: return new Classic47();

            case ClassicLevels.Classic51: return new Classic51();
            case ClassicLevels.Classic52: return new Classic52();
            case ClassicLevels.Classic53: return new Classic53();
            case ClassicLevels.Classic54: return new Classic54();
            case ClassicLevels.Classic55: return new Classic55();
            case ClassicLevels.Classic56: return new Classic56();
            case ClassicLevels.Classic57: return new Classic57();

            default: return null;
        }
    }

    public static GameLevel GetAdvancedLevel(AdvancedLevels level)
    {
        switch (level)
        {
            case AdvancedLevels.Advanced11: return new Advanced11();
            case AdvancedLevels.Advanced12: return new Advanced12();
            case AdvancedLevels.Advanced13: return new Advanced13();
            case AdvancedLevels.Advanced14: return new Advanced14();
            case AdvancedLevels.Advanced15: return new Advanced15();
            case AdvancedLevels.Advanced16: return new Advanced16();
            case AdvancedLevels.Advanced17: return new Advanced17();

            case AdvancedLevels.Advanced21: return new Advanced21();
            case AdvancedLevels.Advanced22: return new Advanced22();
            case AdvancedLevels.Advanced23: return new Advanced23();
            case AdvancedLevels.Advanced24: return new Advanced24();
            case AdvancedLevels.Advanced25: return new Advanced25();
            case AdvancedLevels.Advanced26: return new Advanced26();
            case AdvancedLevels.Advanced27: return new Advanced27();

            case AdvancedLevels.Advanced31: return new Advanced31();
            case AdvancedLevels.Advanced32: return new Advanced32();
            case AdvancedLevels.Advanced33: return new Advanced33();
            case AdvancedLevels.Advanced34: return new Advanced34();
            case AdvancedLevels.Advanced35: return new Advanced35();
            case AdvancedLevels.Advanced36: return new Advanced36();
            case AdvancedLevels.Advanced37: return new Advanced37();

            case AdvancedLevels.Advanced41: return new Advanced41();
            case AdvancedLevels.Advanced42: return new Advanced42();
            case AdvancedLevels.Advanced43: return new Advanced43();
            case AdvancedLevels.Advanced44: return new Advanced44();
            case AdvancedLevels.Advanced45: return new Advanced45();
            case AdvancedLevels.Advanced46: return new Advanced46();
            case AdvancedLevels.Advanced47: return new Advanced47();

            case AdvancedLevels.Advanced51: return new Advanced51();
            case AdvancedLevels.Advanced52: return new Advanced52();
            case AdvancedLevels.Advanced53: return new Advanced53();
            case AdvancedLevels.Advanced54: return new Advanced54();
            case AdvancedLevels.Advanced55: return new Advanced55();
            case AdvancedLevels.Advanced56: return new Advanced56();
            case AdvancedLevels.Advanced57: return new Advanced57();

            default: return null;
        }
    }
}
