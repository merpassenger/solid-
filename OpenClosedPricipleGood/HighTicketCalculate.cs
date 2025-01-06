namespace OpenCloasedPricipleGood;

public class HighTicketCalculate : ITicketCalculate
{
    public decimal Calculate(decimal ticket)
    {
        return ticket * 4;
    }
}