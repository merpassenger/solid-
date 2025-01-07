

using LiskovSubstitutionPrincipleGood;

BasePhone phone = new Iphone();

phone.Call();
((ITakePhoto)phone).TakePhoto(); //Casting işlemi ile TakePhoto metodunu alabiliyorum 

phone = new Nokia3310();

phone.Call();