using System;

class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: {0}.", nome);

        Console.WriteLine("----------");

        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        
        soma = v1 + v2;

        Console.WriteLine("Resultado da soma é: {0}", soma);
    }
}