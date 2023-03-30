﻿using character;
using enemy;
using static System.Net.Mime.MediaTypeNames;

namespace Movement
{
    public class MovePerson
    {
        public static void Move(Person person, ConsoleKeyInfo keyInfo)
        {
            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    person.coordinates[0]--;
                    break;
                case ConsoleKey.D:
                    person.coordinates[0]++;
                    break;
                case ConsoleKey.W:
                    person.coordinates[1]--;
                    break;
                case ConsoleKey.S:
                    person.coordinates[1]++;
                    break;
            }
        }

        public static int Move_limit(Enemy enemy)
        {
            if (enemy.type_of_person > 6)
            {
                switch (enemy.type_of_person )
                {
                    case 8:
                        if (enemy.coordinates[0] > 14 && enemy.coordinates[1] > 0) return 1;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] > 0) return 2;
                        if (enemy.coordinates[0] > 14 && enemy.coordinates[1] < 25) return 3;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] < 25) return 4;
                        break;
                    case 7:
                        if (enemy.coordinates[0] > 8 && enemy.coordinates[1] > 0) return 1;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] > 0) return 2;
                        if (enemy.coordinates[0] > 8 && enemy.coordinates[1] < 27) return 3;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] < 27) return 4;
                        break;
                }
            }
            else
            {
                switch (enemy.type_of_person % 2)
                {
                    case 0:
                        if (enemy.coordinates[0] > 1 && enemy.coordinates[1] > 0) return 1;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] > 0) return 2;
                        if (enemy.coordinates[0] > 1 && enemy.coordinates[1] < 35) return 3;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] < 35) return 4;
                        break;
                    case 1:
                        if (enemy.coordinates[0] > 1 && enemy.coordinates[1] > 0) return 1;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] > 0) return 2;
                        if (enemy.coordinates[0] > 1 && enemy.coordinates[1] < 36) return 3;
                        if (enemy.coordinates[0] < 190 && enemy.coordinates[1] < 36) return 4;
                        break;
                }
            }
            return 0; //переделать на хитбоксы
        }
        public static void Move_enemy(Enemy enemy) {
            Random random = new Random();
            int enemym = random.Next(0, 2);
            int orientation = random.Next(0, 11);
            int xy = random.Next(0, 11);
            if (orientation < 6 && xy < 6 && enemy.coordinates[0] > 1)
            {
                enemy.coordinates[0] -= enemym;
                enemy.coordinates[2] -= enemym;
            }
            if (orientation > 5 && xy < 6 && enemy.coordinates[2] < 189)
            {
                enemy.coordinates[0] += enemym;
                enemy.coordinates[2] += enemym;
            }
            if (orientation < 6 && xy > 5 && enemy.coordinates[1] > 7)
            {
                enemy.coordinates[1] -= enemym;
                enemy.coordinates[3] -= enemym;
            }
            if (orientation > 5 && xy > 5 && enemy.coordinates[3] < 39)
            {
                enemy.coordinates[1] += enemym;
                enemy.coordinates[3] += enemym;
            } //типо движение противника
        }

        public static void Game()
        {
            int[] coordinates = { 15, 15 };//Начальные координаты гг


            Console.WriteLine("Выберите героя:");
            Console.WriteLine("1. Воин (Нажмите Q для выбора)");
            Console.WriteLine("2. Лучник (Нажмите W для выбора)");
            Console.WriteLine("3. Маг (Нажмите E для выбора)");

            var person = new Person();//Создание переменной person, а потом ее переназначение

            //Для считывания клавиш
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();

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
            }

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;

            char playerChar = 'X';//Моделька персонажа 

            //Zombi test = new Zombi(1);
            //Elite_Zombi test2 = new Elite_Zombi(1);
            //Skelet test3 = new Skelet(1);
            //Elite_Skelet test4 = new Elite_Skelet(1);
            //Wizzard test5 = new Wizzard(1);
            //Elite_Wizzard test6 = new Elite_Wizzard(1); // Enemy for test
            //Chekanov boss =  new Chekanov(1);
            //boss.coordinates[0] = 20;
            //boss.coordinates[1] = 10;
            Chekanov_version2 boss = new Chekanov_version2(1);
            //boss.coordinates[0] = 20;
            //boss.coordinates[1] = 10;


            // Координаты флага(для тестов)
            int flagX = 25;
            int flagY = 5;

            //Передвижение по консоли
            do
            {
                Console.Clear();

                if (person.type_of_person == 1)
                    Console.WriteLine("Ваш тип персонажа - ВОИН");
                else if (person.type_of_person == 2)
                    Console.WriteLine("Ваш тип персонажа - ЛУЧНИК");
                else
                    Console.WriteLine("Ваш тип персонажа - МАГ");
                Console.WriteLine($"{person.coordinates[0]}, {person.coordinates[1]}");
                Console.WriteLine($"{boss.coordinates[0]}, {boss.coordinates[1]}");
                Console.WriteLine($"{boss.coordinates[2]}, {boss.coordinates[3]}");


                Console.SetCursorPosition(flagX, flagY);
                Console.Write("F");


                //test.draw(test.coordinates[0], test.coordinates[1]);
                //test2.draw(test2.coordinates[0], test2.coordinates[1]);
                //test3.draw(test3.coordinates[0], test3.coordinates[1]);
                //test4.draw(test4.coordinates[0], test4.coordinates[1]);
                //test5.draw(test5.coordinates[0], test5.coordinates[1]);
                //test6.draw(test6.coordinates[0], test6.coordinates[1]);
                //Movement.MovePerson.Move_enemy(test);
                //Movement.MovePerson.Move_enemy(test2);
                //Movement.MovePerson.Move_enemy(test3);
                //Movement.MovePerson.Move_enemy(test4);
                //Movement.MovePerson.Move_enemy(test5);
                //Movement.MovePerson.Move_enemy(test6);
                boss.draw(boss.coordinates[0], boss.coordinates[1]);
                Movement.MovePerson.Move_enemy(boss);
                Console.SetCursorPosition(person.coordinates[0], person.coordinates[1]);
                Console.Write(playerChar);
                playerChar = playerChar == 'X' ? 'Y' : 'X';//Типа анимация движения

                Movement.MovePerson.Move(person, keyInfo);


                if (person.coordinates[0] == flagX && person.coordinates[1] == flagY)
                {
                    Console.Clear();
                    Console.WriteLine("EPIC WIN!");
                    break;
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}