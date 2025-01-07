

using DependencyInversionPrincipleBad;

var ProductService = new ProductService(new ProductRepositoryFromSqlServer());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));