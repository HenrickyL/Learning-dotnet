using System;
using System.Text.RegularExpressions;
namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(String text){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO VISALIZADOR");
            Console.WriteLine("-----------------");
            Replace(text);
            Console.WriteLine("\n-----------------");
            Console.ReadKey();
            Menu.Show();

            
        }
        public static void Replace(string text){
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            foreach (var w in words)
            {
                if(strong.IsMatch(w)){
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(
                        w.Substring(
                            w.IndexOf('>')+1,
                            (w.LastIndexOf('<')-1) -
                            w.IndexOf('>')
                        )
                    );
                    Console.Write(' ');
                }else{
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(w);
                    Console.Write(' ');
                }
            }
        }
    }
}


/*
Este texto contem <strong>negrito</strong>!!!


*/