using System;
using System.Diagnostics;

class Aula12{
    
    static void Main(){

        // > < >= <= == !=
        int n1, n2, n3, n4;
        double media = 0;

        n1 = n2 = n3 = n4 = 0;
    
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());
        
        media = (n1 + n2 + n3 + n4)/4.0;

        if (media >= 7){
            if (media >= 9){
                resultado = "Aprovado com louvor";
            }else{
                resultado = "Aprovado";
            }
        }else if (media < 7 & media >= 4){
            resultado = "Recuperação";
        }else{
            if (media < 2){
                resultado = "Muito reprovado";
            }else{
                resultado = "Reprovado";
            }
        }

        Console.WriteLine("Resultado: {0}", resultado);
        Console.WriteLine("Média: {0}", media);
    }
}