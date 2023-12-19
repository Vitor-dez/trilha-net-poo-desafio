using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone: Nokia");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia l78", imai: "1g5422h3", memoria: 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();



Console.WriteLine(">======================<");




Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "45698", modelo: "iphone x", imai: "222222222", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine();