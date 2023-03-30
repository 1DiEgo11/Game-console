﻿using character;
using Draw;
using enemy;
using quests;

namespace Movement
{
    public class MovePerson
    { 

        public static void ChillRoom(Person person, ConsoleKeyInfo keyInfo, int[,] door)
        {
            if (keyInfo.Key == ConsoleKey.E)
            {
                Console.Clear();
                Quests.QuestRoom();
            }
        }

        public static void Move(Person person, ConsoleKeyInfo keyInfo, int[,] doors)
        {
            //keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    if (person.coordinates[0] - 1 != 1)
                    {
                        person.coordinates[0]--;
                    }
                    break;
                case ConsoleKey.D:
                    if (person.coordinates[0] + 2 < 168 || person.coordinates[0] + 3 == doors[0, 0] && person.coordinates[1] == doors[0, 1])
                    {

                        person.coordinates[0]++;
                        if (person.coordinates[0] + 2 < 167)
                        {
                            person.coordinates[0]++;
                            if (person.coordinates[0] + 2 < 166)
                            {
                                person.coordinates[0]++;
                            }
                        }
                    }
                    break;
                case ConsoleKey.W:
                    if (person.coordinates[1] - 2 != 7)
                    {

                        person.coordinates[1]--;
                    }
                    break;
                case ConsoleKey.S:
                    if (person.coordinates[1] + 3 != 40)
                    {
                        person.coordinates[1]++;
                    }
                    break;
            }
        }

        public static void Move_console() { 
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
            int last_type_map = 0;
            int[,] doors = new int[2, 2];

            Console.SetCursorPosition(37, 13);
            Console.WriteLine("ДЛЯ АДЕКВАТНОЙ РАБОТЫ НАЖМИТЕ ALT + ENTER");
            Thread.Sleep(3000);
            Console.Clear();

            int[] coordinates = { 5, 22 };//Начальные координаты гг

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


            //Передвижение по консоли
            do
            {
                
                Console.Clear();
                
                Console.SetCursorPosition(0, 0);
                if (person.type_of_person == 1)
                    Console.WriteLine("Персонаж - ВОИН");
                else if (person.type_of_person == 2)
                    Console.WriteLine("Персонаж - ЛУЧНИК");
                else
                    Console.WriteLine("Персонаж - МАГ");

                Console.SetCursorPosition(0, 2);
                Console.WriteLine("HP - {0} (+{1})", person.heart, person.armor);
                Console.WriteLine("Деньги - {0}", person.money);
                Console.Write("{0} {1}", person.coordinates[0], person.coordinates[1] + 3);

                
                GenerationMap.GenerationMap.Map(person, doors);
                

                Move(person, keyInfo, doors);
                DrawPerson.Draw_Person(person.coordinates);
                keyInfo = Console.ReadKey();

                if (person.level % 3 == 0 && (person.coordinates[0] == 80 && person.coordinates[1] - 3 == 6) || person.type_map == 1)
                {
                    last_type_map = person.type_map;
                    person.type_map = 1;
                    ChillRoom(person, keyInfo, doors);
                }
                if(person.type_map == 1 && person.level != 0 && person.coordinates[0] == 80 && person.coordinates[1] + 3 == 40)
                {
                    person.type_map = last_type_map;
                }
                if (person.coordinates[0] + 2 == doors[0, 0] && person.coordinates[1] == doors[0, 1])
                {
                    person.coordinates[0] = 5;
                    person.coordinates[1] = 22;
                    person.level++;
                    person.type_map = GenerationMap.GenerationMap.Random_map(person.type_map);
                }
                
                if (person.level == 21)
                {
                    Console.WriteLine("Вы выйграли!!!!");
                    break;
                }

            }while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}