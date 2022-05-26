using System;

//interface.
public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo, Combate{

    private bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }

    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false;
    }

    public void info(){
        Console.WriteLine("Infos do carro.");
    }
    public void disparar(){
        
    }

    public void setMunicao(int qtd){
        municao += qtd;
    }

    public bool estado{
        get{
            return ligado;
        }
    }

    ~Carro(){

    }
}
class Aula31{
    static void Main(){
        Carro c1 = new Carro();

        c1.ligar();
        Console.WriteLine(c1.estado);
        c1.desligar();
        Console.WriteLine(c1.estado);
    }
}