using App.Abstractions;

namespace App.KissConfig
{
    class ConfigFactory : IFactory
    {
        public IProduct Create(int number)
        {
            return ConfigMapper.Config(number);
        }
    }
}