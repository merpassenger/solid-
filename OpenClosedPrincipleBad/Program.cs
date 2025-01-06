// See https://aka.ms/new-console-template for more information

using OpenClosedPrinciple;

TicketCalculator ticketCalculator = new TicketCalculator();

Console.WriteLine("Low Ticket Result: " +ticketCalculator.Calculate(10000, TicketType.Low));
Console.WriteLine("Mid Ticket Result: " +ticketCalculator.Calculate(10000, TicketType.Mid));
Console.WriteLine("High Ticket Result: " +ticketCalculator.Calculate(10000, TicketType.High));