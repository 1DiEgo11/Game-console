using character;

namespace Draw
{
    public class DrawMap
    {
        public static void FirstMap(Person person, int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int y = 0; y < line; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    if (y == 0 || x == 0 || y == line - 1 || x == column - 1)
                    {
                        Console.Write('#');//записывание в стринг попробовать 
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

            if (person.level == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(169, 21);
                Console.Write('|');
                Console.SetCursorPosition(169, 22);
                Console.Write('|');
                Console.SetCursorPosition(169, 23);
                Console.Write('|');
            }
            else
            {
                Console.SetCursorPosition(78, 40);
                Console.Write("------");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(100, 22);
            Console.Write("_/\\_");
            Console.SetCursorPosition(100, 23);
            Console.Write("(@@)");
            Console.SetCursorPosition(100, 24);
            Console.Write("|/\\|");
            Console.SetCursorPosition(100, 25);
            Console.Write("|__|");
            Console.SetCursorPosition(100, 26);
            Console.Write(" ~~ ");

            door[0, 0] = 169; door[0, 1] = 22;
        }

        public static void SecondMap(Person person, int[,] door)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 6);

            int line = 35;         //строка
            int column = 170;       //столбец

            for (int y = 0; y < line; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    if (person.coordinates[0] - 10 < x && x < person.coordinates[0] + 11 && person.coordinates[1] - 14 < y && y < person.coordinates[1])
                    {
                        if (y == 0 | x == 0 | y == line - 1 | x == column - 1 | (y == 4 & x < 20) | (y < 15 & x == 70) | (y == 23 & x > 170) | (y > 25 & x == 105) | (x == 190 & y < 10))
                        {
                            Console.Write('#');
                        }
                        else
                        { 
                            Console.Write('.');
                        }
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

            if(person.level % 3 == 0)
            {
                Console.SetCursorPosition(78, 6);
                Console.Write("------");
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

            door[0, 0] = 169; door[0, 1] = 22;
        }
        public static void ThirdMap(Person person, int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int y = 0; y < line; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    if (person.coordinates[0] - 10 < x && x < person.coordinates[0] + 11 && person.coordinates[1] - 14 < y && y < person.coordinates[1])
                    {
                        if (y == 0 | x == 0 | y == line - 1 | x == column - 1 | (x == 35 & y > 15) | (x == 60 & y < 15) | (x == 85 & y > 15) | (x == 110 & y < 15) | (x == 135 & y > 15) | (x == 160 & y < 15))
                        {
                            Console.Write('#');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

            if (person.level % 3 == 0)
            {
                Console.SetCursorPosition(78, 6);
                Console.Write("------");
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

            door[0, 0] = 169; door[0, 1] = 22;
        }
        public static void FouthMap(Person person, int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int y = 0; y < line; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    if (person.coordinates[0] - 10 < x && x < person.coordinates[0] + 11 && person.coordinates[1] - 14 < y && y < person.coordinates[1])
                    {
                        if (y == 0 | x == 0 | y == line - 1 | x == column - 1 | (y == 6 & x < 30) | (x == 50 & y > 20) | (x == 105 & y < 8) | (y == 20 & x > 150))
                        {
                            Console.Write('#');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

            if (person.level % 3 == 0)
            {
                Console.SetCursorPosition(78, 6);
                Console.Write("------");
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

            door[0, 0] = 169; door[0, 1] = 22;
        }
        public static void FifthMap(Person person, int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 6);


            int line = 35;         //строка
            int column = 170;       //столбец
            for (int y = 0; y < line; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    if (person.coordinates[0] - 10 < x && x < person.coordinates[0] + 11 && person.coordinates[1] - 14 < y && y < person.coordinates[1])
                    {
                        if (y == 0 | x == 0 | y == line - 1 | x == column - 1 | (x == 103 & y < 13) | (x == 103 & y > 18))
                        {
                            Console.Write('#');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

            if (person.level % 3 == 0)
            {
                Console.SetCursorPosition(78, 6);
                Console.Write("------");
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

            door[0, 0] = 169; door[0, 1] = 22;
        }

        public static void SixMap(Person person, int[,] door)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 6);

            int line = 35;         //строка
            int column = 170;       //столбец
            for (int y = 0; y < line; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    if (person.coordinates[0] - 10 < x && x < person.coordinates[0] + 11 && person.coordinates[1] - 14 < y && y < person.coordinates[1])
                    {
                        if (y == 0 | x == 0 | y == line - 1 | x == column - 1 | (y == 30 & x < 20) | (y == 25 & x > 30 & x < 60) | (y == 20 & x > 70 & x < 100) | (y == 15 & x > 110 & x < 140) | (y == 10 & x > 150 & x < 180) | (y == 5 & x > 190))
                        {
                            Console.Write('#');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

            if (person.level % 3 == 0)
            {
                Console.SetCursorPosition(78, 6);
                Console.Write("------");
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

            door[0, 0] = 169; door[0, 1] = 22;
        }
    }

    public class DrawPerson
    {
        public static void Draw_Person(int[] coordinates)
        { 
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition((int)coordinates[0]-1, (int)coordinates[1] - 2);
            Console.Write(" MM ");
            
            Console.SetCursorPosition((int)coordinates[0] - 1, (int)coordinates[1] - 1);
            Console.Write("(00)");
            
            Console.SetCursorPosition((int)coordinates[0] - 1, (int)coordinates[1]);
            Console.Write("/||\\");
            
            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1] + 1);
            Console.Write("||");
            
            Console.SetCursorPosition((int)coordinates[0], (int)coordinates[1] + 2);
            Console.Write("~~");
            
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
            Console.Write("    ");

        }
    }

    
}
