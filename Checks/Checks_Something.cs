using Battle;
using character;
using quests;
using System;


namespace Checks
{
    public class Checks
    {
        public static void ChillRoom(Person person, ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.E)
            {
                Console.Clear();
                Quests.QuestRoom(person);
            }
        }

        public static void Next_Level(Person person, Spawn enemy_list, char[,] map)
        {
            if (map[person.coordinates[1], person.coordinates[0] + 2] == '|' && enemy_list.enemies.Count == 0)
            {
                person.coordinates[0] = 5;
                person.coordinates[1] = 22;
                person.level++;
                person.type_map = GenerationMap.GenerationMap.Random_map(person.type_map);

                Spawn.Spawn_Enemy(person, enemy_list.enemies);
            }
            else
            {
                person.coordinates[0]--;
            }
        }

        public static void Other(Person person, char[,] map, int last_type_map, ConsoleKeyInfo keyInfo)
        {
            if (person.type_map == 1 | (person.level % 3 == 0 && map[person.coordinates[1] - 3, person.coordinates[0]] == '-'))
            {
                if (person.type_map != 1)
                    last_type_map = person.type_map;
                person.type_map = 1;
                ChillRoom(person, keyInfo);
            }
            if (person.type_map == 1 && person.level != 0 && map[person.coordinates[1] + 3, person.coordinates[0]] == '-')
            {
                person.type_map = last_type_map;
            }
        }
    }
}