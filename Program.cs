namespace DynamicBGM;

/**
 * Contains singeleton of a BgmManager
 */
public class API
{
    private static BgmManager bgm_manager = new();

    /**
     * Offer the map position of players.
     */
    public static void offerPlayerPosition(int x, int y, int z = 0) { }

    public static void getNextBgm() { }

    public static void offerGameMapDataJson(string data) { }

    public static void offerBgm()
    {
    }

    public static void Main(string[] args)
    {

    }
}