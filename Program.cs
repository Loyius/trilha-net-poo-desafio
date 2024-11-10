using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo1", imei: "000111222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "67891", modelo:"Modelo2", imei: "333444555", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
