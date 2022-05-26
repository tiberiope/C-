using System;

struct Carro{
    public string marca;
    public string modelo;

    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}\n", this.marca, this.modelo, this.cor);
    }
}
class Aula32{
    static void Main(){
        Carro c1;
        Carro c2 = new Carro("Jeep", "Willys", "Vermelho");

        c1.marca = "VW";
        c1.modelo = "Gol";
        c1.cor = "Azul";

        c1.info();
        c2.info();

    

    }
}