using System;



namespace Week1_StudentDatabaseLab
{
    class Program
    {
        static void Main(string[] args)

        {
            bool goOn = true;

            Console.WriteLine("Welcome to Meet Your Classmates!");
            PrintStudents();
            SelectStudent();
            Continue();

            Console.WriteLine("Here are your classmates:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i + "." + " " + students[i]);
            }

            while (goOn == true)
            {
                Console.WriteLine("Which student would you like to learn more about?");
                Console.WriteLine("Please enter either a student number: ");
                int studentIndex = int.Parse(Console.ReadLine());

                Console.WriteLine($"What would you like to know about {students[studentIndex]}?\n[1]Favorite Food\n[2]Hometown\n[3]See students again");
                int input = int.Parse(Console.ReadLine());
                {
                    Console.WriteLine($"{students[studentIndex]} is from {hometowns[studentIndex]}. {students[studentIndex]}'s favorite food is {favFoods[studentIndex]}.");
                }
                

                
            }
        }

        public static string[] students = { "Yosha", "Marjorie", "James", "Cordero", "Rick", "Calyn", "Anurag", "Huy", "Tommy", "Ramone" };
        public static string[] favFoods = { "biryani, a type of rice mixed with meat", "lasagna", "katsu, a Japanese dish of fried chicken", "BBQ of any type", "the classic hamburger", "macaroni and cheese", "tacos", "korean BBQ", "curry", "chicken soup" };
        public static string[] hometowns = { "Rochester Hills, MI", "Detroit, MI", "Yap, an island in the Federated States of Micronesia", "Berkley, MI", "Gilbert, AZ", "Portage, MI", "Rochester Hills, MI", "Lansing, MI", "Raleigh, NC", "Fort Lauderdale, FL" };

        public static void TownOrFood(int studentIndex)
        {
            Console.WriteLine($"What would you like to know about {students[studentIndex]}?");
            Console.WriteLine("\t[1]Favorite Food\n\t[2]Hometown\n\t[3]Go Back");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine($"{students[studentIndex]}'s favorite food is {favFoods[studentIndex]}.");
                    break;
                case 2:
                    Console.WriteLine($"{students[studentIndex]} is from {hometowns[studentIndex]}.");
                    break;
                case 3:
                    PrintStudents();
                    break;
                default:
                    Console.WriteLine("Try entering a number 1-3.");
                    TownOrFood(studentIndex);
                    break;
            }
        }

        public static void PrintStudents()
        {
            Console.WriteLine("Here are your classmates:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i + "." + " " + students[i]);
            }
        }

        public static int SelectStudent()
        {
            Console.WriteLine("Which student would you like to learn more about?");
            Console.WriteLine("Please enter either a student number: ");
            int studentIndex = int.Parse(Console.ReadLine());
            TownOrFood(studentIndex);
            return studentIndex;
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to learn about another student? y/n");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "y")
            {
                PrintStudents();
                SelectStudent();
                return true;
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine($"No problem. Enjoy the rest of your day!");
                return false;
            }
            else
            {
                Console.WriteLine($"Sorry, '{userAnswer}' is not a valid response.");
                Console.WriteLine("Please enter 'y' to continue or 'n' to exit.");
                Continue();
            }
            return true;
        }

    }
}