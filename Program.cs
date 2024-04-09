using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia(numero: "123456", modelo: "v5", memoria: 128, iMEI: "1234432322");
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
var iphone = new Iphone(numero: "1223456", modelo: "I15", memoria: 128, iMEI: "43233332666");
iphone.Ligar();
iphone.InstalarAplicativo("FaceBook");