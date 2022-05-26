using System;

class Aula05{
    static void Main(){
        
        int res=10+5;
        
        res += 3;
        res++;

        bool res2 = (10 < 5) | (5 < 6);
        bool res3 = (1==2) & (10 < 3);

        Console.WriteLine(res2);
        Console.WriteLine(res);
        Console.WriteLine(res3);
    }
}