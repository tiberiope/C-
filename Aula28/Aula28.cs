using System;

abstract class Veiculo{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado){
        this.ligado = ligado;
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMax = 120;
    }

    override public void aceleracao(int mult){
        velAtual += 10*mult;
    }
}

class Aula28{
    static void Main(){
        Carro c1 = new Carro();
        c1.setLigado(false);
        Console.WriteLine("Situação: {0}", c1.getLigado());
        Console.WriteLine("Velocidade atual: {0}", c1.getVelAtual());
        c1.aceleracao(10);
        Console.WriteLine("Velocidade atual: {0}", c1.getVelAtual());
    }
}