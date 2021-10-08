using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-10ni
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, 
            //siis mängu võidab arvuti
            //programm genereerib juhuslikku numbrit ühe korra

            int i = 0;
            
          
            while (i < 3)
            {
                Console.WriteLine("Sisesta number:");
                int UserNumber = Convert.ToInt32(Console.ReadLine());
                
                if(UserNumber == 5)
                {
                    Console.WriteLine("Õige number! Oled võitnud.");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number! {3 - i} katset jäänud.");
                }
            }

        }
    }
}
