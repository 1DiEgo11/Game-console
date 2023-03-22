using System.Data.SqlTypes;

namespace enemy
{
    public class Enemy
    {
        public int type_of_person;
        public double hp;
        public int[] coordinates = new int[2];
        public double damage;
        public int size;
        public int level;
        public int attack_radius;

        public Enemy()
        {
            this.type_of_person = 1;
            this.hp = 3;
            this.damage = 1;
            Random random = new Random();
            int x = random.Next(10, 30);
            int y = random.Next(10, 30);
            this.coordinates[0] = x;
            this.coordinates[1] = y;
        }
    }

    public class Zombi : Enemy
    {
        public Zombi(int lvl)
        {
            this.level = lvl;
            this.hp = 3 + 0.5 * lvl;
            this.damage = 1 + 0.5 * lvl;
            this.attack_radius = 3;
        }
    }
    public class Elite_Zombi : Enemy
    {
        public Elite_Zombi(int lvl)
        {
            this.level = lvl;
            this.hp = 4 +  lvl;
            this.damage = 2 + lvl;
            this.attack_radius = 3;
        }
    }

    public class Skelet : Enemy
    {
        public Skelet(int lvl)
        {
            this.level = lvl;
            this.hp = 2 + 0.5 * lvl;
            this.damage = 1.5 + 0.5 * lvl;
            this.attack_radius = 15;
        }
    }

    public class Elite_Skelet : Enemy
    {
        public Elite_Skelet(int lvl)
        {
            this.level = lvl;
            this.hp = 3 + lvl;
            this.damage = 3 + lvl;
            this.attack_radius = 15;
        }
    }

    public class Wizzard : Enemy
    {
        public Wizzard(int lvl)
        {
            this.level = lvl;
            this.hp = 3 + 0.5 * lvl;
            this.damage = 1.5 + 0.5 * lvl;
            this.attack_radius = 20;
        }
    }

    public class Elite_Wizzard : Enemy
    {
        public Elite_Wizzard(int lvl)
        {
            this.level = lvl;
            this.hp = 4 + lvl;
            this.damage = 3 + lvl;
            this.attack_radius = 20;
        }
    }

    public class Chekanov : Enemy
    {
        public Chekanov (int lvl)
        {
            this.hp = 50;
            this.damage = 5;
            this.attack_radius = 5;
        }
    }

    public class Chekanov_version2 : Enemy
    {
        public Chekanov_version2(int lvl)
        {
            this.hp = 100;
            this.damage = 10;
            this.attack_radius = 7;
        }
    }
}