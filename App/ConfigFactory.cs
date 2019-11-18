using App.Abstractions;
using App.KissConfig.Configs;

namespace App
{
    class ConfigFactory : IFactory
    {
       public IProduct create()
       {
           return new FrameShopConfig();
       }
        
    }
}