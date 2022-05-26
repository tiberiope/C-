using System;

class Aula10{

    // Enumeradores.
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){
        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana ds2 = (DiasSemana)3;
        int ds3 = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
        Console.WriteLine(ds2);
        Console.WriteLine(ds3);
    }
}