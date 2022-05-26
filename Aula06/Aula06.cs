using System;

class Aula06{
    static void Main(){
        int n1, n2, n3;

        n1 = 10; n2 = 20; n3 = 30;
        Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);
        Console.WriteLine("\nn1 = {0} \nn2 = {1} \nn3 = {2}", n1, n2, n3);
        Console.WriteLine("\nn1 = {0} \n\tn2 = {1} \n\t\tn3 = {2}", n1, n2, n3);

        Console.WriteLine("------------------");

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra * lucro + valorCompra;

        Console.WriteLine("Valor do " + produto + " é: " + valorVenda);
        Console.WriteLine("Valor do {0} é: {1,15:c}", produto, valorVenda);
        Console.WriteLine("Lucro: {0:p}", lucro);


    }
}