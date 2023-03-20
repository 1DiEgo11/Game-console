namespace character
{

    public class Person
    {
        public int type_of_person;
        public int hurt;
        public int[] coordinates;
        public int money;
        public string[]? inventory;
        public int mana;
        public string weapon_type;
        public double damage;
        public int armor;
        public int level;



        public Person()
        {
            this.type_of_person = 0;
            this.hurt = 6;
            this.money = 0;
            this.mana = 20;
            this.damage = 2;
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
            this.mana = 100;
        }
    }

}