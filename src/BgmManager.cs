namespace DynamicBGM;

public class BgmManager
{
    /**
     * All available game BGM in one area. 
     */
    private GameBgm[] bgm_list = Array.Empty<GameBgm>();

    public BgmManager() { }

    /** This method is going to generate a list of possible game BGM according to current mood */
    public GameBgm[] proposeNextBgm(BgmMood mood = BgmMood.common)
    {
        // Should use BGMSelectAlgorithm to generate, according to `current_mood` and `next_mood`
        GameBgm[] bgm_matches = bgm_list.Where(e => e.mood.Contains(mood)).ToArray();

        return bgm_matches;
    }
}