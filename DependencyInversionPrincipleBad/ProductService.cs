namespace DependencyInversionPrincipleBad;

public class ProductService
{
    private readonly ProductRepositoryFromSqlServer _repository;

    public ProductService(ProductRepositoryFromSqlServer repository)
    {
        _repository = repository;
    }


    public List<string> GetAll()
    {
        return _repository.GetAll();
    }
}

/*
Bu DIP i ihlal eden bir kullanımdır, çünkü highLevel kod olan Service kullandığı repository class ını doğrudan bilmektedir.
*/