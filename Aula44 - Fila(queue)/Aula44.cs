using System;
using System.Collections.Generic;

class Aula44{
    static void Main(){
        string[] array = new string[3]{"avião", "moto", "carro"};
        Queue<string>veiculos = new Queue<string>(array);

        veiculos.Enqueue("skate");// add no final da fila.
        veiculos.Enqueue("navio");
        
        if(veiculos.Contains("avião")){
            Console.WriteLine("Avião encontrado.");
        }else{
            Console.WriteLine("Avião não encontrado.");
        }
        string primeiroElemento = veiculos.Peek();
        Console.WriteLine("Primeiro elemento é: {0}", primeiroElemento);
        Console.WriteLine("Item {0} removido.", veiculos.Dequeue());
        foreach(string v in veiculos){
            Console.WriteLine("Veículo: {0}", v);
        }
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);

        int cont=0;
        int vtotal=veiculos.Count;
        while (cont<vtotal){
            Console.WriteLine("Veículo {0} removido.", veiculos.Dequeue());
            cont++;
        }
        Console.WriteLine("");

        veiculos.Enqueue("carro");
        veiculos.Enqueue("barco");
        veiculos.Enqueue("cavalo");

        string veiculo;
        int tv = veiculos.Count;
        for(int i=0;i<tv;i++){
            veiculo = veiculos.Dequeue();
            Console.WriteLine("Veículo {0} removido.", veiculo);
        }

        veiculos.Clear();
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count);

    }
}