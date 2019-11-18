using System;
using App;
using App.Abstractions;
using App.KissConfig;
using App.KissConfig.Configs;

namespace configs
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigsEnum ce = new ConfigsEnum();
            ce.GetInstance(ce.Configs.FrameShopConfig);
            ce.GetInstance(0);
            ce.GetInstance(0);
            ce.GetInstance(0);
            ce.GetInstance(0);
            
        }
    }
}
