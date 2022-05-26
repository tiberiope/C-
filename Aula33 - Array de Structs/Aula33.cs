using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public void info(){
         Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}\n----------------", this.marca, this.modelo, this.cor);
    }
}
class Aula33{
    static void Main(){
        Carro[] carros = new Carro[5];

        carros[0].marca = "a";
        carros[0].modelo = "b";
        carros[0].cor = "c";

        carros[1].marca = "d";
        carros[1].modelo = "e";
        carros[1].cor = "f";

        for (int x = 0; x < carros.Length; x++){
            carros[x].info();
        }
    }
}