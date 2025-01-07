namespace InterfaceSegragationPrincipleGood;

public class ReadProductRepository : IProductReadRepository
{
    public List<Product> GetList()
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }
}