using System.Collections.Generic;

namespace UdemyIOC.ConsoleApp
{
    class OracleDal : IDataAccessLayer
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1, Name="Oracle Kalem1", Price=100, Stock=100},
                new Product{Id=2, Name="Oracle Kalem2", Price=100, Stock=100},
                new Product{Id=3, Name="Oracle Kalem3", Price=100, Stock=100},
                new Product{Id=4, Name="Oracle Kalem4", Price=100, Stock=100},
                new Product{Id=5, Name="Oracle Kalem5", Price=100, Stock=100}
            };
        }
    }
}