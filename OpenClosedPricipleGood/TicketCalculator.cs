namespace OpenCloasedPricipleGood;

public class TicketCalculator 
{
    public decimal Calculator(decimal ticket, ITicketCalculate ticketCalculate)
    {
        return ticketCalculate.Calculate(ticket);
    }
}