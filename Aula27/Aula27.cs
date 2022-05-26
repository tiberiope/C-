using System;

//override de método virtual.
class Base{
    public Base(){
        Console.WriteLine("Base");
    }

    virtual public void info(){
        Console.WriteLine("Info base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Derivada1");
    }

    override public void info(){
        Console.WriteLine("Info derivada1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Derivada2");
    }

    override public void info(){
        Console.WriteLine("Info derivada2");
    }
}

class Aula27{
    static void Main(){
        Base Ref1;
        Base b1 = new Base();
        b1.info();
        Console.WriteLine("---------");
        Derivada1 der1 = new Derivada1();
        der1.info();
        Console.WriteLine("---------");
        Derivada2 der2 = new Derivada2();
        der2.info();
        Console.WriteLine("---------");
        Ref1 = der1;
        Ref1.info();
    }
}

