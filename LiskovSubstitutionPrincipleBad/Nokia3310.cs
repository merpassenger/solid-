namespace LiskovSubstitutionPrincipleBad;

public class Nokia3310 : BasePhone
{
    public override void TakePhoto()
    {
        throw new NotImplementedException();
    }
}