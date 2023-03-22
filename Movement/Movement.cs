using character;

namespace Movement
{
    public class MovePerson
    {
        public static void Move(Person person, ConsoleKeyInfo keyInfo)
        {
            keyInfo = Console.ReadKey();
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
        }

        public static void Game()
        {
            int[] coordinates = { 15, 15 };//Начальные координаты гг

            Console.WriteLine("Для выхода нажмите - Escape");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Выберите героя:");
            Console.WriteLine("1. Воин (Нажмите Q для выбора)");
            Console.WriteLine("2. Лучник (Нажмите W для выбора)");
            Console.WriteLine("3. Маг (Нажмите E для выбора)");
            
            var person = new Person();//Создание переменной person, а потом ее переназначение

            //Для считывания клавиш
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Q:
                    person = new Warrior(coordinates);
                    break;
                case ConsoleKey.W:
                    person = new Archer(coordinates);
                    break;
                case ConsoleKey.E:
                    person = new Mage(coordinates);
                    break;
                case ConsoleKey.Escape:
                    return;
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

                if (person.type_of_person == 1)
                    Console.WriteLine("Персонаж - ВОИН");
                else if (person.type_of_person == 2)
                    Console.WriteLine("Персонаж - ЛУЧНИК");
                else
                    Console.WriteLine("Персонаж - МАГ");

                Console.WriteLine("HP - {0} (+{1})", person.heart, person.armor);
                Console.WriteLine("Деньги - {0}", person.money);

                Console.SetCursorPosition(flagX, flagY);
                Console.Write("F");

                Console.SetCursorPosition(person.coordinates[0], person.coordinates[1]);
                Console.Write(playerChar);
                playerChar = playerChar == 'X' ? 'Y' : 'X';//Типа анимация движения

                Movement.MovePerson.Move(person, keyInfo);


                if (person.coordinates[0] == flagX && person.coordinates[1] == flagY)
                {
                    Console.Clear();
                    Console.WriteLine("EPIC WIN!");
                    break;
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}