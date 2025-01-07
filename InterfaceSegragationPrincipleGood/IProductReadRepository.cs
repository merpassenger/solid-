namespace InterfaceSegragationPrincipleGood;

public interface IProductReadRepository
{
    List<Product> GetList();

    Product GetById(int id);
}