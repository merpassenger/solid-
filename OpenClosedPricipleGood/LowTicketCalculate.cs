namespace OpenCloasedPricipleGood;

public class LowTicketCalculate: ITicketCalculate
{
    public decimal Calculate(decimal ticket)
    {
        return ticket * 2;
    }
}