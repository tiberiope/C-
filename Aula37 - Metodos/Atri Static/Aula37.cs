using System;

class Mat{
    public static double pi=3.14;

    public static double dobro(double n){
        return n*2;
    }
}

class Aula37{
    static void Main(){
        double vpi = Mat.pi;
        
        Console.WriteLine("Dobro de {0} é {1}.", vpi, Mat.dobro(vpi));
    }
}