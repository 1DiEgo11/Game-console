using character;
using Draw;
using enemy;
using Menu;
using quests;
using Battle;
using Animation_Enemys;
using System.Collections.Generic;
using System;

namespace Movement
{
    public class MovePerson
    {
        public static void ChillRoom(Person person, ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.E)
            {
                Console.Clear();
                Quests.QuestRoom(person);
            }
        }

        public static void Move(Person person, ConsoleKeyInfo keyInfo, char[,] map)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[person.coordinates[1] - 2, person.coordinates[0] - 1] != '#' && map[person.coordinates[1] - 2, person.coordinates[0] - 1] != 'X' &&
                            map[person.coordinates[1] - 1, person.coordinates[0] - 2] != '#' && map[person.coordinates[1] - 1, person.coordinates[0] - 2] != 'X' &&
                            map[person.coordinates[1], person.coordinates[0] - 2] != '#' && map[person.coordinates[1], person.coordinates[0] - 2] != 'X' &&
                            map[person.coordinates[1] + 1, person.coordinates[0] - 1] != '#' && map[person.coordinates[1] + 1, person.coordinates[0] - 1] != 'X' &&
                            map[person.coordinates[1] + 2, person.coordinates[0] - 1] != '#' && map[person.coordinates[1] + 2, person.coordinates[0] - 1] != 'X')
                        {
                            person.coordinates[0]--;
                        }
                    }
                    break;
                case ConsoleKey.D:
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[person.coordinates[1] - 2, person.coordinates[0] + 2] != '#' && map[person.coordinates[1] - 1, person.coordinates[0] + 3] != '#' &&
                            map[person.coordinates[1], person.coordinates[0] + 3] != '#' && map[person.coordinates[1] + 1, person.coordinates[0] + 2] != '#' && map[person.coordinates[1] + 2, person.coordinates[0] + 2] != '#')
                        {
                            if (map[person.coordinates[1], person.coordinates[0] + 3] == '|')
                            {
                                person.coordinates[0]++;
                                break;
                            }
                            else
                                person.coordinates[0]++;
                        }
                    }
                    break;
                case ConsoleKey.W:
                    for (int i = 0; i < 2; i++)
                    {
                        if (map[person.coordinates[1] - 3, person.coordinates[0]] != '#' && map[person.coordinates[1] - 3, person.coordinates[0] + 1] != '#' &&
                            map[person.coordinates[1] - 2, person.coordinates[0] - 1] != '#' && map[person.coordinates[1] - 2, person.coordinates[0] + 2] != '#')
                        {
                            if (map[person.coordinates[1] - 3, person.coordinates[0]] == '-')
                            {

                                break;
                            }
                            else
                                person.coordinates[1]--;
                        }
                    }
                    break;
                case ConsoleKey.S:
                    for (int i = 0; i < 2; i++)
                    {
                        if (map[person.coordinates[1] + 3, person.coordinates[0]] != '#' && map[person.coordinates[1] + 3, person.coordinates[0] + 1] != '#' &&
                            map[person.coordinates[1] + 1, person.coordinates[0] - 1] != '#' && map[person.coordinates[1] + 1, person.coordinates[0] + 2] != '#')
                        {
                            if (map[person.coordinates[1] + 3, person.coordinates[0]] == '-')
                            {
                                person.coordinates[1]++;
                                break;
                            }
                            else
                                person.coordinates[1]++;
                        }
                    }
                    break;
                case ConsoleKey.I:
                    Console.Clear();
                    Inventoty.Inventory.Open_Inventory(person);
                    break;
            }
        }

        public static bool FreePlace(List<Enemy> enemies, Enemy enemy, int orient)
        {
            foreach (var item in enemies)
            {
                if (item != enemy)
                {
                    if (orient == 1 && (item.coordinates[2] == enemy.coordinates[0] - 1 || item.coordinates[2] == enemy.coordinates[0] - 2 || item.coordinates[2] == enemy.coordinates[0]))
                    {
                        if (item.coordinates[1] <= enemy.coordinates[1] && item.coordinates[3] >= enemy.coordinates[1]
                            || item.coordinates[1] <= enemy.coordinates[3] && item.coordinates[3] >= enemy.coordinates[3]) return false;
                    }
                    else if (orient == 2 && (item.coordinates[0] == enemy.coordinates[2] + 1 || item.coordinates[0] == enemy.coordinates[2] + 2 || item.coordinates[0] == enemy.coordinates[2]))
                    {
                        if (item.coordinates[1] <= enemy.coordinates[1] && item.coordinates[3] >= enemy.coordinates[1]
                            || item.coordinates[1] <= enemy.coordinates[3] && item.coordinates[3] >= enemy.coordinates[3]) return false;
                    }
                    else if (orient == 3 && (item.coordinates[1] == enemy.coordinates[3] + 1 || item.coordinates[1] == enemy.coordinates[3] + 2 || item.coordinates[1] == enemy.coordinates[3]))
                    {
                        if (item.coordinates[0] <= enemy.coordinates[0] && item.coordinates[2] >= enemy.coordinates[0]
                            || item.coordinates[0] <= enemy.coordinates[2] && item.coordinates[2] >= enemy.coordinates[2]) return false;
                    }
                    else if (orient == 4 && (item.coordinates[3] == enemy.coordinates[1] - 1 || item.coordinates[3] == enemy.coordinates[1] - 2 || item.coordinates[3] == enemy.coordinates[1]))
                    {
                        if (item.coordinates[0] <= enemy.coordinates[0] && item.coordinates[2] >= enemy.coordinates[0]
                            || item.coordinates[0] <= enemy.coordinates[2] && item.coordinates[2] >= enemy.coordinates[2]) return false;
                    }
                }
                else { continue; }
            }
            return true;
        }
        //
        public static bool Free_Place(Enemy enemies, Enemy enemy, int orient)
        {
            if (orient == 1 && enemies.coordinates[2] == enemy.coordinates[0] - 1)
            {
                if (enemies.coordinates[1] <= enemy.coordinates[1] && enemies.coordinates[3] >= enemy.coordinates[1]
                    || enemies.coordinates[1] <= enemy.coordinates[3] && enemies.coordinates[3] >= enemy.coordinates[3]) return false;
            }
            else if (orient == 2 && enemies.coordinates[0] == enemy.coordinates[2] + 1)
            {
                if (enemies.coordinates[1] <= enemy.coordinates[1] && enemies.coordinates[3] >= enemy.coordinates[1]
                    || enemies.coordinates[1] <= enemy.coordinates[3] && enemies.coordinates[3] >= enemy.coordinates[3]) return false;
            }
            else if (orient == 3 && enemies.coordinates[1] == enemy.coordinates[3] + 1)
            {
                if (enemies.coordinates[0] <= enemy.coordinates[0] && enemies.coordinates[2] >= enemy.coordinates[0]
                    || enemies.coordinates[0] <= enemy.coordinates[2] && enemies.coordinates[2] >= enemy.coordinates[2]) return false;
            }
            else if (orient == 4 && enemies.coordinates[3] == enemy.coordinates[1] - 1)
            {
                if (enemies.coordinates[0] <= enemy.coordinates[0] && enemies.coordinates[2] >= enemy.coordinates[0]
                    || enemies.coordinates[0] <= enemy.coordinates[2] && enemies.coordinates[2] >= enemy.coordinates[2]) return false;
            }
            return true;
        }
        //
        public static bool Move_limit(Enemy enemy, char[,] map, int orient)
        {
            switch (orient)
            {
                case 1:
                    if (map[enemy.coordinates[1], enemy.coordinates[0] - 1] == '#' || map[enemy.coordinates[3], enemy.coordinates[0] - 1] == '#') return false;
                    break;
                case 2:
                    if (map[enemy.coordinates[1], enemy.coordinates[2] + 1] == '#' || map[enemy.coordinates[3], enemy.coordinates[2] + 1] == '#') return false;
                    break;
                case 3:
                    if (map[enemy.coordinates[3] - 1, enemy.coordinates[0]] == '#' || map[enemy.coordinates[3] - 1, enemy.coordinates[2]] == '#') return false;
                    break;
                case 4:
                    if (map[enemy.coordinates[1] + 1, enemy.coordinates[0]] == '#' || map[enemy.coordinates[1] + 1, enemy.coordinates[2]] == '#') return false;
                    break;
            }
            return true;
        }
        public static void Move_enemy(List<Enemy> enemies, Enemy enemy, char[,] map)
        {
            Random random = new Random();
            int enemym = random.Next(0, 2);
            int orientation = random.Next(0, 11);
            int xy = random.Next(0, 11);
            if (orientation < 6 && xy < 6 && enemy.coordinates[0] > 1 && FreePlace(enemies, enemy, 1))
            {
                if (Move_limit(enemy, map, 1))
                {
                    enemy.coordinates[0] -= enemym;
                    enemy.coordinates[2] -= enemym;
                }
            }
            if (orientation > 5 && xy < 6 && enemy.coordinates[2] < 160 && FreePlace(enemies, enemy, 2))
            {
                if (Move_limit(enemy, map, 2))
                {
                    enemy.coordinates[0] += enemym;
                    enemy.coordinates[2] += enemym;
                }
            }
            if (orientation < 6 && xy > 5 && enemy.coordinates[1] > 7 && FreePlace(enemies, enemy, 3))
            {
                if (Move_limit(enemy, map, 3))
                {
                    enemy.coordinates[1] -= enemym;
                    enemy.coordinates[3] -= enemym;
                }
            }
            if (orientation > 5 && xy > 5 && enemy.coordinates[3] < 30 && FreePlace(enemies, enemy, 4))
            {
                if (Move_limit(enemy, map, 4))
                {
                    enemy.coordinates[1] += enemym;
                    enemy.coordinates[3] += enemym;
                }
            } //типо движение противника
        }

        public static void Game()
        {
            DrawMap draw = new DrawMap();
            int last_type_map = 0;

            Console.SetCursorPosition(37, 13);
            Console.WriteLine("ДЛЯ АДЕКВАТНОЙ РАБОТЫ НАЖМИТЕ ALT + ENTER");
            Thread.Sleep(2000);
            Console.Clear();

            int[] coordinates = { 5, 22 };//Начальные координаты гг

            Console.WriteLine("Для выхода нажмите - 4");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Выберите героя:");
            Console.WriteLine("1. Воин (Нажмите 1 для выбора)");
            Console.WriteLine("2. Лучник (Нажмите 2 для выбора)");
            Console.WriteLine("3. Маг (Нажмите 3 для выбора)");

            var person = new Person();//Создание переменной person, а потом ее переназначение

            //Для считывания клавиш


            switch (Quests.GetIntInRange(4))
            {
                case 1:
                    person = new Warrior(coordinates);
                    break;
                case 2:
                    person = new Archer(coordinates);
                    break;
                case 3:
                    person = new Mage(coordinates);
                    break;
                case 4:
                    return;
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            person.inventory = new Inventory();


            Console.CursorVisible = false;
            Spawn enemy_list = new Spawn();
            enemy_list.enemies = new List<Enemy>();
            Random rnd = new();
            //Передвижение по консоли
            do
            {

                Console.Clear();

                if (draw.map[person.coordinates[1], person.coordinates[0] + 2] == '|' || draw.map[person.coordinates[1] + 2, person.coordinates[0]] == '-')
                {
                    person.coordinates[0] = 5;
                    person.coordinates[1] = 22;
                    person.level++;
                    person.type_map = GenerationMap.GenerationMap.Random_map(person.type_map);


                    Spawn.Spawn_Enemy(person, enemy_list.enemies);

                    rnd = new();
                }
                int b = rnd.Next(1, 5);
                Move(person, keyInfo, draw.map);
                GenerationMap.GenerationMap.Map(person, draw);
                DrawPerson.Draw_Person(person.coordinates);
                if (enemy_list.enemies.Count > 0)
                {
                    foreach (var enemy in enemy_list.enemies)
                    {

                        if (person.coordinates[0] - 13 < enemy.coordinates[0] && enemy.coordinates[0] < person.coordinates[0] + 14
                            && person.coordinates[1] - 10 < enemy.coordinates[1] && enemy.coordinates[1] < person.coordinates[1] + 10)
                        {
                            if (enemy.coordinates[0] < person.coordinates[0] && Move_limit(enemy, draw.map, 2))
                            {
                                enemy.coordinates[0]++;
                            }
                            else if (enemy.coordinates[0] > person.coordinates[0] && Move_limit(enemy, draw.map, 1))
                            {
                                enemy.coordinates[0]--;
                            }
                            if (enemy.coordinates[1] < person.coordinates[1] && Move_limit(enemy, draw.map, 3))
                            {
                                enemy.coordinates[1]++;
                            }
                            else if (enemy.coordinates[1] > person.coordinates[1] && Move_limit(enemy, draw.map, 4))
                            {
                                enemy.coordinates[1]--;
                            }
                            enemy.draw(enemy.coordinates[0], enemy.coordinates[1]);
                        }
                        else { Move_enemy(enemy_list.enemies, enemy, draw.map); }

                    }
                    foreach (var enemy in enemy_list.enemies)
                    {

                        if ((enemy.coordinates[0] - 2 < person.coordinates[0] && enemy.coordinates[2] + 2 > person.coordinates[0]
                            || enemy.coordinates[2] + 4 > person.coordinates[0] + 2 && enemy.coordinates[0] - 4 < person.coordinates[0] + 2)
                            && (enemy.coordinates[1] - 5 < person.coordinates[1] + 1 && enemy.coordinates[3] + 4 > person.coordinates[1] + 1
                            || enemy.coordinates[3] + 5 > person.coordinates[1] - 1 && enemy.coordinates[1] - 5 < person.coordinates[1] - 1))
                        {
                            do
                            {
                                Console.Clear();
                                Battle.Battle.Enemy_do(person, enemy);
                            } while (person.heart > 0 && enemy.hp > 0);
                        }
                        if (person.heart <= 0)
                        {
                            //Console.Clear();
                            //Console.WriteLine("You died");
                            break;

                        }
                        else if (enemy.hp <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You got {0} money", b);
                            person.money += b;
                            enemy_list.enemies.Remove(enemy);
                            break;
                        }
                    }

                }

                if (person.heart <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You died");
                    System.Threading.Thread.Sleep(1000);
                    break;

                }
                if (person.type_map == 1 | (person.level % 3 == 0 && draw.map[person.coordinates[1] - 3, person.coordinates[0]] == '-'))
                {
                    if (person.type_map != 1)
                        last_type_map = person.type_map;
                    person.type_map = 1;
                    ChillRoom(person, keyInfo);
                }


                if (person.type_map == 1 && person.level != 0 && draw.map[person.coordinates[1] + 3, person.coordinates[0]] == '-')
                {
                    person.type_map = last_type_map;
                }




                if (person.level == 21)
                {
                    Console.WriteLine("Вы выйграли!!!!");
                    break;
                }


                Console.SetCursorPosition(0, 39);
                if (person.type_of_person == 1)
                    Console.WriteLine("Персонаж - ВОИН");
                else if (person.type_of_person == 2)
                    Console.WriteLine("Персонаж - ЛУЧНИК");
                else
                    Console.WriteLine("Персонаж - МАГ");
                Console.WriteLine("HP - {0} (Броня - {1})", person.heart, person.armor);
                Console.WriteLine("Деньги - {0}", person.money);
                Console.WriteLine("Дамаг - {0}    {1}", person.damage, person.weapon_name);


                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                    Menu.Menu.Esc();

            } while (true);
        }
    }
}