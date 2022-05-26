using System;

class Aula21{

    static void Main(){
        //referencia de variável; argumento out;
        int x = 5;
        int y = 4;
        int q, rest;
        x = cubo(x);
        Console.WriteLine(x);

        quadrado(ref y);
        Console.WriteLine(y);

        q = divide(10, 3, out rest);
        Console.WriteLine("Quociente {0}, resto {1}", q, rest);
    }

    static int cubo(int valor){
        valor = Convert.ToInt32(Math.Pow(valor, 3));

        return valor;
    }

    static void quadrado(ref int valor){

        valor = Convert.ToInt32(Math.Pow(valor, 2));
    }

    static int divide(int dividendo, int divisor, out int resto){
        resto = dividendo%divisor;

        return dividendo/divisor;
    }
}