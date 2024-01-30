using System.Reflection.PortableExecutable;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone: Nokia");

Smartphone nokia = new Nokia(ddd: "", numero: "96348752", modelo: "Nokia l78", imai: "1g5422h3", memoria: 64);



nokia.AdiconarOddd();
nokia.EscolherOpcoes();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine();
Console.WriteLine($"Numero do Nokia {nokia.Numero}");





Console.WriteLine();




Console.WriteLine("Iphone Pro");
Smartphone iphone = new Iphone(ddd: "", numero: "94563127", modelo: "iphone X", imai: "222222222", memoria: 128);
iphone.AdiconarOddd();
iphone.EscolherOpcoes();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine();
Console.WriteLine($"Numero do iphone {iphone.Numero}");