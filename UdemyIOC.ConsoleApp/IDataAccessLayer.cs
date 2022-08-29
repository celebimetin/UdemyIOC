using System.Collections.Generic;

namespace UdemyIOC.ConsoleApp
{
    interface IDataAccessLayer
    {
        List<Product> GetProducts();
    }
}