namespace InterfaceSegragationPrincipleGood;

public class ReadProductRepository : IProductRepository
{
    public List<Product> GetList()
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Product Create(Product p)
    {
        throw new NotImplementedException();
    }

    public Product Update(Product p)
    {
        throw new NotImplementedException();
    }

    public Product Delete(Product p)
    {
        throw new NotImplementedException();
    }
}

/*
* Bu şekilde bir implemantasyon sonucunda aslında client lib üzeirnde sadece okuma işlemi yapılacak ve GetList ile
 * GetById ihtiyacı varken diğer metotlarda bulunmakta ve geri kalan crud işlemleri için de metot implemaente olmaktadır
*/