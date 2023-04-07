using character;

namespace TextOutput
{
    public class Text
    {

        public static void First_Text()
        {
            Console.SetCursorPosition(37, 13);
            Console.WriteLine("ДЛЯ АДЕКВАТНОЙ РАБОТЫ НАЖМИТЕ ALT + ENTER");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void Class_Selection()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите героя:");
            Console.WriteLine("1. Воин (Нажмите 1 для выбора)");
            Console.WriteLine("2. Лучник (Нажмите 2 для выбора)");
            Console.WriteLine("3. Маг (Нажмите 3 для выбора)");
            Console.WriteLine("4. Выход");
        }

        public static void Stata(Person person) 
        {
            Console.SetCursorPosition(0, 39);
            if (person.type_of_person == 1)
                Console.WriteLine("Персонаж - ВОИН");
            else if (person.type_of_person == 2)
                Console.WriteLine("Персонаж - ЛУЧНИК");
            else
                Console.WriteLine("Персонаж - МАГ");

            Console.WriteLine("HP - {0} (Коэффициент Брони - {1})", person.heart, person.armor);
            Console.WriteLine("Деньги - {0}", person.money);
            Console.WriteLine("Дамаг - {0}    {1}", person.damage, person.weapon_name);
        }
    }
}