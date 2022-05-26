using System;

class Aula19{
    static void Main(){

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5]{{1,2,3,4,5}, {6, 7, 8, 9, 10}};

        Random random = new Random();
        for(int i=0; i< vetor1.Length;i++){
            vetor1[i] = random.Next(5);
            Console.Write("{0} ",vetor1[i]);
        }

        foreach(int n in vetor1){
            Console.Write("{0} ", n);
        }

        //public static int BinarySearch(array, valor);
        Console.WriteLine("\nBinarySearch");
        int procurado = 4;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("----------------");

        //public static void Copy(Ar_origem, Ar_destino, qtd_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);

        foreach(int n in vetor2){
            Console.Write("{0} ", n);
        }

        Console.WriteLine("\n----------------");

        //public void CopyTo(Ar_destino, a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);

        foreach(int n in vetor3){
            Console.Write("{0} ",n);
        }
        Console.WriteLine("\n----------------");

        //public longGetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Qnt de Elementos {0}", qtdElementosVetor);
        Console.WriteLine("-----------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("Menor índice da matriz {0}", MenorIndiceMatriz_D1);
        Console.WriteLine("-----------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do Vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("Maior índice da matriz {0}", MaiorIndiceMatriz_D1);
        Console.WriteLine("------------");

        //public object GetValue(long índice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}, valor da matriz: {1}", valor0, valor1);
        Console.WriteLine("-------------");

        //public static int IndexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("O índice de 3 é: {0}", indice1);
        Console.WriteLine("-------------");

        //public static int LastIndexOf(array, valor);
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("O índice do último 3 é: {0}", indice2);
        Console.WriteLine("-----------");

        //public static void Reverse(array);
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.Write("{0} ", n);
        }
        Console.WriteLine("\n----------");

        //public static SetValue(object valor, long pos);
        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0);
        for(int num = 0; num<vetor2.Length; num++){
            vetor2.SetValue(num, num);
        }
        Console.Write("Vetor 2: ");
        foreach(int num in vetor2){
            Console.Write("{0} ", num);
        }
        Console.WriteLine("-----------");

        //public static void Sort(array);
        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Array.Reverse(vetor3);

        Console.WriteLine("Vetor 1");
        foreach(int n in vetor1){
            Console.Write("{0} ", n);
        }

        Console.WriteLine("\nVetor 2");
        foreach(int n in vetor2){
            Console.Write("{0} ", n);
        }

        Console.WriteLine("\nVetor 3 inverso do vetor 1");
        foreach(int n in vetor3){
            Console.Write("{0} ", n);
        }

    }
}