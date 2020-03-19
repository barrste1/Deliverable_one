using System;

namespace Deliverables1
{
    class Program
    {
        static void Main(string[] args)
        {   string destination = "";
            string travel = "";
            int vacationError = 0;
            string result = "";
            Console.WriteLine("Hello! My name is Vaycay, The Vacation Guru! What is your name?");
            string name = Console.ReadLine();
            string greetings = "It's nice to meet you, " + name +
                "! I can already think of some AMAZING vacation ideas for you! Now, if you *had* to pick, would you prefer a musical, tropical, or adventurous destination?";
            Console.Write(greetings);
            string vacationType = Console.ReadLine();
            vacationType = vacationType.ToLower();
            while (vacationError < 1)
            {
                if (vacationType.Contains("musical"))
                {
                    Console.WriteLine("Oooo! I can already hear the beautiful music from here! I have a place in mind! How many people are going on this vacation?");
                    vacationError = 1;
                    vacationType = "a musical vacation";
                    destination = "experience lively New Orleans!";
                }else if (vacationType.Contains("adventurous")){
                    Console.WriteLine("That's the spirit! A little adventure never hurt anyone! Adventures are always more fun with a party! How many people are going on this vacation?");
                    vacationError = 1;
                    vacationType = "an adventurous vacation";
                    destination = "go whitewater rafting at the Grand Canyon!";
                }else if (vacationType.Contains("tropical")){
                    Console.WriteLine("Ahh! I could go for a little bit of sun myself! Computer programs don't get let out often, ya know? Got room for one more? How many people are going on this vacation?");
                    vacationError = 1;
                    vacationType = "a tropical vacation";
                    destination = "relax with a beach vacation in Mexico!";
                }
                else{
                    Console.WriteLine("Awww come on! Trust me! Just play along! I'm really good at suggestions!! Would you like to go on a musical, adventurous, or tropical vacation?");
                    vacationType = Console.ReadLine();
                    vacationType = vacationType.ToLower();
                }
            }
            int groupSize = int.Parse(Console.ReadLine());
            while (groupSize < 1)
            {
                    Console.WriteLine("Ok " + name + "... That's REAL cute! How many people are *actually* going on this vacation?");
                    groupSize = int.Parse(Console.ReadLine());
                }
            if (groupSize <= 2) 
            {
                travel = "fly first class! Live it up"+name+" !! Woooo!";
                } else if (groupSize <= 5)
            {
                travel = "fly in a helicopter! Have fun on your trip "+name+" !";
            } else travel = "take a charter flight. Make sure to leave early enough "+name+" to get through security on time!";
            if (groupSize == 1)
            {
                result = "Alright! I've got it! Since you want " + vacationType + " you should " + destination + " Also, with " + groupSize + " person you should really " + travel;
            }
            else
            {
                result = "Alright! I've got it! Since you want " + vacationType + " you should " + destination + " Also, with " + groupSize + " people you should really " + travel;
            }
            Console.WriteLine(result);
                }

                
            

        }
    }


