using System;
using System.Collections.Generic;
class Aula41{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary <int, string>();
        veiculos.Add(0, "Carro");
        veiculos.Add(1, "Avião");
        veiculos.Add(2, "Navio");
        veiculos.Add(3, "Moto");
        veiculos.Add(4, "Patinete");

        Console.WriteLine("Tamanho do dictionary: {0}", veiculos.Count);

        if(veiculos.ContainsKey(1)){
            Console.WriteLine("Valor da chave 1 é: {0}", veiculos[1]);
        }
        if(veiculos.ContainsValue("Avião")){
            Console.WriteLine("Contém Avião.");
        }else{
            Console.WriteLine("Não contém Avião.");
        }

        veiculos.Remove(1);

        if(veiculos.ContainsValue("Avião")){
            Console.WriteLine("Comtém Avião.");
        }else{
            Console.WriteLine("Não contém Avião.");
        }

        veiculos[4] = "Bicicleta";
        if(veiculos.ContainsValue("Bicicleta")){
            Console.WriteLine("Contém Bicicleta.");
        }else{
            Console.WriteLine("Não contém Bicicleta.");
        }

        foreach(KeyValuePair<int, string> n in veiculos){
            Console.WriteLine("Chave = {0}, Valor = {1}", n.Key, n.Value);
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values;
        foreach(string n in valores){
            Console.WriteLine("Valor = {0}", n);
        }

        veiculos.Clear();
        Console.WriteLine("\nDicionário limpo. Novo tamanho = {0}.", veiculos.Count);
    }
}