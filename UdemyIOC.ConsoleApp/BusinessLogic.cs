using System.Collections.Generic;

namespace UdemyIOC.ConsoleApp
{
    class BusinessLogic
    {
        private readonly IDataAccessLayer _dataAccessLayer;
        public BusinessLogic(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }
        public List<Product> GetProducts()
        {
            return _dataAccessLayer.GetProducts();
        }
    }
}