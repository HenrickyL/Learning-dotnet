using System;

namespace Pratica
{
    class Program
    {
        private static int capacidade = 5;
        private static int current = 0;
        private static string Menu(){
            Console.Clear();
            string menu = "Informe a Opção desejada:\n";
            menu += $"\t1- Inserir novo Aluno [{current}/{capacidade}]\n";
            menu += "\t2- Listar Alunos\n";
            menu += "\t3- Calcular Média geral\n";
            menu += "\tx- Sair\n";

            Console.WriteLine(menu);
            string op = Console.ReadLine();
            return op.ToUpper();
        }
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[capacidade];
            string op = Menu();
            while(op != "X"){
                switch (op)
                {
                    case "1":
                        if(current+1 <= capacidade){
                            Aluno a = new Aluno();
                            Console.Write("Nome: ");

                            a.Nome = Console.ReadLine();
                            Console.Write("Nota: ");
                            if(decimal.TryParse( Console.ReadLine(),out decimal nota)){
                                a.Nota = nota;
                            }else{
                                throw new ArgumentException("Nota inválida!");
                            }
                            alunos[current] = a;
                            current++;
                        }else{
                            Console.WriteLine("capacidade Máxima\nok?");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome))
                                Console.WriteLine($"[Aluno] {a.Nome} nota: {a.Nota}");
                        }
                        break;
                    case "3":
                        decimal media = 0;
                        Conceito conceitoGeral;
                        if(current==0) 
                            Console.WriteLine("Media: 0");
                        else

                        for(int i=0; i<current;i++){
                            media += alunos[i].Nota / current;
                        }
                        if(0 == media)
                            conceitoGeral = Conceito.F;
                        else if(media < 2)
                            conceitoGeral = Conceito.E;
                        else if(media < 4)
                            conceitoGeral = Conceito.D;
                        else if(media < 6)
                            conceitoGeral = Conceito.C;
                        else if(media < 8)
                            conceitoGeral = Conceito.B;
                        else
                            conceitoGeral = Conceito.A;
                        Console.WriteLine($"Media: {media}<{conceitoGeral}>");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("<Tecle enter para nova operação>");
                Console.ReadLine();
                op = Menu();
            }
        }
    }
}

