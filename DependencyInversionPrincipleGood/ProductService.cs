namespace DependencyInversionPrincipleGood;

public class ProductService
{
    private readonly IRepository _repository;

    public ProductService(IRepository repository)
    {
        _repository = repository;
    }

    public List<string> GetAll()
    {
        return _repository.GetAll();
    }
}