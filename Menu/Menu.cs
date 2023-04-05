using System.Diagnostics;

namespace Menu
{
    public class Menu
    {
        public static void Esc()
        {
            bool ifStart = true;
            while (ifStart == true)
            {
                Console.Clear();
                Console.SetCursorPosition(80, 15);
                int line = 15;         //строка
                int column = 40;       //столбец

                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {

                        if (i == 0 | j == 0 | i == line - 1 | j == column - 1)
                        {
                            Console.Write('#');

                        }
                        else
                        {
                            Console.Write(' ');

                        }
                    }
                    Console.WriteLine();
                    Console.Write("                                                                                ");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(92, 18);
                Console.Write("<ЧЕЛ ХОДИТ ЧЁТ>");
                Console.SetCursorPosition(96, 21);
                Console.Write("ОБУЧЕНИЕ");
                Console.SetCursorPosition(95, 22);
                Console.Write("(press <h>)");
                Console.SetCursorPosition(98, 24);
                Console.Write("ВЫХОД");
                Console.SetCursorPosition(95, 25);
                Console.Write("(press <n>)");
                ConsoleKeyInfo Menu = Console.ReadKey();
                switch (Menu.Key)
                {
                    case ConsoleKey.H:
                        Training();
                        Console.ReadKey();
                        ifStart = false;
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("ДДо скорой встречи!!!");
                        Process.GetCurrentProcess().Kill();
                        break;
                    default:
                        Console.SetCursorPosition(90, 26);
                        Console.WriteLine("Не та клавиша, путник.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static public void Training()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            int y = 10;
            Console.SetCursorPosition(55, y);
            int line = 28;         //строка
            int column = 57;       //столбец
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
                y += 1;
                Console.SetCursorPosition(55, y);
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(77, 12);
            Console.Write("<|ROGA   GAME|>");
            Console.SetCursorPosition(79, 14);
            Console.Write("|ОБУЧЕНИЕ|");
            Console.SetCursorPosition(76, 16);
            Console.Write("МЕХАНИКА ДВИЖЕНИЯ");
            Console.SetCursorPosition(84, 17);
            Console.Write("W");
            Console.SetCursorPosition(84, 18);
            Console.Write("↑");
            Console.SetCursorPosition(81, 19);
            Console.Write("A←   →D");
            Console.SetCursorPosition(84, 20);
            Console.Write("↓");
            Console.SetCursorPosition(84, 21);
            Console.Write("S");
            Console.SetCursorPosition(76, 24);
            Console.Write("ОТКРЫТЬ ИНВЕНТАРЬ");
            Console.SetCursorPosition(83, 25);
            Console.Write("(I)");
            Console.SetCursorPosition(77, 27);
            Console.Write("ОТКРЫТЬ МАГАЗИН");
            Console.SetCursorPosition(83, 28);
            Console.Write("(E)");
            Console.SetCursorPosition(82, 30);
            Console.Write("<МЕНЮ>");
            Console.SetCursorPosition(81, 31);
            Console.Write("(escape)");
            Console.SetCursorPosition(78, 33);
            Console.WriteLine("ВЫХОД ИЗ ИГРЫ");
            Console.SetCursorPosition(81, 34);
            Console.Write("(escape)");
        }
    }
}