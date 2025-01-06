// See https://aka.ms/new-console-template for more information

using OpenCloasedPricipleGood;

TicketCalculator ticketCalculator = new TicketCalculator();

Console.WriteLine("Low Ticket Result: " +ticketCalculator.Calculator(1000, new LowTicketCalculate()));
Console.WriteLine("Mid Ticket Result: " +ticketCalculator.Calculator(10000, new MidTicketCalculate() ));
Console.WriteLine("High Ticket Result: " +ticketCalculator.Calculator(10000, new HighTicketCalculate()));