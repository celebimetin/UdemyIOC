using System.Collections.Generic;

namespace UdemyIOC.ConsoleApp
{
    class DataAccessLayer : IDataAccessLayer
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1, Name="Kalem1", Price=100, Stock=100},
                new Product{Id=2, Name="Kalem2", Price=100, Stock=100},
                new Product{Id=3, Name="Kalem3", Price=100, Stock=100},
                new Product{Id=4, Name="Kalem4", Price=100, Stock=100},
                new Product{Id=5, Name="Kalem5", Price=100, Stock=100}
            };
        }
    }
}