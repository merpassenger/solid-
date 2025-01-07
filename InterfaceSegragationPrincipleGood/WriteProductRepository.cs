namespace InterfaceSegragationPrincipleGood;

public class WriteProductRepository : IProductWriteRepository
{
    public Product Create(Product p)
    {
        throw new NotImplementedException();
    }
}