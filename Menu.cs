using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            DrawScreen();
        }

        public static void DrawScreen()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawHeaderAndFooter(30);
            DrawContent(10, 30);
            DrawHeaderAndFooter(30);

            DrawOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawContent(int quantityLine, int quantityColumn)
        {
            for (int line = 0; line < quantityLine; line++)
            {
                Console.Write("|");
                for (int column = 0; column < quantityColumn; column++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void DrawHeaderAndFooter(int quantityColumn)
        {
            Console.Write("+");

            for (int column = 0; column < quantityColumn; column++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawOptions()
        {
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Selecione uma das opções:");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("1 - Criar arquivo");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 9);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Abrir"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}