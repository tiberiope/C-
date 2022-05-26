using System;

delegate int Op(params int[] n);

class Mat{
    public static int soma(params int[]n){
        return n[0] + n[1];
    }

    public static int mult(params int[]n){
        return n[0] * n[1];
    }
}
class Aula38{

    static void Main(){
        int res;
        Op d1 = new Op(Mat.soma);
        res = d1(10, 50);
        Console.WriteLine("Soma: {0}", res);

        d1 = new Op(Mat.mult);
        res = d1(10, 50);
        Console.WriteLine("mult: {0}", res);

    }
}