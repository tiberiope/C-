using System;

class Aula16{
    static void Main(){
        
        int[] num3 = new int[50];
        int num;

        for (int num2 = 0; num2 < num3.Length; num2++){
            num3[num2] = num2 + 1;
        }
        
        for (int num2 = 0; num2 < num3.Length; num2++){
            Console.Write("{0} ", num3[num2]);
        }

        for(num=0; num<10; num++){
            
            if (num == 9){
                Console.WriteLine(num);
            }else{
                Console.Write(num);
            }
        }

        for(int num2=0; num2< 10; num2+=1){
            Console.Write(num2);
        }
    }
}