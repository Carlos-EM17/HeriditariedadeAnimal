using HerançaTest;
using System;

class Program
{
    static void Main(string[] args)
    {
        Animal c = new Cachorro("Caramelo", 5);
        Animal g = new Gato("Luna", 9);
        Animal p = new Passaro("Papagalli", 10);

        MostraAnimal(c);
        MostraAnimal(g);
        MostraAnimal(p);
    }

    public static void MostraAnimal(Animal x)
    {
        Console.WriteLine($"Nome: {x.Nome}");
        Console.WriteLine($"Especie: {x.Especie}");
        Console.WriteLine($"Idade: {x.Idade}");
        Console.WriteLine($"Locomoção: {x.Locomoção}");
        Console.WriteLine("");
    }
    
}



