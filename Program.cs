using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero:"1500777", modelo:"520", imei:"11122", memoria:"64");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Iphone");

Iphone iphone = new Iphone(numero:"1600888", modelo:"Pro Max 14", imei:"222111", memoria:"120", sistema:"IOS");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Teste Finalizado!");




