namespace OpenCloasedPricipleGood;

public interface ITicketCalculate
{
    //Aslında bilet fiyatı hesaplayan metotlar olacak ve her metot bir baz bilet fiyatı alacak onu dönüştürecek
    decimal Calculate(decimal ticket);
}