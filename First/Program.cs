namespace First
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                $"\nEach flower has its own needs. Roses need to be watered once every 3 days. " +
                $"\nCarnations once every 2 days, and any other flower once every 1 day." +
                $"\nThis program will help you know when to water the plant " +
                $"\nand if you have not missed a day already.");
            Console.WriteLine("Please write the name of the flower, it could be 1) rose, 2) carnation, 3) other. Any other won't be accepted.");
            var input = Console.ReadLine().ToLower();

            IFlower flower = null;
            bool shouldWork = true;

            while (shouldWork)
            {
                switch (input)
                {
                    case "rose":
                        flower = new Rose();
                        shouldWork = false;
                        break;
                    case "carnation":
                        flower = new Carnation();
                        shouldWork = false;
                        break;
                    case "other":
                        flower = new Flower();
                        shouldWork = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter either 'rose', 'carnation', or 'other'.");
                        input = Console.ReadLine().ToLower();
                        break;
                }
            }

            if (flower == null)
            {
                Console.WriteLine("Error: No flower.");
                return;
            }

            WateringSchedule wateringSchedule = new WateringSchedule(DateTime.Now);

            DateTime nextWateringDate = wateringSchedule.GetNextWateringDate(flower);

            Console.WriteLine($"Today is {DateTime.Now.ToShortDateString()}.");
            if (flower.WateringFrequency > 1)
            {
                Console.WriteLine($"You should water your {flower.Name} every {flower.WateringFrequency} days.");
            }
            else
            {
                Console.WriteLine($"You should water your {flower.Name} every 1 day.");
            }

            Console.WriteLine($"Next watering date for your {flower.Name}: {nextWateringDate.ToShortDateString()}.");

            Console.WriteLine("Would you like to make a schedule for two weeks ahead or check " +
                              "if you have not forgotten to water the flower correctly for two weeks before? " +
                              "Answer 'yes' to continue and anything else, to end the interaction.");

            bool reply = false;
            do
            {
                Console.WriteLine("Would you like to create a schedule for two weeks? Enter 'yes' to continue or any other input to exit.");
                var answer = Console.ReadLine()?.ToLower();

                if (answer != "yes")
                {
                    reply = true;
                    continue;
                }

                Console.WriteLine("Please enter the starting date (YYYY-MM-DD) for your schedule:");
                var dateInput = Console.ReadLine();

                if (!DateTime.TryParse(dateInput, out DateTime startDate))
                {
                    Console.WriteLine("Invalid date format. Using today's date instead.");
                    startDate = DateTime.Now;
                }

                WateringSchedule twoWeekWateringSchedule = new WateringSchedule(startDate);
                List<DateTime> wateringDates = twoWeekWateringSchedule.GetWateringDates(flower, 14);

                Console.WriteLine("Watering schedule for the next 2 weeks:");
                foreach (var date in wateringDates)
                {
                    Console.WriteLine(date.ToShortDateString());
                }

            } while (!reply);

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
