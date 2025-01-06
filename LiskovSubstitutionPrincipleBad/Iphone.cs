namespace LiskovSubstitutionPrincipleBad;

public class Iphone : BasePhone
{
    public override void TakePhoto()
    {
        Console.WriteLine("Cheese!");
    }
}