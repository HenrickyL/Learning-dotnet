using System;

namespace _1_DIO
{
    class Program
    {

        static void Declaracoes(){
            int a;
            int b=2, c=3;
            const int d =4;//não pode alterar
            a=1;
            Console.WriteLine(a+b+c+d);
        }

        static void IntrucoesIf(string[] args){
            if(args.Length ==0){
                Console.WriteLine("zero argumento");

            }else if(args.Length ==1){
                Console.WriteLine("Um argumento");

            }else{
                Console.WriteLine($"{args.Length} argumentos");

            }
         }

        static void IntrucoesSwitch(string[] args){
            int n = args.Length;
            switch(n){
                case 0:
                    Console.WriteLine("zero argumento");
                    break;
                case 2:
                    Console.WriteLine("um argumento");
                    break;
                default:
                    Console.WriteLine($"{n} argumento");
                    break;

            }
        }
        static void Intrucoeswhile(string[] args){
            int i=0;
            while(i < args.Length){
                    Console.WriteLine(args[i]);
                    i++;

            }
        }


        static void IntructionTryCatch(string[] args){
            double Dividir(double a,double b){
                if(b==0){
                    throw new DivideByZeroException();
                }
                return a/b;
            }

            try{
                if(args.Length != 2)
                    throw new InvalidOperationException("informe 2 numeros");

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);

                double res= Dividir(x,y);
                Console.WriteLine(res);
                
            }catch(InvalidOperationException e){
                Console.WriteLine("op invalid - "+e.Message);
            }catch(Exception e){
                Console.WriteLine("exception - "+e.Message);

            }finally{
                Console.WriteLine("Até Logo!");
            }
        }

        static void IntructionUsing(){
            //obj não estruturados como IO deixam resquicios usando using previnimos
            // esse tipo de obj precisaria de algo como 
                // w.Dispose();
            using (System.IO.TextWriter w = System.IO.File.CreateText("test.txt")){
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // int numSteps = 5;
            // for(int i=0; i< numSteps; i++){
            //     Console.WriteLine($"step: {i}");
            // }
            //variaveis
             //->Tipo de valor | variavel (int,char,...)
             //->    | Referencia  (class, objct,string,array)
            //Intruções
             //abrange vários coandos (declarações, if,for, do ,foreach,...)
            // Declaracoes();
            // Console.WriteLine("S:");
            // IntrucoesIf(Console.ReadLine().Split(' '));
            // Console.WriteLine("S:");
            // IntrucoesSwitch(Console.ReadLine().Split(' '));
            // Console.WriteLine("S:");
            // Intrucoeswhile(Console.ReadLine().Split(' '));
            // IntructionTryCatch(Console.ReadLine().Split(' '));
            // IntructionUsing();

        }
    }
}
