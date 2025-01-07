

using LiskovSubstitutionPrincipleBad;

BasePhone phone = new Iphone();

phone.Call();
phone.TakePhoto();

phone = new Nokia3310();

phone.Call();
phone.TakePhoto(); 
/*
 * 13. satırda patlar çünkü bu özelliği yok ama böyle bir durumda bu metot buraya hiç gelmemeli
 * Base class üzerine verilen farklı farklı nesne özellikleri 
 */