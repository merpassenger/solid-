namespace InterfaceSegragationPrincipleGood;

public interface IProductRepository
{
    List<Product> GetList();

    Product GetById(int id);

    Product Create(Product p);

    Product Update(Product p);

    Product Delete(Product p);
}