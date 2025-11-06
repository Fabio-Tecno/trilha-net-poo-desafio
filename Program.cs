using DesafioPOO.Models;

Smartphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456789", 128);
Console.WriteLine("Smartphone Iphone: ");
iphone.ImprimirModeloeMemoria();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("'Instagram'");

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", 32);
nokia.ImprimirModeloeMemoria();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("'Telegram'");
