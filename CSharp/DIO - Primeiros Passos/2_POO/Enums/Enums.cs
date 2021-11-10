using System;
namespace _2_POO.Enums
{
    enum Cor{
        Vermelho,
        Verde,
        Azul
    }
    //pode usar o tipo ao lado
    /* enum Alinhamento: sbyte{
        Esquerda = -1,
    }*/
    class teste{
        static void EscreverCor(Cor cor){
            switch (cor)
            {
                case Cor.Vermelho:
                    Console.WriteLine("vermelho");
                    break;
                default:
                    Console.WriteLine("other");
            }
        }

    }
}