// See https://aka.ms/new-console-template for more information
using TestGitHub;
using TestGitHub.ClassSarah;

Console.WriteLine("This is sprint 1!");

Console.WriteLine("Not This");
Console.WriteLine("Nope");

Console.WriteLine("TestSarah");
Console.WriteLine("TestJulie");


JulieClass jc = new JulieClass("Julie", "adresse 123");
Sarah SClass = new Sarah(25);

Console.WriteLine(jc.Name);
Console.WriteLine(jc.Address);

Console.WriteLine("Alder:" + SClass.Alder);

Sarah SClass1 = new Sarah(25);
Sarah SClass2 = new Sarah(19);
Sarah SClass3 = new Sarah(32);

Console.WriteLine("\t"+SClass.Alder + SClass1.Alder);
Console.WriteLine("\t"+SClass.Alder + SClass2.Alder);
Console.WriteLine("\t"+SClass3.Alder + SClass1.Alder);