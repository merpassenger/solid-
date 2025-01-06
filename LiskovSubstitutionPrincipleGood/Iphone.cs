namespace LiskovSubstitutionPrincipleGood;

public class Iphone : BasePhone, ITakePhoto
{
    public void TakePhoto()
    {
        Console.WriteLine("Cheese");
    }
}