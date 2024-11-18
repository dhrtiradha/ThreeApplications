namespace Second
{
    class Program
    {
        private enum Routine
        {
            Cardio,
            Strength,
            Yoga,
            Rest,
            Flexibility,
            Legs,
            FullBody
        }

        static void Main(string[] args)
        {
            string[] weekDays = new string[]
                { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            List<Routine>[] schedule = new List<Routine>[7];

            for (int i = 0; i < schedule.Length; i++)
            {
                schedule[i] = new List<Routine>();
            }

            Console.WriteLine("Welcome to the Workout Schedule program!");
            Console.WriteLine("Please choose workout routines for each day of the week from the following options:");
            Console.WriteLine("1. Cardio\n2. Strength\n3. Yoga\n4. Rest\n5. Flexibility\n6. HIIT\n7. FullBody");

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(
                    $"\nChoose workout routines for {weekDays[i]} (separate multiple choices with commas):");
                Console.WriteLine("For example: 1, 3, 5");

                string input = Console.ReadLine();
                string[] choices = input.Split(',');

                foreach (string choice in choices)
                {
                    if (int.TryParse(choice.Trim(), out int inputNum) && inputNum >= 1 && inputNum <= 7)
                    {
                        schedule[i].Add((Routine)(inputNum - 1));
                    }
                    else
                    {
                        Console.WriteLine($"Invalid choice: {choice}. Skipping.");
                    }
                }
            }

            Console.WriteLine("\nYour Weekly Workout Schedule:");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("| Day        | Routine(s)     |");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < weekDays.Length; i++)
            {
                string routines = string.Join(", ", schedule[i]);
                Console.WriteLine($"| {weekDays[i],-10} | {routines,-14} |");
            }

            Console.WriteLine("-----------------------------------------");
        }
    }
}