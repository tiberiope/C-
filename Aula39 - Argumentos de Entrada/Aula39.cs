using System;

class Aula39{
    static void Main(string[] args){
        if(args.Length > 0){
            Console.WriteLine("Qtd de argumentos {0}", args.Length);
            int soma=0;
            for(int i=0;i<args.Length;i++){
                Console.WriteLine("Argumento: {0} = {1}", i, args[i]);
                soma += Int32.Parse(args[i]);
            }
            Console.WriteLine("Resultado: {0}", soma);
        }else{
            Console.WriteLine("Sem argumentos");
        }
    }
}