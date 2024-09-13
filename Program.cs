using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone NOKIA");
Nokia c1 = new Nokia(numero: "111-111-111", modelo: "Nokia1", imei: "00000", memoria: 128);

c1.Ligar();
c1.InstalarAplicativo("Ifood");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPHONE");
Iphone c2 = new Iphone(numero: "222-222-222", modelo: "Iphone 15 Pro", imei: "11111", memoria: 256);
c2.Ligar();
c2.InstalarAplicativo("Instagram");

