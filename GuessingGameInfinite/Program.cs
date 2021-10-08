using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-10ni
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhuslikku numbrit ühe korra


            Random rnd = new Random();

            bool loopActive = true;

            while (loopActive)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine("Sisesta oma number");
                int cpuRandom = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == 5)
                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    loopActive = false;

                }
                else
                {

                    Console.WriteLine("Vale number. Proovi uuesti!");

              
            
                }
            }
        }
    }
}              
