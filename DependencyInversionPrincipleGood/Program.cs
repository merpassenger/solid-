/*
 
 Bu prensip bize high-level modüllerin low-level modüller birbirne bağlanmayacak, her ikisi de  bir soyutlama üzerine  bağlı olacak
 High-level -> product Service
 Low-level -> product service içerisinde kullanılan bir repository 
 
 Bu bağlantının olmamasının sebebi ise , low level üzerinde yapılacak herhangi bir değişiklik sonucunda onu kullanan high-level modülümde de değişiklik 
 meydana gelmesidir
 
 Bu soyutlama araya bir INTERFACE katmanının eklenmesi ile düznelenecek 
 
 */

using DependencyInversionPrincipleGood;

var ProductService = new ProductService(new ProductRepositoryFromMongo());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));
