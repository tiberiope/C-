using System;

//métodos-propriedades get-set.
class Carro{
    private int velMax;
    
    public Carro(){
        vm = 120;
    }

    public int vm{
        get{
            return velMax;
        }
        set{
            if (value < 0){
                velMax = 0;
            }else if(value > 300){
                velMax = 300;
            }else{
                velMax = value;
            }
        }
    }
}
class Aula29{
    static void Main(){
        Carro c1 = new Carro();
        
        c1.vm = 200;
        Console.WriteLine(c1.vm);
    }
}