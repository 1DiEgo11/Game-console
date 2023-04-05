using weapon;

namespace character
{
    public class Inventory
    {
        public List<Weapon> weapons;
        public List<Potion> poizons;
        public List<Weapon> armor;
        public Inventory()
        {
            this.weapons = new List<Weapon>();
            this.poizons = new List<Potion>();
            this.armor = new List<Weapon>();
        }
    }
    public class Person
    {
        public int type_of_person;
        public double heart;
        public int[] coordinates;
        public int money;
        public Inventory inventory;
        public string? weapon_type;
        public string? weapon_name;
        public string? poizon_type;
        public string? armor_name;
        public double damage;
        public double armor;
        public int level;
        public int type_map;

        public Person()
        {
            this.type_map = 1;
            this.type_of_person = 0;
            this.heart = 200;
            this.money = 100;
            this.damage = 10;
            this.armor = 0;
            this.level = 0; 
        }
    }

    public class Warrior : Person
    {
        public Warrior(int[] coordinates)
        {
            this.type_of_person = 1;
            this.coordinates = coordinates;
            this.armor++;
        }
    }

    public class Archer : Person
    {
        public Archer(int[] coordinates)
        {
            this.type_of_person = 2;
            this.coordinates = coordinates;
        }
    }

    public class Mage : Person
    {
        public Mage(int[] coordinates)
        {
            this.type_of_person = 3;
            this.coordinates = coordinates;
        }
    }
}