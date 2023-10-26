namespace DynamicBGM;

public static class Algorithm
{
    public delegate GameBgm[] BgmSelectAlgorithm(BgmMood current_mood, BgmMood next_mood, GameBgm[] all_bgm);

    private static Random random_gen = new Random();

    public readonly static BgmSelectAlgorithm random = new(getRandomResult);

    public static GameBgm[] getRandomResult(BgmMood current_mood, BgmMood next_mood, GameBgm[] all_bgm)
    {
        return new GameBgm[] { all_bgm[Algorithm.random_gen.Next(0, all_bgm.Length)] };
    }
}