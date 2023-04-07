using character;
using enemy;
using System;
using System.Numerics;
using weapon;
using Animation_Enemys;

namespace Battle
{
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

        public static void Enemy_do(Person player, Enemy enemy, ConsoleKeyInfo keyInfo)

        {
            Animation.GG(keyInfo);
            Console.WriteLine(enemy.hp);
            Console.WriteLine(player.heart);
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
            }
            else
            {
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    Battle.Enemy_miss(player, enemy);
                }
            }
            
            if (enemy.type_of_person < 3) { Animation.AnimationEnemy1(); }
            else if (enemy.type_of_person == 3 || enemy.type_of_person == 4 ) { Animation.AnimationEnemy2(); }
            else if (enemy.type_of_person == 5 || enemy.type_of_person == 6) { Animation.AnimationEnemy3(); }
            Console.WriteLine(enemy.hp);
            Console.WriteLine(player.heart);
        }

    }
    public class Generate_Enemy 
    {
        public Zombi enemy1;
        public Elite_Zombi enemy2;
        public Skelet enemy3;
        public Elite_Skelet enemy4;
        public Wizzard enemy5;
        public Elite_Wizzard enemy6;
        public Generate_Enemy(Person player)
        {
            enemy1 = new Zombi(player.level);
            enemy2 = new Elite_Zombi(player.level);
            enemy3 = new Skelet(player.level);
            enemy4 = new Elite_Skelet(player.level);
            enemy5 = new Wizzard(player.level);
            enemy6 = new Elite_Wizzard(player.level);
            

        }
      
    }
       
}