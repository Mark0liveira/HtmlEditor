using System;
using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public class Viewer
    {
        static public void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("----------------------------------------");
            ReplaceStrong(text);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }

        public static void ReplaceStrong(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        ) //ex: <strong>teste</strong> (14 - 1) - 8 = 5 (teste)
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}