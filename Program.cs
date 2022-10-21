using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia ------------------------------");

Smartphone telefone1 = new Nokia(numero:"799912546",modelo: "C01 Plus",iMEI: "*#06#",memoria: 24);

telefone1.Ligar();
telefone1.ReceberLigacao();
telefone1.InstalarAplicativo("google maps");

Console.WriteLine("Iphone ------------------------------");

Smartphone telefone2 = new Iphone(numero: "798463456", modelo: "4 CDMA", iMEI: "*#06#", memoria: 54);

telefone2.Ligar();
telefone2.ReceberLigacao();
telefone2.InstalarAplicativo("Linkedin");
