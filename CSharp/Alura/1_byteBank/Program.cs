using System;

namespace _1_byteBank
{
    class Program
    {
        static void Main(string[] args){
            ContaCorrente a = new ContaCorrente("Ana",324,21231);

            
            Console.WriteLine("depositar: "+a.Depositar(100));
            Console.WriteLine("sacar: "+a.Sacar(10));
            Console.WriteLine(a);

                
            
            Console.WriteLine("ok");
        }
    }
}
