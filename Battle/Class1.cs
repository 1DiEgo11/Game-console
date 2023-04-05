using character;
using enemy;
using weapon;

namespace Battle
{
    public class Battle
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        public static void Attack(Person player, Enemy enemy, Weapon weapon)
        {
            enemy.hp -= player.damage * weapon.Damage;
            if (weapon.Type == "magic")
            {
                player.mana -= 5;
            }
        }

        public static void Miss(Person player, Enemy enemy, Weapon deffense)
        {
            Random random = new Random();
            int res = random.Next(0, 11);
            if (res < 6)
            {
                player.heart -= enemy.damage * deffense.Damage;
            }
        }
        public static void Stand(Person player, Enemy enemy, Weapon deffense)
        {
            player.heart -= enemy.damage * deffense.Damage;
        }


        public static void Enemy_miss(Person player, Enemy enemy, Weapon weapon)
        {
            Random random = new Random();
            int res = random.Next(0, 11);
            if (res < 6)
            {
                Battle.Attack(player, enemy, weapon);
            }
        }

        public static void Enemy_do(Person player, Enemy enemy, Weapon weapon, ConsoleKeyInfo keyInfo)
        {
            Random random = new Random();
            int res = random.Next(0, 11);
            Console.WriteLine(res);
            if (res < 6) //attack
            {
                if (keyInfo.Key == ConsoleKey.X)
                {
                    Battle.Miss(player, enemy, weapon);
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        //Battle.Attack(player, enemy, weapon);
                        enemy.hp -= player.damage * weapon.Damage;
                    }
                    player.heart -= enemy.damage * weapon.Damage;
                }
            }
            else
            {
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    Battle.Enemy_miss(player, enemy, weapon);
                }
            }

        }

    }

}