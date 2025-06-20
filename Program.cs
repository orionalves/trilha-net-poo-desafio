using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+5571999696969", modelo: "Modelo 1", imei: "1234", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("----------------------");
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "+5571999898989", modelo: "Modelo 2", imei: "4321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");