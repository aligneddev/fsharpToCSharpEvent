// See https://aka.ms/new-console-template for more information
using CLI.Fsharp;

Console.WriteLine("Hello, World!");

var handler = new Say.HelloHandler();
handler.ChangedEvent += (sender, arg) =>
{
    Console.WriteLine($"Event - {arg}");
};

handler.Hello(HelloEvent.NewHi("Kevin"));