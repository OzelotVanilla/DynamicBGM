namespace DynamicBGM;

public class GameBgm
{
    public string name { get; }

    public BgmMood[] mood { get; }

    public BgmType type { get; }

    public GameBgm(string name, BgmType type = BgmType.body)
    {
        this.name = name;
        this.mood = new BgmMood[] { BgmMood.common };
        this.type = type;
    }

    public GameBgm(string name, BgmMood[] mood, BgmType type = BgmType.body)
    {
        this.name = name;
        this.mood = mood;
        this.type = type;
    }
}