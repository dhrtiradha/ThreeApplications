using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            while (true) 
            {
                Console.WriteLine("Let's choose a type of music you want to listen to. Input the number:");
                Console.WriteLine("1. Rock\n2. Pop\n3. Classical\n4. Country\n5. Mixed \n6. Off");

                bool validInput = int.TryParse(Console.ReadLine(), out int input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                string url = input switch
                {
                    1 => "https://www.youtube.com/watch?v=opVRr27qCBc",
                    2 => "https://www.youtube.com/watch?v=cW8VLC9nnTo&list=PLxA687tYuMWhkqYjvAGtW_heiEL4Hk_Lx",
                    3 => "https://www.bbc.co.uk/sounds/player/bbc_radio_three",
                    4 => "https://www.youtube.com/watch?v=kPoEBMxJh_8",
                    5 => "https://www.youtube.com/watch?v=V0Q1Ed_lO-4",
                    6 => null, 
                    _ => null
                };

                if (url == null && input == 6) 
                {
                    Console.WriteLine("Turning off the radio.");
                    break; 
                }
                else if (url != null)
                {
                    radio.PlaySound(url);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}