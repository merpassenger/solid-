namespace DependencyInversionPrincipleGood;

public class ProductRepositoryFromSqlServer : IRepository
{
    public List<string> GetAll()
    {
        return new List<string>{"Data1SqlServer","Data2SqlServer"};
    }
}