using System;
using System.Text;

namespace HtmlEditor
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------------------------------");

            Start();
        }

        public static void Start()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key == ConsoleKey.Escape);

            Console.WriteLine("Deseja salvar este arquivo?");
            Console.WriteLine("---------------------------");

            Viewer.Show(text.ToString());
        }
    }
}