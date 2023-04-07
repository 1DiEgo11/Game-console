using System;
using System.Data.SqlTypes;

namespace enemy
{
    public class Enemy
    {
        public int type_of_person;
        public double hp;
        public int[] coordinates = new int[4];
        public double damage;
        public int sizex;
        public int sizey;
        public int level;
        public int attack_radius;
        
        public Enemy()
        {
            this.hp = 3;
            this.damage = 1;
            Random random = new();
            int mobX = random.Next(15, 60);
            int mobY = random.Next(15, 30);
            this.coordinates[0] = mobX;
            this.coordinates[1] = mobY;
        }
        public virtual void draw(int mobX, int mobY)
        {
            Console.WriteLine("ВРАГ!!!!");
        }
    }

    public class Zombi : Enemy
    {
        public Zombi(int lvl)
        {
            this.type_of_person = 1;
            this.level = lvl;
            this.hp = 3 + 0.5 * lvl;
            this.damage = 1 + 0.5 * lvl;
            this.attack_radius = 3;
            this.sizex=7;
            this.sizey=0;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }

        public override void draw(int mobX, int mobY)
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
            this.type_of_person = 2;
            this.level = lvl;
            this.hp = 4 +  lvl;
            this.damage = 2 + lvl;
            this.attack_radius = 3;
            this.sizex = 5;
            this.sizey = 2;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);//средний враг 1типа
            Console.Write("{&_&}");
            Console.SetCursorPosition(mobX + 1, mobY + 1);
            Console.Write("/#\\");
            Console.SetCursorPosition(mobX + 1, mobY + 2);
            Console.Write("| |");
        }
    }

    public class Skelet : Enemy
    {
        public Skelet(int lvl)
        {
            this.type_of_person = 3;
            this.level = lvl;
            this.hp = 2 + 0.5 * lvl;
            this.damage = 1.5 + 0.5 * lvl;
            this.attack_radius = 15;
            this.sizex = 7;
            this.sizey = 0;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);  //маленький враг 2типа
            Console.Write("<{°=°}>");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }

    public class Elite_Skelet : Enemy
    {
        public Elite_Skelet(int lvl)
        {
            this.type_of_person = 4;
            this.level = lvl;
            this.hp = 3 + lvl;
            this.damage = 3 + lvl;
            this.attack_radius = 15;
            this.sizex = 5;
            this.sizey = 2;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
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
            this.type_of_person = 5;
            this.level = lvl;
            this.hp = 3 + 0.5 * lvl;
            this.damage = 1.5 + 0.5 * lvl;
            this.attack_radius = 20;
            this.sizex = 7;
            this.sizey = 0;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
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
            this.type_of_person = 6;
            this.level = lvl;
            this.hp = 4 + lvl;
            this.damage = 3 + lvl;
            this.attack_radius = 20;
            this.sizex = 5;
            this.sizey = 2;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
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
            this.type_of_person = 7;
            this.hp = 50;
            this.damage = 5;
            this.attack_radius = 5;
            this.sizex=34;
            this.sizey=10;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);   //босс 1типа
            Console.Write("        ,     \\    /      , ");
            Console.SetCursorPosition(mobX, mobY + 1);
            Console.Write("       / \\    )\\__/(     / \\ ");
            Console.SetCursorPosition(mobX, mobY + 2);
            Console.Write("      /   \\  (_\\  /_)   /   \\");
            Console.SetCursorPosition(mobX, mobY + 3); 
            Console.Write("     /_____\\__\\@  @/___/_____\\");
            Console.SetCursorPosition(mobX, mobY + 4);
            Console.Write("|             |\\../|              |");
            Console.SetCursorPosition(mobX, mobY + 5);
            Console.Write("|              \\VV/               |");
            Console.SetCursorPosition(mobX, mobY + 6);
            Console.Write("|_________________________________|");
            Console.SetCursorPosition(mobX, mobY + 7);
            Console.Write(" |    /\\ /      \\\\       \\ /\\    |");
            Console.SetCursorPosition(mobX, mobY + 8);
            Console.Write(" |  /   V        ))       V   \\  |");
            Console.SetCursorPosition(mobX, mobY + 9);
            Console.Write(" |/     `       //        '     \\|");
            Console.SetCursorPosition(mobX, mobY + 10);
            Console.Write(" `              V                '");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }

    public class Chekanov_version2 : Enemy
    {
        public Chekanov_version2(int lvl)
        {
            this.type_of_person = 8;
            this.hp = 100;
            this.damage = 10;
            this.attack_radius = 7;
            this.sizex = 40;
            this.sizey = 13;
            this.coordinates[2] = this.coordinates[0] + this.sizex;
            this.coordinates[3] = this.coordinates[1] + this.sizey;
        }
        public override void draw(int mobX, int mobY)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(mobX, mobY);  //босс 2типа
            Console.Write("             _/|    _   |\\_");
            Console.SetCursorPosition(mobX, mobY + 1);
            Console.Write("           _/_ |   _|\\\\ | _\\_");
            Console.SetCursorPosition(mobX, mobY + 2);
            Console.Write("         _/_/| /  /   \\|\\ |\\_\\_");
            Console.SetCursorPosition(mobX, mobY + 3);
            Console.Write("       _/_/  |/  /  _  \\/\\|  \\_\\_");
            Console.SetCursorPosition(mobX, mobY + 4);
            Console.Write("     _/_/    ||  | | \\o/ ||    \\_\\_");
            Console.SetCursorPosition(mobX, mobY + 5);
            Console.Write("    /_/  | | |\\  | \\_ V  /| | |  \\_\\");
            Console.SetCursorPosition(mobX, mobY + 6);
            Console.Write("   //    ||| | \\_/   \\__/ | |||    \\\\");
            Console.SetCursorPosition(mobX, mobY + 7);
            Console.Write("  // | \\  \\          /  / | \\\\");
            Console.SetCursorPosition(mobX, mobY + 8);
            Console.Write(" //_/ \\|||| \\/\\\\        //\\/ ||||/ \\_\\\\");
            Console.SetCursorPosition(mobX, mobY + 9);
            Console.Write("///    \\\\\\\\/   /        \\   \\////    \\\\\\");
            Console.SetCursorPosition(mobX, mobY + 10);
            Console.Write("  /      \\/    |    |    |     \\/      \\|");
            Console.SetCursorPosition(mobX + 14, mobY + 11);
            Console.Write("/ _|  | |_  \\");
            Console.SetCursorPosition(mobX+13, mobY + 12);
            Console.Write("///_| |_||\\_ \\"); Console.SetCursorPosition(mobX+13, mobY + 13);
            Console.Write("|/|//||/||\\/||\\");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}