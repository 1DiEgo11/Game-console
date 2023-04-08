using character;
using enemy;
using weapon;
using Animation_Enemys;
using System.Runtime.CompilerServices;
using Draw;
using System;

namespace Battle
{
    public class Spawn
    { 
        public List<Enemy> enemies;

        public static void Draw_Enemy(Spawn enemy_list)
        {
            if (enemy_list.enemies.Count > 0)
            {
                foreach (var enemy in enemy_list.enemies)
                {
                    enemy.draw(enemy.coordinates[0], enemy.coordinates[1]);
                }
            }
        }

        public static Enemy Random_Enemy(Person person)
        {
            Random rnd = new();
            int type_enemy = rnd.Next(1, 7);
            if (type_enemy == 1)
            {
                return new Zombi(person.level);
            }
            else if (type_enemy == 2)
            {
                return new Elite_Zombi(person.level);
            }
            else if (type_enemy == 3)
            {
                return new Skelet(person.level);
            }
            else if (type_enemy == 4)
            {
                return new Elite_Skelet(person.level);
            }
            else if (type_enemy == 5)
            {
                return new Wizzard(person.level);
            }
            else
            {
                return new Elite_Wizzard(person.level);
            }
        }

        public static void Spawn_Enemy(Person person, List<Enemy> enemies)
        {

            enemies.Clear();
            Random random = new();
            int rnd = random.Next(3, 7);

            for (int i = 0; i < rnd; i++)
            {
                Random rnd1 = new();
                int x = rnd1.Next(1, 160);
                int y = rnd1.Next(1, 30);
                Enemy enemy = new();
                enemy = Random_Enemy(person);
                enemy.coordinates[0] = x; enemy.coordinates[1] = y; enemy.coordinates[2] = x + enemy.sizex; enemy.coordinates[3] = y + enemy.sizey;
                enemies.Add(enemy);
            }
        }
    }


    public class Battle
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        public static void Attack(Person player, Enemy enemy)
        {
            enemy.hp -= player.damage;
        }

        public static void Miss(Person player, Enemy enemy)
        {
            Random random = new Random();
            int res = random.Next(0, 11);
            if (res < 6)
            {
                player.heart -= enemy.damage;
            }
        }
        public static void Stand(Person player, Enemy enemy)
        {
            player.heart -= enemy.damage;
        }


        public static void Enemy_miss(Person player, Enemy enemy)
        {
            Random random = new Random();
            int res = random.Next(0, 11);
            if (res < 6)
            {
                Battle.Attack(player, enemy);
            }
        }

        public static void Enemy_do(Person player, Enemy enemy)

        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Your hp: {0}", player.heart);
            Console.WriteLine("Your Damage: {0}", player.damage);
            Console.WriteLine("Your Armor: {0}%", (1-player.armor)*100);

            Console.SetCursorPosition(160, 0);
            Console.Write("Enemy's hp: {0}", enemy.hp);
            DrawPerson.Draw_gg();
            DrawPerson.Draw_enemy(enemy);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Animation.GG(keyInfo);

            Random random = new Random();
            int res = random.Next(0, 11);
            if (res < 6) //attack
            {
                if (keyInfo.Key == ConsoleKey.X)
                {

                    Battle.Miss(player, enemy);
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        //Battle.Attack(player, enemy, weapon);
                        enemy.hp -= player.damage; //работает только так
                    }
                    player.heart -= enemy.damage;
                }
                if (enemy.type_of_person < 3) { Animation.AnimationEnemy1(); }
                else if (enemy.type_of_person == 3 || enemy.type_of_person == 4) { Animation.AnimationEnemy2(); }
                else if (enemy.type_of_person == 5 || enemy.type_of_person == 6) { Animation.AnimationEnemy3(); }
                else { Animation.draw_deag(); }
            }
            else
            {
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    Battle.Enemy_miss(player, enemy);
                }

            }
            //if (enemy.type_of_person < 3) { Animation.AnimationEnemy1(); }
            //else if (enemy.type_of_person == 3 || enemy.type_of_person == 4) { Animation.AnimationEnemy2(); }
            //else if (enemy.type_of_person == 5 || enemy.type_of_person == 6) { Animation.AnimationEnemy3(); }
            //else { Animation.draw_deag(); }

            Console.WriteLine(enemy.hp);
            Console.WriteLine(player.heart);
        }
    }
}