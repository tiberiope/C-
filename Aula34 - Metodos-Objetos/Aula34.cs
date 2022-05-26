using System;

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    

    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo{
    static private int vTotal = 0;
    public Ovo(int numOvo, string nomeGalinha){

        if (numOvo == 1){
            Console.WriteLine("Ovo criado: {0} tem {1} ovo.", nomeGalinha, numOvo);
        }else{
            Console.WriteLine("Ovo criado: {0} tem {1} ovos.", nomeGalinha, numOvo);
        }
        totalOvos();
    }

    static public void totalOvos(){
        vTotal++;
        Console.WriteLine("Total de ovos: {0}", vTotal);
    }
}

class Aula34{
    static void Main(){
        Galinha g1 = new Galinha("Joana");
        Galinha g2 = new Galinha("Alana");
        Galinha g3 = new Galinha("Maria");

        g1.botar();
        g1.botar();
        g1.botar();
        g2.botar();
        g3.botar();
        g3.botar();
        g2.botar();
        g1.botar();
        g2.botar();
        g3.botar();
        g3.botar();
        g2.botar();
    }
}