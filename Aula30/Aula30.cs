using System;

//indexador.
class Carro{
    private int[] velMax = new int[5]{120, 130, 140, 150, 160};

    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value<0){
                velMax[i] = 0;
            }else if(value>300){
                velMax[i] = 300;
            }else{
                velMax[i] = value;
            }
        }
    }
}

class Aula30{
    static void Main(){
        Carro c1 = new Carro();

        c1[4] = 200;
        Console.WriteLine(c1[4]);
        Console.WriteLine(c1[3]);
    }
}