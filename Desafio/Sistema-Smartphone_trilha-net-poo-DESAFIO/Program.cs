using DesafioPOO.Models;


Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "1232113", modelo: "C20", imei: "34554345", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

nokia.SmartphoneConfig("Nokia");



Console.WriteLine("\n");
Console.WriteLine("\n");



Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "8567567", modelo: "14 Pro Max", imei: "988969", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Hyperlapse");

Console.WriteLine("\n");

iphone.SmartphoneConfig("Iphone");




