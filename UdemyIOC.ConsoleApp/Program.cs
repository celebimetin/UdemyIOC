using System;

namespace UdemyIOC.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic(new OracleDal());
            businessLogic.GetProducts().ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
            });
            Console.ReadLine();
        }
    }
}