using Movement;
using Battle;
using character;
using enemy;
using weapon;

Person player = new Person();
Chekanov_version2 enemy = new Chekanov_version2(1);
Rainbow_sword weapon = new Rainbow_sword();
Console.WriteLine(enemy.hp);
Battle.Battle.Attack(player, enemy, weapon);
Console.WriteLine(enemy.hp);
do
{
   
    ConsoleKeyInfo key = Console.ReadKey();
    Battle.Battle.Enemy_do(player, enemy, weapon, key);
    Console.WriteLine(player.heart);
    Console.WriteLine(enemy.hp);
} while (player.heart != 0 || enemy.hp != 0);
//MovePerson.Game();
//Console.Clear();
//Console.WriteLine("До скорой встречи!!!");