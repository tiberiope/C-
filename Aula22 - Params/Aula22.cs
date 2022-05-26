using System;

class Aula22{
    static void Main(){

        //params;
        soma(3, 9, 14, 24, 53, 26);

    }

    static void soma(params int[]n){

        int res = 0;
        
        if(n.Length == 0){
            Console.WriteLine("Não existem valores.");
        }else if(n.Length < 2){
            Console.WriteLine("Valores insuficientes.");
        }else{
            foreach(int num in n){
                res += num;
            }
            Console.WriteLine("A soma dos valores é: {0}", res);        
            
        }

    }
}