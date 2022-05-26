using System;

class Aula20{
    static void Main(){
        int v1, v2, r;

        Console.WriteLine("Entre com 2 valores: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());

        r = soma(v1, v2);

        Console.WriteLine("A soma de {0} mais {1} é: {2}", v1, v2, r);
        Console.WriteLine("A soma de {0} mais {1} é: {2}", v1, v2, soma(v1, v2));
    }

    static int soma(int n1, int n2){
        int res = n1 + n2;

        return res;

    }
}