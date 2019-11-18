namespace App.Abstractions
{
    interface IFactory
    {
        public IProduct Create(int number = 0);
    }
}