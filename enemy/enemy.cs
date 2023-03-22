using System;
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
            int mobX = random.Next(15, 60);
            int mobY = random.Next(15, 30);
            this.coordinates[0] = mobX;
            this.coordinates[1] = mobY;
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

        public  void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);  //маленький враг 1типа
            Console.Write("=(,_,)=");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);//средний враг 1типа
            Console.Write("{&_&}");
            Console.SetCursorPosition(mobX + 1, mobY + 1);
            Console.Write("/#\\");
            Console.SetCursorPosition(mobX + 1, mobY + 2);
            Console.Write("| |");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);  //маленький враг 2типа
            Console.Write("{°=°}");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);//средний враг 2типа
            Console.Write("(#-#)");
            Console.SetCursorPosition(mobX, mobY + 1);
            Console.Write("/[ ]\\");
            Console.SetCursorPosition(mobX + 1, mobY + 2);
            Console.Write("( (");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);//маленький враг 3типа
            Console.Write(">(x_x)<");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);//средний враг 3типа
            Console.Write("(0^0)");
            Console.SetCursorPosition(mobX, mobY + 1);
            Console.Write(")| |(");
            Console.SetCursorPosition(mobX + 1, mobY + 2);
            Console.Write("/ \\");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);   //босс 1типа
            Console.Write(" ,     \\    /      , ");
            Console.SetCursorPosition(mobX, mobY + 1);
            Console.Write("/ \\    )\\__/(     / \\ ");
            Console.SetCursorPosition(mobX - 1, mobY + 2);
            Console.Write("/   \\  (_\\  /_)   /   \\");
            Console.SetCursorPosition(mobX - 2, mobY + 3); Console.Write("/_____\\__\\@  @/___/_____\\");
            Console.SetCursorPosition(mobX - 2, mobY + 3);
            Console.SetCursorPosition(mobX - 7, mobY + 4);
            Console.Write("|             |\\../|              |");
            Console.SetCursorPosition(mobX - 7, mobY + 5);
            Console.Write("|              \\VV/               |");
            Console.SetCursorPosition(mobX - 7, mobY + 6);
            Console.Write("|_________________________________|");
            Console.SetCursorPosition(mobX - 6, mobY + 7);
            Console.Write("|    /\\ /      \\\\       \\ /\\    |");
            Console.SetCursorPosition(mobX - 6, mobY + 8);
            Console.Write("|  /   V        ))       V   \\  |");
            Console.SetCursorPosition(mobX - 6, mobY + 9);
            Console.Write("|/     `       //        '     \\|");
            Console.SetCursorPosition(mobX - 6, mobY + 10);
            Console.Write("`              V                '");
            Console.ForegroundColor = ConsoleColor.Green;
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
        public void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);  //босс 2типа
            Console.Write("_/|    _   |\\_");
            Console.SetCursorPosition(mobX - 2, mobY + 1);
            Console.Write("_/_ |   _|\\\\ | _\\_");
            Console.SetCursorPosition(mobX - 4, mobY + 2);
            Console.Write("_/_/| /  /   \\|\\ |\\_\\_");
            Console.SetCursorPosition(mobX - 6, mobY + 3);
            Console.Write("_/_/  |/  /  _  \\/\\|  \\_\\_");
            Console.SetCursorPosition(mobX - 8, mobY + 4);
            Console.Write("_/_/    ||  | | \\o/ ||    \\_\\_");
            Console.SetCursorPosition(mobX - 9, mobY + 5);
            Console.Write("/_/  | | |\\  | \\_ V  /| | |  \\_\\");
            Console.SetCursorPosition(mobX - 10, mobY + 6);
            Console.Write("//    ||| | \\_/   \\__/ | |||    \\\\");
            Console.SetCursorPosition(mobX - 11, mobY + 7);
            Console.Write("// | \\  \\          /  / | \\\\");
            Console.SetCursorPosition(mobX - 12, mobY + 8);
            Console.Write("//_/ \\|||| \\/\\\\        //\\/ ||||/ \\_\\\\");
            Console.SetCursorPosition(mobX - 13, mobY + 9);
            Console.Write("///    \\\\\\\\/   /        \\   \\////    \\\\\\");
            Console.SetCursorPosition(mobX - 11, mobY + 10);
            Console.Write("/      \\/    |    |    |     \\/      \\|");
            Console.SetCursorPosition(mobX + 1, mobY + 11);
            Console.Write("/ _|  | |_  \\");
            Console.SetCursorPosition(mobX, mobY + 12);
            Console.Write("///_| |_||\\_ \\"); Console.SetCursorPosition(mobX, mobY + 13);
            Console.Write("|/|//||/||\\/||\\");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}