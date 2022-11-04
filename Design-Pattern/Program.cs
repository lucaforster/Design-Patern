// See https://aka.ms/new-console-template for more information

using Design_Pattern;

SingeltonPattern Peter = SingeltonPattern.getInstance();

Peter.setName("Peter");

Console.WriteLine(Peter.Bestellung());

SingeltonPattern Manfred = SingeltonPattern.getInstance();

Manfred.setName("Manfred");

Console.WriteLine(Manfred.Bestellung());
Console.WriteLine(Peter.Bezahlung());
