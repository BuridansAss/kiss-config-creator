using App;
using System;

namespace App.KissConfig.Configs
{
    class FrameShopConfig : IConfig
    {
        public readonly string FileName = "gift_collections.config.php";

        public FrameShopConfig()
        {
            Console.WriteLine(this.FileName);
        }
    }
}