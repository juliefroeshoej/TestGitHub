﻿// See https://aka.ms/new-console-template for more information
using TestGitHub;
using TestGitHub.ClassSarah;

Console.WriteLine("This is sprint 1!");

Console.WriteLine("Not This");
Console.WriteLine("Nope");
Console.WriteLine("TestSarah");
Console.WriteLine("TestJulie");

Console.WriteLine("Hej med dig :)");

JulieClass jc = new JulieClass("Julie", "adresse 123");
Console.WriteLine(jc.Name);
Console.WriteLine(jc.Address);

Sarah SClass = new Sarah(25);
Console.WriteLine(SClass.Alder);
