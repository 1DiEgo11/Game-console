using System;
using System.Runtime.CompilerServices;

namespace Draw
{
    public class DrawMap
    {
        public int TypeMap;
        public int[,] coord; //координаты объектов врагов и тп
         //координаты дверей (2)

        
        public static void FirstMap(int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец

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
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 21);
            Console.Write('X');
            Console.SetCursorPosition(0, 22);
            Console.Write('X');
            Console.SetCursorPosition(0, 23);
            Console.Write('X');

            Console.SetCursorPosition(169, 21);
            Console.Write('|');
            Console.SetCursorPosition(169, 22);
            Console.Write('|');
            Console.SetCursorPosition(169, 23);
            Console.Write('|');

            //door[0, 0] = 169; door[0, 1] = 21;
            door[1, 0] = 169; door[1, 1] = 22;
            //door[2, 0] = 169; door[2, 1] = 23;

        }

        public void SecondMap(int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1 | (i == 4 & j < 20) | (i < 15 & j == 70) | (i == 23 & j > 120) | (i > 25 & j == 105))
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');

                    }
                }
                Console.WriteLine();

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 21);
            Console.Write('|');
            Console.SetCursorPosition(0, 22);
            Console.Write('|');
            Console.SetCursorPosition(0, 23);
            Console.Write('|');

            Console.SetCursorPosition(169, 21);
            Console.Write('|');
            Console.SetCursorPosition(169, 22);
            Console.Write('|');
            Console.SetCursorPosition(169, 23);
            Console.Write('|');

            door[0, 0] = 0; door[0, 1] = 21;
            door[1, 0] = 0; door[1, 1] = 22;
            door[2, 0] = 0; door[2, 1] = 23;

            door[3, 0] = 169; door[3, 1] = 21;
            door[4, 0] = 169; door[4, 1] = 22;
            door[5, 0] = 169; door[5, 1] = 23;
        }
        public static void ThirdMap(int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1 | (j == 35 & i > 15) | (j == 60 & i < 15) | (j == 85 & i > 15) | (j == 110 & i < 15) | (j == 135 & i > 15) | (j == 160 & i < 15))
                    {
                        Console.Write('#');
                    }

                    else
                    {
                        Console.Write(' ');

                    }
                }
                Console.WriteLine();
            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 21);
            Console.Write('|');
            Console.SetCursorPosition(0, 22);
            Console.Write('|');
            Console.SetCursorPosition(0, 23);
            Console.Write('|');

            Console.SetCursorPosition(169, 21);
            Console.Write('|');
            Console.SetCursorPosition(169, 22);
            Console.Write('|');
            Console.SetCursorPosition(169, 23);
            Console.Write('|');

            door[0, 0] = 0; door[0, 1] = 21;
            door[1, 0] = 0; door[1, 1] = 22;
            door[2, 0] = 0; door[2, 1] = 23;

            door[3, 0] = 169; door[3, 1] = 21;
            door[4, 0] = 169; door[4, 1] = 22;
            door[5, 0] = 169; door[5, 1] = 23;
        }
        public static void FouthMap(int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1 | (i == 6 & j < 30) | (j == 50 & i > 20) | (j == 105 & i < 8) | (i == 20 & j > 150))
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 21);
            Console.Write('|');
            Console.SetCursorPosition(0, 22);
            Console.Write('|');
            Console.SetCursorPosition(0, 23);
            Console.Write('|');

            Console.SetCursorPosition(169, 21);
            Console.Write('|');
            Console.SetCursorPosition(169, 22);
            Console.Write('|');
            Console.SetCursorPosition(169, 23);
            Console.Write('|');

            door[0, 0] = 0; door[0, 1] = 21;
            door[1, 0] = 0; door[1, 1] = 22;
            door[2, 0] = 0; door[2, 1] = 23;

            door[3, 0] = 169; door[3, 1] = 21;
            door[4, 0] = 169; door[4, 1] = 22;
            door[5, 0] = 169; door[5, 1] = 23;
        }
        public static void FifthMap(int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1 | (j == 103 & i < 13) | (j == 103 & i > 18))
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }



            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 21);
            Console.Write('|');
            Console.SetCursorPosition(0, 22);
            Console.Write('|');
            Console.SetCursorPosition(0, 23);
            Console.Write('|');

            Console.SetCursorPosition(169, 21);
            Console.Write('|');
            Console.SetCursorPosition(169, 22);
            Console.Write('|');
            Console.SetCursorPosition(169, 23);
            Console.Write('|');

            door[0, 0] = 0; door[0, 1] = 21;
            door[1, 0] = 0; door[1, 1] = 22;
            door[2, 0] = 0; door[2, 1] = 23;

            door[3, 0] = 169; door[3, 1] = 21;
            door[4, 0] = 169; door[4, 1] = 22;
            door[5, 0] = 169; door[5, 1] = 23;
        }

        public static void SixMap(int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 6);

            int line = 35;         //строка
            int column = 170;       //столбец
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1 | (i == 30 & j < 20) | (i == 25 & j > 30 & j < 60) | (i == 20 & j > 70 & j < 100) | (i == 15 & j > 110 & j < 140) | (i == 10 & j > 150 & j < 180) | (i == 5 & j > 190))
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 21);
            Console.Write('|');
            Console.SetCursorPosition(0, 22);
            Console.Write('|');
            Console.SetCursorPosition(0, 23);
            Console.Write('|');

            Console.SetCursorPosition(169, 21);
            Console.Write('|');
            Console.SetCursorPosition(169, 22);
            Console.Write('|');
            Console.SetCursorPosition(169, 23);
            Console.Write('|');

            door[0, 0] = 0; door[0, 1] = 21;
            door[1, 0] = 0; door[1, 1] = 22;
            door[2, 0] = 0; door[2, 1] = 23;

            door[3, 0] = 169; door[3, 1] = 21;
            door[4, 0] = 169; door[4, 1] = 22;
            door[5, 0] = 169; door[5, 1] = 23;
        }
    }

    public class DrawPerson
    {
        public static void Draw_Person(int[] coordinates)
        { 
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition((int)coordinates[0]-1, (int)coordinates[1] - 2);
            Console.Write('_');
            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1] - 2);
            Console.Write('/');
            Console.SetCursorPosition((int)coordinates[0] + 1, (int)coordinates[1] - 2);
            Console.Write('\\');
            Console.SetCursorPosition((int)coordinates[0] + 2, (int)coordinates[1] - 2);
            Console.Write('_');

            Console.SetCursorPosition((int)coordinates[0] - 1, (int)coordinates[1] - 1);
            Console.Write('(');
            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1] - 1);
            Console.Write('@');
            Console.SetCursorPosition((int)coordinates[0] + 1, (int)coordinates[1] - 1);
            Console.Write('@');
            Console.SetCursorPosition((int)coordinates[0] + 2, (int)coordinates[1] - 1);
            Console.Write(')');

            Console.SetCursorPosition((int)coordinates[0] - 1, (int)coordinates[1]);
            Console.Write('|');
            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1]);
            Console.Write('/');
            Console.SetCursorPosition((int)coordinates[0] + 1, (int)coordinates[1]);
            Console.Write('\\');
            Console.SetCursorPosition((int)coordinates[0] + 2, (int)coordinates[1]);
            Console.Write('|');

            Console.SetCursorPosition((int)coordinates[0] - 1, (int)coordinates[1] + 1);
            Console.Write('|');
            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1] + 1);
            Console.Write('_');
            Console.SetCursorPosition((int)coordinates[0] + 1, (int)coordinates[1] + 1);
            Console.Write('_');
            Console.SetCursorPosition((int)coordinates[0] + 2, (int)coordinates[1] + 1);
            Console.Write('|');

            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1] + 2);
            Console.Write('~');
            Console.SetCursorPosition((int)coordinates[0] + 1, (int)coordinates[1] + 2);
            Console.Write('~');
        }

        public static void ClearAnything(int[] coordinates)
        {
            Console.SetCursorPosition(coordinates[0] - 1, coordinates[1] - 2);
            Console.Write("    ");
            Console.SetCursorPosition(coordinates[0] - 1, coordinates[1] - 1);
            Console.Write("    ");
            Console.SetCursorPosition(coordinates[0] - 1, coordinates[1]);
            Console.Write("    ");
            Console.SetCursorPosition(coordinates[0] - 1, coordinates[1] + 1);
            Console.Write("    ");
            Console.SetCursorPosition(coordinates[0], coordinates[1] + 2);
            Console.Write("   ");

        }
    }

    
}
