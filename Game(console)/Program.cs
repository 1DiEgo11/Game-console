using character;

int[] coordinates = { 15, 15 };

var person = new Warrior(coordinates);


Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Green;
ConsoleKeyInfo keyInfo;

char playerChar = 'X';

// Координаты флага
int flagX = 25;
int flagY = 5;

do
{
    Console.Clear();
    Console.SetCursorPosition(flagX, flagY);
    Console.Write("F");

    Console.SetCursorPosition(person.coordinates[0], person.coordinates[1]);
    Console.Write(playerChar);

    keyInfo = Console.ReadKey();

    playerChar = playerChar == 'X' ? 'Y' : 'X';

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