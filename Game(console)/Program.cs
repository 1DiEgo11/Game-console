using character;
using weapon;

int[] coordinates = { 15, 15 };//Начальные координаты гг


Console.WriteLine("Выберите героя:");
Console.WriteLine("1. Воин");
Console.WriteLine("2. Лучник");
Console.WriteLine("3. Маг");
int choice = Convert.ToInt32(Console.ReadLine());

var person = new Person();//Создание переменной person, а потом ее переназначение

//Для считывания клавиш
ConsoleKeyInfo keyInfo;
keyInfo = Console.ReadKey();

//Выбор типа персонажа
if (choice == 1)
{
    person = new Warrior(coordinates);
}
else if (choice == 2)
{
    person = new Archer(coordinates);
}
else if (choice == 3)
{
    person = new Mage(coordinates);
}

Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Green;

char playerChar = 'X';//Моделька персонажа 

// Координаты флага(для тестов)
int flagX = 25;
int flagY = 5;

//Передвижение по консоли
do
{
    Console.Clear();
    Console.SetCursorPosition(flagX, flagY);
    Console.Write("F");

    Console.SetCursorPosition(person.coordinates[0], person.coordinates[1]);
    Console.Write(playerChar);

    keyInfo = Console.ReadKey();

    playerChar = playerChar == 'X' ? 'Y' : 'X';//Типа анимация движения

    switch (keyInfo.Key)
    {
        case ConsoleKey.A:
            person.coordinates[0]--;
            break;
        case ConsoleKey.D:
            person.coordinates[0]++;
            break;
        case ConsoleKey.W:
            person.coordinates[1]--;
            break;
        case ConsoleKey.S:
            person.coordinates[1]++;
            break;
    }

    if (person.coordinates[0] == flagX && person.coordinates[1] == flagY)
    {
        Console.Clear();
        Console.WriteLine("EPIC WIN!");
        break;
    }

} while (keyInfo.Key != ConsoleKey.Escape);