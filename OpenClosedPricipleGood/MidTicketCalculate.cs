namespace OpenCloasedPricipleGood;

public class MidTicketCalculate : ITicketCalculate
{
    public decimal Calculate(decimal ticket)
    {
        return ticket * 3;
    }
}