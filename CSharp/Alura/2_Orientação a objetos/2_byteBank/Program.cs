using System;


namespace _1_byteBank
{
    class Program
    {
        static void Main(string[] args){

            Cliente c = new Cliente("ana","8327198371","Bibliotecaria");
            ContaCorrente a = new ContaCorrente(c,324,21231);

            
            Console.WriteLine("depositar: "+a.Depositar(100));
            Console.WriteLine("sacar: "+a.Sacar(10));
            a.Saldo = -10;
            Console.WriteLine(">"+a.Titular);

                
            
            Console.WriteLine("ok");
        }
    }
}
