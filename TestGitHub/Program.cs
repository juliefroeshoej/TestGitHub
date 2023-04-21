// See https://aka.ms/new-console-template for more information
using TestGitHub;
using TestGitHub.ClassSarah;

Console.WriteLine("This is sprint 1!");

Console.WriteLine("Not This");
Console.WriteLine("Nope");

Console.WriteLine("TestSarah");
Console.WriteLine("TestJulie");

Console.WriteLine("Hej med dig :)");

Console.WriteLine("Heeeej :)");

JulieClass jc = new JulieClass("Julie", "adresse 123");
Sarah SClass = new Sarah(23);

Console.WriteLine(jc.Name);
Console.WriteLine(jc.Address);

Console.WriteLine("Alder:" + SClass.Alder);

Sarah SClass1 = new Sarah(7);
Sarah SClass2 = new Sarah(29);
Sarah SClass3 = new Sarah(35);

Console.WriteLine(SClass.Alder + SClass1.Alder);
Console.WriteLine(SClass.Alder + SClass2.Alder);
Console.WriteLine(SClass3.Alder + SClass1.Alder);