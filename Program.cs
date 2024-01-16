using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone: Nokia");

Smartphone nokia = new Nokia(numero: "96348752", modelo: "Nokia l78", imai: "1g5422h3", memoria: 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();



Console.WriteLine(">-------------------<");




Console.WriteLine("Iphone Pro");
Smartphone iphone = new Iphone(numero: "94563127", modelo: "iphone X", imai: "222222222", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine(iphone.Numero);
Console.WriteLine();