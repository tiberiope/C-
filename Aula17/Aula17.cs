using System;

class Aula17{
    static void Main(){
        int x = 0;
        int y = 1;

        while(x < 10){
            Console.Write("{0} ", y);
            y+= y;
            x++;
        }

        do{
            Console.WriteLine("  valor de x é: {0}", x);
        }while(x < 10);

        string senha = "123";
        string senha2;

        do{
            Console.Write("Digite a senha: ");
            senha2 = Console.ReadLine();
            Console.Clear();
        }while(senha != senha2);

        Console.WriteLine("Senha correta!");
    }
}