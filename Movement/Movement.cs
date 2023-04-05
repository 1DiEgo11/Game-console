using character;
using Draw;
using enemy;
using Menu;
using quests;

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
                            map[person.coordinates[1] - 1, person.coordinates[0] - 1] != '#' && map[person.coordinates[1] - 1, person.coordinates[0] + 2] != '#')
                        {
                            if (map[person.coordinates[1] - 3, person.coordinates[0]] == '-')
                            {
                                person.coordinates[1]--;
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
                            if(map[person.coordinates[1] + 3, person.coordinates[0]] == '-')
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
                    Console.ReadLine();
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
            ConsoleKeyInfo keyInfo = Console.ReadKey();

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


            person.inventory = new Inventory(); 
            

            Console.CursorVisible = false;

            //Передвижение по консоли
            do
            {
                Console.Clear();
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



                Move(person, keyInfo, draw.map);
                GenerationMap.GenerationMap.Map(person, draw);
                DrawPerson.Draw_Person(person.coordinates);

                
                
                keyInfo = Console.ReadKey();

                if (person.type_map == 1 | (person.level % 3 == 0 && draw.map[person.coordinates[1] - 3, person.coordinates[0]] == '-'))
                {
                    if(person.type_map != 1)
                        last_type_map = person.type_map;
                    person.type_map = 1;
                    ChillRoom(person, keyInfo);
                }

                if(person.type_map == 1 && person.level != 0 && draw.map[person.coordinates[1] + 2, person.coordinates[0]] == '-')
                {
                    person.type_map = last_type_map;
                }

                if (draw.map[person.coordinates[1], person.coordinates[0] + 2] == '|' || draw.map[person.coordinates[1] + 2, person.coordinates[0]] == '-')
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
                if(keyInfo.Key == ConsoleKey.Escape)
                    Menu.Menu.Esc();
            } while (true);
        }
    }
}