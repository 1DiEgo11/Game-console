using character;
using weapon;
using quests;
namespace Inventoty
{
    public class Inventory
    {
        public static void Open_Inventory(Person person)
        {
            Console.WriteLine("1. Оружие\n2. Зелья\n3. Броня\n4. Назад");
            switch (Quests.GetIntInRange(4))
            {
                case 1:
                    int num = 1;
                    if (person.inventory.weapons.Count > 0)
                    {
                        foreach (var weapon in person.inventory.weapons)
                        {
                            Console.WriteLine("{0}. {1} ", num, weapon.Name);
                            num++;
                        }
                        Console.WriteLine("{0}. Назад", num);
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice > person.inventory.weapons.Count + 1)
                        {
                            Console.WriteLine("Неверное число. Нажми верное!");
                        }
                        else if (choice == person.inventory.weapons.Count + 1)
                        {
                            break;
                        }
                        else
                        {
                            Use_Weapon(person, choice);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Тут пусто. Нажмите ENTER");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    num = 1;
                    if (person.inventory.poizons.Count > 0)
                    {
                        foreach (var poizon in person.inventory.poizons)
                        {
                            Console.WriteLine("{0}. {1}", num, poizon.Name);
                            num++;
                        }
                        Console.WriteLine("{0}. Назад", num);
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice > person.inventory.poizons.Count + 1)
                        {
                            Console.WriteLine("Неверное число. Нажми верное!");
                        }
                        else if (choice == person.inventory.poizons.Count + 1)
                        {
                            break;
                        }
                        else
                        {
                            Use_Poizon(person, choice);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Тут пусто. Нажмите ENTER");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    num = 1;
                    if (person.inventory.armor.Count > 0)
                    {
                        foreach (var armor in person.inventory.armor)
                        {
                            Console.WriteLine("{0}. {1}", num, armor.Name);
                            num++;
                        }
                        Console.WriteLine("{0}. Назад", num);
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice > person.inventory.armor.Count + 1)
                        {
                            Console.WriteLine("Неверное число. Нажми верное!");
                        }
                        else if (choice == person.inventory.armor.Count + 1)
                        {
                            break;
                        }
                        else
                        {
                            Use_Armor(person, choice);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Тут пусто. Нажмите ENTER");
                        Console.ReadLine();
                    }
                    break;
                case 4:
                    break;
            }
        }


        public static void Use_Weapon(Person person, int num)
        {
            if (person.weapon_name != null)
            {
                person.damage /= 10;
                Weapon last_weapon = new(person.damage, person.weapon_type, person.weapon_name);
                person.inventory.weapons.Add(last_weapon);
                person.damage = 10;
            }
            person.weapon_type = person.inventory.weapons[num - 1].Type;
            person.weapon_name = person.inventory.weapons[num - 1].Name;
            person.damage *= person.inventory.weapons[num - 1].Damage;
            person.inventory.weapons.RemoveAt(num - 1);

        }

        public static void Use_Poizon(Person person, int num)
        {
            var type_poizon = person.inventory.poizons[num - 1].Type;
            if (type_poizon == "Heal")
            {
                person.heart += 5;
            }
            else if (type_poizon == "defend")
            {
                person.armor *= 0.5;
            }
            else
            {
                person.damage += 5;
            }
            person.inventory.poizons.RemoveAt(num - 1);
        }

        public static void Use_Armor(Person person, int num)
        {
            if (person.armor_name != null)
            {
                Weapon last_armor = new(person.armor, "defence", person.armor_name);
                person.inventory.armor.Add(last_armor);
            }
            person.armor_name = person.inventory.armor[num - 1].Name;
            person.armor = person.inventory.armor[num - 1].Damage;
            person.inventory.armor.RemoveAt(num - 1);
        }
    }
}