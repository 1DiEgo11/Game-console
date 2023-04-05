namespace weapon
{
    public class Weapon
    {
        public double Damage;
        public string? Type;
        public string? Name;

        public Weapon()
        {
            Damage = 0;
            Type = null;
            Name = null;
        }

        public Weapon(double damage, string type, string name)
        {
            Damage = damage;
            Type = type;
            Name = name;
        }
    }

    public class Potion
    {
        public string Type;
        public string Name;
        public int stat;
    }

    public class Heal : Potion
    {
        public Heal()
        {
            this.stat = 10;
            this.Type = "Heal";
            this.Name = "Heal poizon";
        }
    }

    public class Defend : Poiton
    {
        public Defend()
        {
            this.stat = 10;
            this.Type = "defend";
            this.Name = "Defend poizon";
        }
    }

    public class Strength : Potion
    {
        public Strength()
        {
            this.stat = 1;
            this.Type = "strengh";
            this.Name = "Strengh poizon";
        }
    }
    public class Iron_sword : Weapon
    {
        public Iron_sword()
        {
            this.Damage = 1.25;
            this.Type = "sword";
            this.Name = "Iron Sword";
        }
    }
    public class Sun_sword : Weapon
    {
        public Sun_sword()
        {
            this.Damage = 1.3;
            this.Type = "sword";
            this.Name = "Sun Sword";
        }
    }

    public class Rainbow_sword : Weapon
    {
        public Rainbow_sword()
        {
            this.Damage = 1.5;
            this.Type = "sword";
            this.Name = "Rainbow Sword";
        }
    }

    public class Dildo : Weapon
    {
        public Dildo()
        {
            this.Damage = 999999;
            this.Type = "sword";
            this.Name = "The god's sword";
        }
    }

    public class Wood_Bow : Weapon
    {
        public  Wood_Bow()
        {
            this.Damage = 1.4;
            this.Type = "bow";
            this.Name = "Wood Bow";
        }
    }

    public class Crossbow : Weapon
    {
        public Crossbow()
        {
            this.Damage = 1.6;
            this.Type = "bow";
            this.Name = "Crossbow";
        }
    }

    public class Magic_book : Weapon
    {
        public Magic_book()
        {
            this.Damage = 1.25;
            this.Type = "magic";
            this.Name = "Magic book";
        }
    }

    public class Bible : Weapon
    {
        public Bible()
        {
            this.Damage = 2;
            this.Type = "magic";
            this.Name = "Heretical book";
        }
    }

    public class Leather : Weapon
    {
        public Leather()
        {
            this.Damage = 0.95;
            this.Type = "defence";
            this.Name = "Welcome to the club body";
        }
    }

    public class Iron_defence : Weapon
    {
        public Iron_defence()
        {
            this.Damage = 0.85;
            this.Type = "defence";
            this.Name = "Iron armor";
        }
    }

    public class God_armor : Weapon
    {
        public God_armor()
        {
            this.Damage = 0.01;
            this.Type = "defence";
            this.Name = "God's armor";
        }
    }

    public class Ebeishaya : Weapon
    {
        public Ebeishaya()
        {
            this.Damage = 4;
            this.Type = "defence";
            this.Name = "Ebeishaya";
        }
    }

    public class Fatronax : Weapon
    {
        public Fatronax()
        {
            this.Damage = 2;
            this.Type = "magic";
            this.Name = "Telepathically Attack";
        }
    }

    public class Tomorrow_by_the_second : Weapon
    {
        public Tomorrow_by_the_second()
        {
            this.Damage = 2.5;
            this.Type = "sword";
            this.Name = "You can sleep";
        }
    }

    public class Repair_you_computer_yourself : Weapon
    {
        public Repair_you_computer_yourself()
        {
            this.Damage = 3;
            this.Type = "bow";
            this.Name = "I don't know you";
        }
    }

    public class Billion_elements : Weapon
    {
        public Billion_elements()
        {
            Random random = new Random();
            double res = random.Next(0, 10);
            double res2 = random.Next(0, 100);
            double res3 = random.Next(0, 11);
            double res4 = 0;
            res2 = res2 / 100;
            if (6 > res3)
            {
                res4 = -res - res2;
            }
            else
            {
                res4 = res + res2;
            }
            this.Damage = res4;
            this.Type = "sword";
            this.Name = "This is random, baby";
        }
    }

}