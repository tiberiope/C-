using System;

class Calc{
    public double soma(params double[] n){
        double res=0;
        foreach(double i in n){
            res += i;
        }
        return res;
    }
    public int soma(params int[] n){
        int res=0;
        for (int i = 0; i < n.Length;i++){
            res += n[i];
        }
        return res;
    }
}

class Aula35{
    static void Main(){
        Calc c1 = new Calc();
        Console.WriteLine(c1.soma(10.1, 20.3, 23.2, 321.34));
        Console.WriteLine(c1.soma(10, 20, 30, 20, 20, 30, 40, 50, 50, 190));
    }
}