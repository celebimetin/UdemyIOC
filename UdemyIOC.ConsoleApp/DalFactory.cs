namespace UdemyIOC.ConsoleApp
{
    class DalFactory
    {
        public static IDataAccessLayer GetDal()
        {
            return new DataAccessLayer();
        }
    }
}