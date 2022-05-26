using System;
using System.Collections.Generic;

class Aula43{
    static void Main(){
        List<string> carros = new List<string>();
        carros.Add("Jeep");
        carros.Add("Wrangler");
        carros.Add("LandRover");
        carros.Add("Jimny");

        List<string> carros2 = new List<string>();
        carros2.AddRange(carros);

        if (carros.Contains("Jeep")){
            Console.WriteLine("Jeep está na lista.");
        }else{
            Console.WriteLine("Jeep não encontrado.");
        }

        carros.Clear();
        Console.WriteLine("Qtd de carros: {0}", carros.Count);

        string[] carros3 = new string[4];
        carros2.CopyTo(carros3, 0);

        foreach(string c in carros3){
            Console.WriteLine("Carro: {0}", c);
        }

        int pos=0;
        pos = carros2.IndexOf("LandRover");
        Console.WriteLine("Carro {0} está na posição {1}.\n", carros2[pos], pos);

        carros2.Insert(1, "Buggy");

        carros2.Add("Jeep");
        pos = carros2.LastIndexOf("Jeep");
        Console.WriteLine("O último Jeep está na posição: {0}\n", pos);

        foreach(string c in carros2){
            Console.WriteLine("Carro: {0}", c);
        }
        Console.WriteLine("");

        carros2.Remove(carros2[pos]);
        foreach(string c in carros2){
            Console.WriteLine("Carro: {0}", c);
        }

        Console.WriteLine("");
        carros2.Insert(0, "Jeep");
        carros2.RemoveAt(5);

        foreach(string c in carros2){
            Console.WriteLine("Carro: {0}", c);
        }

        Console.WriteLine("");

        carros2.Sort();
        carros2.Reverse();

        foreach(string c in carros2){
            Console.WriteLine("Carro: {0}", c);
        }

        int capacidade = carros2.Capacity;
        Console.WriteLine("\nCapacidade da lista: {0}", capacidade);

        carros2.Capacity = 15;
        Console.WriteLine("\nNova capacidade da lista: {0}", carros2.Capacity);
    }
}