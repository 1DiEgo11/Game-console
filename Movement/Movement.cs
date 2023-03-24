using character;
using Draw;
using enemy;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace Movement
{
    public class MovePerson
    {

        //public static void IsCollision(Person person)
        //{
        //    if (person.coordinates[0] - 1 == '|' && person.coordinates[1] == '|'
        //            || person.coordinates[0] - 1 == '|' && person.coordinates[1] - 1 == '|'
        //            || person.coordinates[0] - 1 == '|' && person.coordinates[1] - 2 == '|'
        //            || person.coordinates[0] == '|' && person.coordinates[1] - 2 == '|'
        //            || person.coordinates[0] + 1 == '|' && person.coordinates[1] - 2 == '|'
        //            || person.coordinates[0] + 2 == '|' && person.coordinates[1] - 2 == '|'
        //            || person.coordinates[0] + 2 == '|' && person.coordinates[1] - 1 == '|'
        //            || person.coordinates[0] + 2 == '|' && person.coordinates[1] == '|'
        //            || person.coordinates[0] + 2 == '|' && person.coordinates[1] + 1 == '|'
        //            || person.coordinates[0] + 1 == '|' && person.coordinates[1] + 2 == '|'
        //            || person.coordinates[0] == '|' && person.coordinates[1] + 2 == '|'
        //            || person.coordinates[0] - 1 == '|' && person.coordinates[1] + 1 == '|')
        //    {
        //        Console.Clear();
        //        Console.WriteLine("EPIC WIN!");
        //    }
            
        //}
        public static void Move(Person person, ConsoleKeyInfo keyInfo, int[,] doors)
        {
            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    if (person.coordinates[0] - 1 != 1)
                    {
                        DrawPerson.ClearAnything(person.coordinates);
                        person.coordinates[0] --;
                    }
                    break;
                case ConsoleKey.D:
                    if (person.coordinates[0] + 2 != 168 || person.coordinates[0] + 3 != 168 || person.coordinates[0] + 4 != 168 || person.coordinates[0] + 3 == doors[1, 0] && person.coordinates[1] == doors[1, 1])
                    {
                        DrawPerson.ClearAnything(person.coordinates);
                        person.coordinates[0] += 4;
                    }
                    break;
                case ConsoleKey.W:
                    if (person.coordinates[1] - 2 != 7)
                    {
                        DrawPerson.ClearAnything(person.coordinates);
                        person.coordinates[1]--;
                    }
                    break;
                case ConsoleKey.S:
                    if (person.coordinates[1] + 2 != 39)
                    {
                        DrawPerson.ClearAnything(person.coordinates);
                        person.coordinates[1]++;
                    }
                    break;
            }
        }

        public static void Move_enemy(Enemy enemy) {
            Random random = new Random();
            int enemym = random.Next(0, 2);
            int orientation = random.Next(0, 11);
            int xy = random.Next(0, 11);
            if (orientation < 6 && xy < 6 && enemy.coordinates[0] > 10)
            {
                enemy.coordinates[0] -= enemym;
            }
            if (orientation > 5 && xy < 6 && enemy.coordinates[0] < 200)
            {
                enemy.coordinates[0] += enemym;
            }
            if (orientation < 6 && xy > 5 && enemy.coordinates[1] > 1)
            {
                enemy.coordinates[1] -= enemym;
            }
            if (orientation > 5 && xy > 5 && enemy.coordinates[1] < 49)
            {
                enemy.coordinates[1] += enemym;
            } //типо движение противника
        }

        public static void Game()
        {
            int[,] doors = new int[6, 2];

            Console.SetCursorPosition(37, 13);
            Console.WriteLine("ДЛЯ АДЕКВАТНОЙ РАБОТЫ НАЖМИТЕ ALT + ENTER");
            Thread.Sleep(3000);
            Console.Clear();

            int[] coordinates = { 15, 15 };//Начальные координаты гг

            Console.WriteLine("Для выхода нажмите - Escape");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Выберите героя:");
            Console.WriteLine("1. Воин (Нажмите Q для выбора)");
            Console.WriteLine("2. Лучник (Нажмите W для выбора)");
            Console.WriteLine("3. Маг (Нажмите E для выбора)");
            
            var person = new Person();//Создание переменной person, а потом ее переназначение

            //Для считывания клавиш
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Q:
                    person = new Warrior(coordinates);
                    break;
                case ConsoleKey.W:
                    person = new Archer(coordinates);
                    break;
                case ConsoleKey.E:
                    person = new Mage(coordinates);
                    break;
                case ConsoleKey.Escape:
                    return;
            }

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;

            char playerChar = 'X';//Моделька персонажа 
            char enemyChar = 'Z';//Enemy
            Zombi test = new Zombi(1);
            Elite_Zombi test2 = new Elite_Zombi(1);
            Skelet test3 = new Skelet(1);
            Elite_Skelet test4 = new Elite_Skelet(1);
            Wizzard test5 = new Wizzard(1);
            Elite_Wizzard test6 = new Elite_Wizzard(1); // Enemy for test
            //Chekanov_version2 boss = new Chekanov_version2(1);
            //boss.coordinates[0] = 20;
            //boss.coordinates[1] = 10;


            // Координаты флага(для тестов)
            int flagX = 25;
            int flagY = 5;
            
            Console.Clear();
            DrawMap.FirstMap(doors);
            Console.SetCursorPosition(0, 0);
            if (person.type_of_person == 1)
                Console.WriteLine("Персонаж - ВОИН");
            else if (person.type_of_person == 2)
                Console.WriteLine("Персонаж - ЛУЧНИК");
            else
                Console.WriteLine("Персонаж - МАГ");
            //Передвижение по консоли
            do
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("HP - {0} (+{1})", person.heart, person.armor);
                Console.WriteLine("Деньги - {0}", person.money);

                Console.SetCursorPosition(flagX, flagY);
                Console.Write("F");

                Console.SetCursorPosition(test.coordinates[0], test.coordinates[1]);
                Console.Write(enemyChar);
                Random  random = new Random();
                int orientation = random.Next(0, 11);
                int xy = random.Next(0, 11);
                if (orientation < 6 && xy < 6 && test.coordinates[0] > 1)
                {
                    test.coordinates[0]--;
                }
                if (orientation > 5 && xy < 6 && test.coordinates[0] < 209)
                {
                    test.coordinates[0]++;
                }
                if (orientation < 6 && xy > 5 && test.coordinates[1] > 1)
                {
                    test.coordinates[1]--;
                }
                if (orientation > 5 && xy > 5 && test.coordinates[0] < 49)
                {
                    test.coordinates[1]++;
                } //типо движение противника

                test.draw(test.coordinates[0], test.coordinates[1]);
                test2.draw(test2.coordinates[0], test2.coordinates[1]);
                test3.draw(test3.coordinates[0], test3.coordinates[1]);
                test4.draw(test4.coordinates[0], test4.coordinates[1]);
                test5.draw(test5.coordinates[0], test5.coordinates[1]);
                test6.draw(test6.coordinates[0], test6.coordinates[1]);
                Movement.MovePerson.Move_enemy(test);
                Movement.MovePerson.Move_enemy(test2);
                Movement.MovePerson.Move_enemy(test3);
                Movement.MovePerson.Move_enemy(test4);
                Movement.MovePerson.Move_enemy(test5);
                Movement.MovePerson.Move_enemy(test6);
                //boss.draw(boss.coordinates[0], boss.coordinates[1]);

                

                person.type_map = 1;

                DrawPerson.Draw_Person(person.coordinates);

                Move(person, keyInfo, doors);

                

                if (person.coordinates[0] - 1 == doors[1, 0] && person.coordinates[1] == doors[1, 1])
                {
                    person.level++;
                    Console.Clear();
                    Console.WriteLine("ВЫ МУЖИИИИИИИИК!!!!!!!!!!!");
                    break;
                }

            } while (keyInfo.Key != ConsoleKey.Backspace);
        }
    }
}