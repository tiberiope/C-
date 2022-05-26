using System;
using System.Collections.Generic;

class Aula42{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Barco");

        transp.AddLast("Bicicleta");

        LinkedListNode<string>node;
        node = transp.FindLast("Bicicleta").Previous;
        transp.AddBefore(node, "Moto");

        LinkedListNode<string>node2;
        node2 = transp.FindLast("Moto");
        transp.AddAfter(node2, "Foguete");



        foreach(string n in transp){
            Console.WriteLine("Transporte: {0}", n);
        }

        if(transp.Find("Carro")==null){
            Console.WriteLine("Carro não encontrado!");
        }else{
            Console.WriteLine("Carro encontrado!");
        }

        //transp.RemoveFirst();
        //transp.RemoveLast();
        transp.Remove("Navio");
        if(transp.Find("Navio")==null){
            Console.WriteLine("Navio não encontrado!");
        }else{
            Console.WriteLine("Navio encontrado!");
        }
        
        transp.Clear();
        Console.WriteLine("Quantidade de transportes: {0}", transp.Count);
    }
}