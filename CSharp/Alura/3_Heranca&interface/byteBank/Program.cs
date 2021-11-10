using System;
using byteBank.Funcionarios;

namespace byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor d = new Diretor("323.421.566-65",5000);



            Console.WriteLine(d);


            Console.WriteLine("D "+d.GetBonificacao());
            Console.WriteLine("T:"+Funcionario.TotalFuncionarios);
            

            
        }
    }
}
