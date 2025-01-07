namespace DependencyInversionPrincipleGood;

public class ProductRepositoryFromMongo : IRepository
{
    public List<string> GetAll()
    {
        return new List<string>{"Data1Mongo","Data2Mongo"};
    }
}