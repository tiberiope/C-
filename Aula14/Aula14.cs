using System;

class Aula14{
    static void Main(){
        int n1, n2, n3, n4, n5;
        int[] n = new int[5];
        int[] num = new int[3] {55, 77, 99};
        int[] num2 = {1, 2, 3};
        
        string[] veiculos = new string[3];

        veiculos[0] = "Bike";
        veiculos[1] = "Barco";
        veiculos[2] = "pé";

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;

        Console.WriteLine(n[1]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num2[2]);
        Console.WriteLine(veiculos[2]);
    }
}