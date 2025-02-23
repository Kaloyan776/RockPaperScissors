using System.Threading.Channels;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pc = 0;
            int user = 0;

            while (true) 
            {
                string item = Console.ReadLine().ToLower();

                int n = rnd.Next(1, 4);
                string s = "";
                int num;

                switch (n) 
                {
                    case 1:
                        s = "камък";
                        break;
                    case 2:
                        s = "ножица";
                        break;
                    case 3:
                        s = "хартия";
                        break;
                }

                Console.WriteLine(s);

                if (item == "камък" && s == "хартия" || item == "ножица" && s == "камък" || item == "хартия" && s == "ножица")
                {
                    Console.WriteLine("Ти загуби");
                    pc++;
                }
                else if (item == "камък" && s == "ножица" || item == "ножица" && s == "хартия" || item == "хартия" && s == "камък")
                {
                    Console.WriteLine("Ти спечели");
                    user++;
                }
                else
                {
                    Console.WriteLine("Равенство");
                }
                Console.WriteLine($"Победител-{user}:AI-{pc}");

            }

        }
    }
}
