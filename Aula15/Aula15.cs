using System;

class Aula15{
    static void Main(){
        int[,] num = new int[3,3];
        int[,] num2 = new int[2,2]{{1, 2}, {3, 4}};

        num[0,0] = 1;
        num[0,1] = 2;
        num[0,2] = 3;
        num[1,0] = 4;
        num[1,1] = 5;
        num[1,2] = 6;
        num[2,0] = 7;
        num[2,1] = 8;
        num[2,2] = 9;

        Console.WriteLine(num[1,1]);
        Console.WriteLine(num2[1,0]);
    }
}