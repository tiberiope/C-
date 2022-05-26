using System;
//namespace: escopo para organização. É possível até ter classes com o mesmo nome e escopos diferentes.
namespace Calc1{
    class Area{
        public static float Quad(float baseQ, float alturaQ){
            if(baseQ==0 || alturaQ==0){
                throw new Exception("Base ou altura não podem ser igual a zero.");
            }
            return baseQ * alturaQ;
        }
    }
}

namespace Calc2{
    class Area{
        public static float Quad(float baseQ, float alturaQ){
            if(baseQ==0 || alturaQ==0){
                throw new Exception("Base ou altura não podem ser igual a zero.");
            }
            return baseQ * alturaQ;
        }
    }
}

class Aula40{
    static void Main(){
        float area=0;
        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0;

        try{
            res = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
        }finally{
            Console.WriteLine("Fim do processo.\n");
        }

        try{
            area = Calc1.Area.Quad(10f, 0f);
            Console.WriteLine("Área do quadrilátero é igual a: {0}", area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
        }finally{
            Console.WriteLine("Fim do processo.\n");
        }
    }
}