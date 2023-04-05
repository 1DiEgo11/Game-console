//using character;
//using enemy;
//using weapon;

namespace Battle
{
    //    public class Battle
    //    {

    //        public static void Attack(Person player, Enemy enemy, Weapon weapon)
    //        {
    //            enemy.hp -= player.damage * weapon.Damage;
    //            if (weapon.Type == "magic")
    //            {
    //                player.mana -= 5;
    //            }
    //        }

    //        public static void Miss(Person player, Enemy enemy, Weapon deffense)
    //        {
    //            Random random = new Random();
    //            int res = random.Next(0, 11);
    //            if (res < 6)
    //            {
    //                player.heart -= enemy.damage * deffense.Damage;
    //            }
    //        }
    //        public static void Stand(Person player, Enemy enemy, Weapon deffense)
    //        {
    //            player.heart -= enemy.damage * deffense.Damage;
    //        }


    //        public static void Enemy_miss(Person player, Enemy enemy, Weapon weapon)
    //        {
    //            Random random = new Random();
    //            int res = random.Next(0, 11);
    //            if (res < 6)
    //            {
    //                Battle.Attack(player, enemy, weapon);
    //            }
    //        }

    //        public static void Enemy_do(Person player, Enemy enemy, Weapon weapon)
    //        {
    //            Random random = new Random();
    //            int res = random.Next(0, 11);
    //            if (res < 6)
    //            {
    //                if (key.Key == ConsoleKey.X)
    //                    Battle.Miss(player, enemy, weapon);

    //            }
    //            else
    //            {
    //                if (key.key == ConsoleKey.Z)
    //                {
    //                    Battle.Enemy_miss(player, enemy, weapon);
    //                }
    //            }

    //        }
    //        //do 
    //        //{
    //        //    ConsoleKeyInfo key = Console.ReadKey();
    //        //    Battle.Battle.Enemy_do
    //        //} while (player.heart!=0 || enemy.hp!=0)
    //    }
}