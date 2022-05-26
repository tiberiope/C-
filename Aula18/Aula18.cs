using System;

class Aula18{
    static void Main(){
        int[] num = new int[3]{11,22,33};

        for(int n = 0; n < num.Length; n++){
            Console.WriteLine(num[n]);
        }

        foreach(int n in num){
            Console.WriteLine(n);
        }
    }
}