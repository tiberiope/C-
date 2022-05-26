using System;


public class Jogador{
    //construtor
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    //sobrecarga de construtor.
    public Jogador(string nome){
        energia = 100;
        vivo = true;
        this.nome = nome;
    }

    public Jogador(string nome, int energia){
        this.energia = energia;
        vivo = true;
        this.nome = nome;
    }

    public Jogador(string nome, int energia, bool vivo){
        this.energia = energia;
        this.vivo = vivo;
        this.nome = nome;
    }

    public void info(){
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}", vivo);
        Console.WriteLine("----------");
    }
    
    //Sobrecarga de método.
    public void info(int n){
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia bônus: {0}", energia + n);
        Console.WriteLine("Estado jogador: {0}", vivo);
        Console.WriteLine("----------");
    }

    ~Jogador(){
        //destrutor
        Console.WriteLine("Jogador {0} foi destruído", nome);
    }

}

class Inimigo{

    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta = false;
        nome = n;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("---------");
    }
}
class Aula23{
    static void Main(){
        //Modificadores de classe:
        //static = não pode ser instânciada (não tem objetos) e seus membros devem ser static.
        //public = sem restrição de visualização.
        //sealed = não pode ser herdada.
        //abstract = classe-base para outras classes (não tem objetos).

        //Especificadores de acesso de métodos de classe:
        //public = sem restrição.
        //private = restrito à própria classe.
        //protected = pode ser acessado na própria classe e nas classes derivadas.
        //abstract = os métodos não tem implementação. Somente cabeçalho.
        //sealed = o método não pode ser redefinido.
        //virtual = o método pode ser redefinido em uma classe derivada.
        //static = o método pode ser chamado mesmo sem a instanciação de um objeto.
        Console.WriteLine("Digite o nome: ");

        string nome = Console.ReadLine();
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("João");
        Jogador j3 = new Jogador(nome, 100);
        Jogador j4 = new Jogador("Adriano", 0, false);

        j3.energia = 50;

        Console.WriteLine("Jogador {2} tem energia = {0} e vivo = {1}.\n", j3.energia, j3.vivo, j3.nome);

        j1.info();
        j2.info();
        j3.info(50);
        j4.info();
        Console.WriteLine("----------");

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");
        
        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
}