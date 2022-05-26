using System;

class Calc{
    static void Main(){
        int inicial, razao, qtd, res;
        inicial = razao = qtd = res = 0;
        int n = 1;

        Console.Write("Entre com o valor inicial: ");
        inicial = Int32.Parse(Console.ReadLine());
        Console.Write("Entre com a razão: ");
        razao = Int32.Parse(Console.ReadLine());
        Console.Write("Entre com o termo buscado: ");
        qtd = Int32.Parse(Console.ReadLine());
        
        while(n<=qtd){
            res += razao; 
            n++;
        }
        res += inicial;

        Console.WriteLine("Resultado: {0}", res);
        Console.WriteLine("Resultado2: {0}", razao*qtd+inicial);
    }
}