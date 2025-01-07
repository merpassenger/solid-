namespace DependencyInversionPrincipleBad;

public class ProductRepositoryFromSqlServer
{
    public List<string> GetAll()
    {
        return new List<string>{"Data1SqlServer","Data2SqlServer"};
    }
}