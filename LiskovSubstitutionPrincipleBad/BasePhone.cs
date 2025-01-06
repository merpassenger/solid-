namespace LiskovSubstitutionPrincipleBad;

public abstract class BasePhone
{
    public void Call()
    {
        Console.WriteLine("Called");
    }

    public abstract void TakePhoto();
}