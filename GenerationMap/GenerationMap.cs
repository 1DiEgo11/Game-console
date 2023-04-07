using character;
using Draw;

namespace GenerationMap
{
    public class GenerationMap
    {
        public static int Random_map(int x)
        {
            int type_map;

            Random random = new Random();
            int rnd = random.Next(1, 6);
            int rnd1 = random.Next(1, 5);
            if (rnd != x)
                type_map = rnd;
            else if (rnd == 1)
                type_map = x + rnd1;
            else if (rnd == 5)
                type_map = x - rnd1;
            else
               type_map = x + 1;


            if (type_map == 1)
            {
                return  2;
            }
            else if (type_map == 2)
            {
                return 3;
            }
            else if (type_map == 3)
            {
                return 4;
            }
            else if (type_map == 4)
            {
                return 5;
            }
            else if (type_map == 5)
            {
                return 6;
            }
            else return 0;
            
        }
        public static void Map(Person person, DrawMap draw)
        {
            if (person.type_map == 1)
            {
                DrawMap.FirstMap(person, draw);
            }
            if (person.type_map == 2)
            {
                DrawMap.SecondMap(person, draw);
            }
            if (person.type_map == 3)
            {
                DrawMap.ThirdMap(person, draw);
            }
            if (person.type_map == 4)
            {
                DrawMap.FouthMap(person, draw);
            }
            if (person.type_map == 5)
            {
                DrawMap.FifthMap(person, draw);
            }
            if (person.type_map == 6)
            {
                DrawMap.SixMap(person, draw);
            }
        }
    }
}