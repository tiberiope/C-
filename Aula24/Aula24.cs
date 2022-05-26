using System;

class Jogador{
    private int energia;
    private string nome;

    public Jogador(string nome){
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia(){
        return energia;
    }

    public string getNome(){
        return nome;
    }

    public void setEnergia(int novaEnergia){
        if (energia + novaEnergia > 100){
            energia = 100;
        }else if (energia + novaEnergia < 0){
            energia = 0;
        }else{
            energia += novaEnergia;
        }
    }
}

class Aula24{
    static void Main(){

        Jogador j1 = new Jogador("Pelé");

        j1.setEnergia(-30);
        j1.setEnergia(-30);
        j1.setEnergia(-30);
        j1.setEnergia(-30);
        
        Console.WriteLine("Nome: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
}