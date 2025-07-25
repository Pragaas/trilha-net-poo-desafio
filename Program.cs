using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123124", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmarthPone Iphone");
Smartphone iphone = new Iphone(numero: "1312412", modelo: "Medelo 2", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");