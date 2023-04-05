using character;
using weapon;
namespace quests
{
    public class ShoppingMall
    {

        public static void Swords(Person person)
        {
            bool sword = true;
            string vot = "Вот, держи";
            Console.WriteLine("1 - Iron Sword (+25% урона) - 3 деняг\n2 - Sun Sword - 4 деняг\n3 - Rainbow Sword - 6 деняг\n4 - The god's sword - 1000 деняг\n5 - This is random, baby - 10 деняг\n6 - назад");
            while (sword)
            {
                switch (Quests.GetIntInRange(6))
                {
                    case 1:
                        if (person.money - 3 > 0)
                        {
                            person.money -= 3;
                            Console.WriteLine(vot + " железный меч.");
                            person.inventory.weapons.Add(new Iron_sword());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        sword = false;
                        break;
                    case 2:
                        if (person.money - 4 > 0)
                        {
                            person.money -= 4;
                            Console.WriteLine(vot + " солнечный меч.");
                            person.inventory.weapons.Add(new Sun_sword());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        sword = false;
                        break;
                    case 3:
                        if (person.money - 6 > 0)
                        {
                            person.money -= 6;
                            Console.WriteLine(vot + " радужный меч.");
                            person.inventory.weapons.Add(new Rainbow_sword());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        sword = false;
                        break;
                    case 4:
                        if (person.money - 1000 > 0)
                        {
                            person.money -= 1000;
                            Console.WriteLine(vot + " божественный меч. В нем хранится сила наисильнейших существ!");
                            person.inventory.weapons.Add(new Dildo());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        sword = false;
                        break;
                    case 5:
                        if (person.money - 10 > 0)
                        {
                            person.money -= 10;
                            Console.WriteLine(vot + " меч бога рандома. Учти, им ты можешь излечить противника.");
                            person.inventory.weapons.Add(new Billion_elements());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        sword = false;
                        break;
                    case 6:
                        sword = false;
                        break;

                }
            }
        }
        public static void Armor(Person person)
        {
            bool armor = true;
            string eto = "Пожалуйста, вот твоя";
            Console.WriteLine("1 - Iron armor - 2 деняг\n2 - God's armor - 100 деняг\n3 - Ebeishaya - 50 деняг:)\n4 - Leather armor - 4 деняг\n5 - назад");
            while (armor)
            {

                switch (Quests.GetIntInRange(5))
                {
                    case 1:
                        if (person.money - 1 > 0)
                        {
                            person.money -= 1;
                            Console.WriteLine(eto + " броня-железка");
                            person.inventory.armor.Add(new Iron_defence());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        armor = false;
                        break;
                    case 2:
                        if (person.money - 100 > 0)
                        {
                            person.money -= 100;
                            Console.WriteLine(eto + " броня самого Господа Бога.");
                            person.inventory.armor.Add(new God_armor());
                        } 
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        armor = false;
                        break;
                    case 3:
                        if (person.money - 50 > 0)
                        {
                            person.money -= 50;
                            Console.WriteLine(eto + " е******ая броня.");
                            person.inventory.armor.Add(new Ebeishaya());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        armor = false;
                        break;
                    case 4:
                        if (person.money - 4 > 0)
                        {
                            person.money -= 4;
                            Console.WriteLine("Добро пожаловать в куб, мужик!");
                            person.inventory.armor.Add(new Leather());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        armor = false;
                        break;
                    case 5:
                        armor = false;
                        break;

                }
            }
        }
        public static void Poizon(Person person)
        {
            bool poizon = true;
            string vot = "Держи, это зелье";
            Console.WriteLine("1 - Heal potion - 3 деняг\n2 - Defend potion - 3 деняг\n3 - Strenght potion - 3 деняг\n4 - назад");
            while (poizon)
            {
                switch (Quests.GetIntInRange(4))
                {
                    case 1:
                        if (person.money - 3 > 0)
                        {
                            person.money -= 3;
                            Console.WriteLine(vot + " здоровья.");
                            person.inventory.poizons.Add(new Heal());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        poizon = false;
                        break;
                    case 2:
                        if (person.money - 3 > 0)
                        {
                            person.money -= 3;
                            Console.WriteLine(vot + " защиты.");
                            person.inventory.poizons.Add(new Defend());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        poizon = false;
                        break;
                    case 3:
                        if (person.money - 3 > 0)
                        {
                            person.money -= 3;
                            Console.WriteLine(vot + " силы.");
                            person.inventory.poizons.Add(new Strengh());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        poizon = false;
                        break;
                    case 4:
                        poizon = false;
                        break;
                }
            }


        }
        public static void Bows(Person person)
        {
            bool bows = true;
            string vot = "Вот, держи";
            Console.WriteLine("1 - Wood Bow - 3 деняг\n2 - Crossbow - 7 деняг\n3 - I don't know you - 40 деняг\n4 - назад");
            while (bows)
            { 
                switch (Quests.GetIntInRange(4))
                {
                    case 1:
                        if (person.money - 2 > 0)
                        {
                            Console.WriteLine(vot + " деревянный лук.");
                            person.inventory.weapons.Add(new Wood_Bow());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        bows = false;
                        break;
                    case 2:
                        if (person.money - 7 > 0)
                        {
                            person.money -= 7;
                            Console.WriteLine(vot + " арбалет.");
                            person.inventory.weapons.Add(new Crossbow());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        bows = false;
                        break;
                    case 3:
                        if (person.money - 40 > 0)
                        {
                            person.money -= 40;
                            Console.WriteLine(vot + " удивительный лук, название которого неизвестно.");
                            person.inventory.weapons.Add(new Repair_you_computer_yourself());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        bows = false;
                        break;

                    case 4:
                        bows = false;
                        break;

                }
            }

        }
        public static void Magic(Person person)
        {
            bool magic = true;
            string vot = "Вот, держи";
            Console.WriteLine("1 - Magic book - 3 деняг\n2 - Heretical book - 6 деняг\n3 - Telepathically Attack - 20 деняг\n4 - назад");
            while (magic)
            {

                switch (Quests.GetIntInRange(4))
                {
                    case 1:
                        if (person.money - 3 > 0)
                        {
                            person.money -= 3;
                            Console.WriteLine(vot + " магическую книгу.");
                            person.inventory.weapons.Add(new Magic_book());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        magic = false;
                        break;
                    case 2:
                        if (person.money - 6 > 0)
                        {
                            Console.WriteLine(vot + " книгу еретика.");
                            person.inventory.weapons.Add(new Bible());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        magic = false;
                        break;
                    case 3:
                        if (person.money - 20 > 0)
                        {
                            person.money -= 20;
                            Console.WriteLine(vot + ". Теперь ты умеешь пользоваться телепатией.");
                            person.inventory.weapons.Add(new Fatronax());
                        }
                        else
                            Console.WriteLine("У тебя не хватает деняг. Иди Сражайся друг мой!");
                        Console.ReadLine();
                        magic = false;
                        break;
                    case 4:
                        magic = false;
                        break;

                }
            }

        }
    }
    public class Quests

    {
        public static void QuestRoom(Person person)
        {
            bool store = true;
            bool shop = true;
            while (store)
            {

                Console.WriteLine("Приветсвтую тебя, путник. Чего желаешь?");
                Console.WriteLine("1 - получить квест.\n2 - посмотреть ассортимент.\n3 - уйти.");
                switch (GetIntInRange(3))
                {
                    case 1:
                        Quests.switchQuests(person);
                        store = false;
                        break;
                    case 2:
                        shop = true;
                        while (shop)
                        {
                            Console.WriteLine("Так,смотри. Вот что у меня есть: (у тебя {0} деняг)", person.money);
                            Console.WriteLine("1 - мечи. 2 - броня. 3 - зелья. 4 - луки. 5 - волшебные зелья. 6 - назад.");

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    ShoppingMall.Swords(person);
                                    Console.Clear();
                                    shop = false;
                                    break;
                                case 2:
                                    ShoppingMall.Armor(person);

                                    Console.Clear();
                                    shop = false;
                                    break;
                                case 3:
                                    ShoppingMall.Poizon(person);
                                    Console.Clear();
                                    shop = false;
                                    break;
                                case 4:
                                    ShoppingMall.Bows(person);
                                    Console.Clear();
                                    shop = false;
                                    break;
                                case 5:
                                    ShoppingMall.Magic(person);
                                    Console.Clear();
                                    shop = false;
                                    break;
                                case 6:
                                    Console.Clear();
                                    shop = false;
                                    break;

                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("До свидания! Удачной дороги.");
                        Thread.Sleep(800);
                        store = false;
                        break;

                }
            }
        }
        public static int GetIntInRange(int optionNumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isRange = number >= 1 && number <= optionNumber;
            while (!isConverted || !isRange)
            {
                Console.WriteLine("Неверное число. Трай эгейн.");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isRange = number >= 1 && number <= optionNumber;
            }
            return number;
        }
        public static string Quest(int a)
        {
            if (a == 1)
            {
                return "Сыграй на батарее";
            }
            else if (a == 2)
            {
                return "Держи розочку из бутылки.Зашей.";
            }
            else if (a == 3)
            {
                return "Вилкой в глаз или в ж***у раз?";
            }
            else if (a == 4)
            {
                return "Что съешь — мыло со стола или хлеб с параши?";
            }
            else if (a == 5)
            {
                return "В ж***у дашь или мать продашь?";
            }
            {
                return string.Empty;
            }

        }
        public static void switchQuests(Person person)
        {
            Random rnd = new Random();
            string quest = Quest(rnd.Next(1, 5));
            Console.WriteLine(quest);



            if (quest == "Сыграй на батарее")
            {
                Console.WriteLine("Варианты: \n1 - пошел нахуй.\n2 - а ты настрой.\n3 - а ты  не ахуел ли.");
                int optionBatareya = GetIntInRange(3);
                switch (optionBatareya)
                {
                    case 1:
                        Console.WriteLine("Пизда тебе,сученыш мелкий.");
                        person.heart--;// - hp
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Молодец. Не опешил перед мужиками. Вот, держи, это тебе."); 
                        person.inventory.weapons.Add(new Iron_sword());
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Ты че базаришь пидрила. Мы прям тут тебя выебем ща.");
                        person.armor += 0.1;// минус армор
                        Console.ReadLine();
                        break;

                }
            }
            else if (quest == "Держи розочку из бутылки.Зашей.")
            {
                Console.WriteLine("Варианты: \n1 - Это невозможно,друг мой.\n2 - Как я тебе бутылку зашью? совсем ку-ку? \n " +
                    "3 - А ты выверни на изнанку, я и зашью.");
                int optionRoza = GetIntInRange(3);
                switch (optionRoza)
                {
                    case 1:
                        Console.WriteLine("Не прав ты. За неправильный ответ тебе - этой розочкой и пропишем.");
                        person.heart--;//-hp
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("А вот так. Легко и просто, не понимаешь, значит глупый, с нами не уживешься. *угрожая розочкой* Выворачивай карманы!!!!");
                        person.money -= 5;// -rnd зелье или монетки
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Красава, братишка. Сразу видно, логика у тебя развита хорошо. Держи, ступай с миром.");
                        person.inventory.weapons.Add(new Tomorrow_by_the_second());//можно забабахать класс оружия с названием розочка ////а можно и не забабахать) 
                        Console.ReadLine();
                        break;
                }
            }
            else if (quest == "Вилкой в глаз или в ж***у раз?")
            {
                Console.WriteLine("1 - В ж***у раз\n2 - Вилкой в глаз\n3 - А на зоне вилок нет\n4 - Я что то среди вас одноглазых не вижу\n");
                int optionVilka = GetIntInRange(4);

                switch (optionVilka)
                {
                    case 1:
                        Console.WriteLine("ООО, так ты у нас из петушар. Ну,готовься");
                        person.armor += 0.1;//-armor
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Вилки конечно нет, но двоечку в глаз щас поймаешь");
                        person.heart--;// -хп
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Правильный ответ. Молодец. Держи.");
                        person.inventory.poizons.Add(new Heal());//Зелье
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Поймал ты нас. Держи тебе заточку, сможешь от других мудил отбиваться");
                        person.inventory.weapons.Add(new Magic_book());// ружбайка
                        Console.ReadLine();
                        break;

                }
            }
            else if (quest == "Что съешь — мыло со стола или хлеб с параши?")
            {
                Console.WriteLine("1 - Мыло со стола\n2 - Хлеб с параши\n3 - Стол не мыльница, параша не хлебница\n4 - И то, и другое\n");
                int optionMylo = GetIntInRange(4);

                switch (Convert.ToInt32(Console.ReadKey().ToString()))
                {
                    case 1:
                        Console.WriteLine("Щас мы тебе рот намылим.");
                        person.heart--;//-максхп
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Так ты петушок галимый. Пацаны, птичка попалась в клетку.");
                        person.armor = 0;// -армор
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Прав ты. Держи,хлебни чифирку, крепче станешь.");
                        person.heart++;// +макс хп(просто захил)
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Готовь ж**у и рот, щас будем мылить и обмывать, петушок.");
                        person.heart--;
                        person.armor = 0;// -макс хп - армор
                        Console.ReadLine();
                        break;

                }
            }
            else if (quest == "В ж***у дашь или мать продашь?")
            {
                Console.WriteLine("1 - Жопа не дается,мать не продается\n2 - В жопу дам\n3 - Пацаны, ну давайте без этого\n4 - Мать продам");
                int optionZhopa = GetIntInRange(4);

                switch (optionZhopa)
                {
                    case 1:
                        Console.WriteLine("Красава,братан. Держи стопарик,выпьешь по дороге.");
                        person.inventory.poizons.Add(new Heal());//+максхп
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Ну давай,расчехляйся.");
                        person.armor += 0.1;// -армор
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Опана,сразу задняя, так значит либо маму не любишь, либо петух.");
                        person.heart--;
                        person.armor = 0;// -maxhp-armor
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Не по пацански это - маму продавать.");
                        person.heart--;// -макс хп
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}