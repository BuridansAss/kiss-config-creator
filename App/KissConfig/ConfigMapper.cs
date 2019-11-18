using App.KissConfig.Configs;

namespace App.KissConfig
{
    class ConfigMapper
    {
        private static IConfig[] map = {
            new FrameShopConfig(),
            new HatAndIconShopConfig(),
        };

        public static IConfig Config(int number)
        {
            return map[number];
        }
    }
}