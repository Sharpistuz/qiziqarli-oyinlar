namespace myapp
{
    public class Pogram
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("Keling siz bilan son topish o'ynini o'yanaymiz!!!");
          begin:  
            Console.WriteLine("siz 0 dan 10 gacha son o'ylen men topaman!!!");
            
            int i = Convert.ToInt32(Console.ReadLine());
            int countL = 0,c = Laptop_find(i, countL);
            
            
            
            Console.WriteLine($"\nMen {c} ta urunishda toptim!!!");
            Console.WriteLine("Keling endi men son o'ylaymen siz topasiz kelishdikmi ('_')\n");
            
            int countP = 0;
            Random rand = new Random();
            int number = rand.Next(0, 10);
            int  c1 = Person_find(number, countP);
            
            Console.WriteLine($"\nSiz {c1} ta urunishda topdingiz");
            Console.WriteLine($"{(c == c1 ? "Durrang :) O'yin uchun tashakkur!!" : c>c1 ? "Siz yutdingiz : Bu g'alaba bilan sizni tabriklayman" : "Siz yutqazdingiz : afsuuuus :)))") }");
            fall_back:
            Console.WriteLine("\nYana o'ynashni hohlaysizmi Ha -> '+' / Yo'q -> '-' tugmasidan foydalaning !!!");
            char button = char.Parse(Console.ReadLine());

            if(button == '+')
            {
                goto begin;
            }
            else if (button == '-')
            {
                Console.WriteLine("\nZerikkaningizda yana kelib turing  :| Hozircha hayir... !!!");
            }
            else
            {
                Console.WriteLine("Siz xato tugmani bosdingiz !!! --> Yana qayta urunib ko'rin. ");
                goto fall_back;
            }


        }
        static int Laptop_find(int i, int countL)
        {
            Random rand = new Random();
            int number = rand.Next(0, 10);
            int n = number;

            while (true)
            {
                Console.WriteLine($"Siz o'ylagan son {number}");
                Console.WriteLine("Siz o'ylagan son to'gri bo'sa (T) Siz o'ylagan son katta bo'lsa (+) ni Kichik bo'lsa (-) ni bosing :)");
                countL++;
            qaytar:
                char s = char.Parse(Console.ReadLine());

                if (s == '+')
                {
                    number = rand.Next(n + 1, i + 1);
                    n = number;
                }
                else if (s == 'T')
                {
                    return countL;
                }
                else if (s == '-')
                {
                    number = rand.Next(i, n);
                    n = number;
                }
                else
                {
                    Console.WriteLine("Siz natori belgi kiritdingiz !!!");
                    Console.WriteLine("Yana qayta kritib ko'rin :('");
                    goto qaytar;
                }
            }
        }

        static int Person_find(int number, int countP)
        {
            while (true)
            {
                Console.Write(">>>");
                int i = Convert.ToInt32(Console.ReadLine());
                countP++;

                if (i < number)
                {
                    Console.WriteLine($"Men o'ylagan son {i} dan kattaroq :)_");
                    Console.WriteLine("Yana qayta kiritib ko'rin ('_')");
                }
                else if (i > number)
                {
                    Console.WriteLine($"Men o'ylagan son {i} dan kichikroq :)_");
                    Console.WriteLine("Yana qayta kiritib ko'rin ('_')");

                }
                else
                {
                    Console.WriteLine("\nVa nihoyat siz topib oldingiz :|` ");
                    return countP;
                }
            }
        }
       

    }
}