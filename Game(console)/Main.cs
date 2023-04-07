using Movement;
using character;
using enemy;
using weapon;

int[] coordinates = { 5, 22 };
Zombi en = new Zombi(1);
Chekanov boss = new Chekanov(1);
Warrior person = new Warrior(coordinates);

MovePerson.Game();
Console.Clear();
Console.WriteLine("До скорой встречи!!!");
