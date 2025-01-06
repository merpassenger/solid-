namespace OpenClosedPrinciple;

/*
 * İhtiyaç karşılasa da enum içerisine gelebilecek olan yeni Type değerlerinde switch-case bloklarına ekleme
 * yapılması gerekmekte, yani aslında değişime uğramakta olacaktır.
 *
 * Open Closed Priciple ise gelişime açık ama değişime açık olmalı bir uygulama demektedir.
 */
public class TicketCalculator
{
    public decimal Calculate(decimal amount, TicketType ticketType)
    {
        decimal ticketAmount = 0;

        switch (ticketType)
        {
            case TicketType.Low:
                ticketAmount = amount * 2;
                break;
            case TicketType.Mid:
                ticketAmount = amount * 3;
                break;
            case TicketType.High:
                ticketAmount = amount * 4;
                break;
            default:
                break;
        }

        return ticketAmount;
    }
}