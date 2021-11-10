using System;
namespace EditorHtml
{
    public static class Menu
    {
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            var op = short.Parse(Console.ReadLine());
            HandleMenuOption(op);
        }

        private static void DrawScreen(){
            Console.Write('+');
            for(int i=0; i<30; i++)
                Console.Write('-');

            Console.Write("+\n");
            for(int lines=0; lines<15; lines++){
                Console.Write("|");
                for(int i=0; i<30; i++)
                    Console.Write(' ');
                Console.Write("|\n");  

            }
            Console.Write('+');
            for(int i=0; i<30; i++)
                Console.Write('-');
            Console.Write("+\n");
            
        }
        private static void WriteOptions(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma Opção a baixo:");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1. Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2. Abrir Arquivo");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0. Sair");
            Console.SetCursorPosition(3,10);
            Console.WriteLine("opção: ");
            Console.SetCursorPosition(5,11);









        }
        private static void HandleMenuOption(short op){
            switch(op){
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }

                case 1: Editor.Show();break;
                case 2: Viewer.Show("");break;
                default:
                    Show();break;



            }
        }
    
    
    }
        
}