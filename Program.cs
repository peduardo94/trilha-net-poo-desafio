using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111", memoria: 64);
Nokia.Ligar("123456");
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "22222", memoria: 128);
Iphone.ReceberLigacao("1112");
Iphone.Ligar("4987");
Iphone.InstalarAplicativo("Whatsapp");

