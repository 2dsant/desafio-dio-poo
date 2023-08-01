using DesafioPOO.Models;

Nokia c1 = new Nokia("985412544", "Nokia", "11111", 64);
Iphone c2 = new Iphone("952147585", "Apple", "22222", 124);

c1.Ligar();
c1.InstalarAplicativo("Facebook");

Console.WriteLine("======");
c2.Ligar();
c2.InstalarAplicativo("Facebook");