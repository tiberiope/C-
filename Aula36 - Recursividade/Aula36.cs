using System;

class Calc{
    int num = 1;
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

    public int fatorial(int fat){
        num *= fat;
        if (fat > 1){
            fatorial(fat-1);
        }
        return num;
    }
}

class Aula35{
    static void Main(){
        int fat;
        fat = 10;
        Calc c1 = new Calc();
        Console.WriteLine(c1.soma(10.1, 20.3, 23.2, 321.34));
        Console.WriteLine(c1.soma(10, 20, 30, 20, 20, 30, 40, 50, 50, 190));
        Console.WriteLine("Fatorial de {0} é: {1}", fat, c1.fatorial(fat));
    }
}