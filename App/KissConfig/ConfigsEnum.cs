using App.KissConfig.Configs;

namespace App.KissConfig
{
    class ConfigsEnum
    {
        public enum onfigs
        {
            FrameShopConfig,

        }

        private static IConfig[] mapConfig = 
        {
            new FrameShopConfig()
        };

        public IConfig GetInstance(int configEnum)
        {
            return mapConfig[configEnum];
        }
    }
}