using System.Runtime.CompilerServices;

namespace FinalExamReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int choiceForNewSubMenu;

            //string[] courseArray = new string[5];
            //List<string> courseList = new List<string>(5);
            //courseList.
            do
            {
                ClearScreen();
                MainMenu();
                Console.WriteLine("What options do you choose? ");
                choice = Int32.Parse(Console.ReadLine());
               

                switch(choice)
                {
                    case 1:

                        do
                        {
                            ClearScreen();
                            NewSubMenu();
                            Console.WriteLine("What options do you choose? ");
                            choiceForNewSubMenu = Int32.Parse(Console.ReadLine());
                        } while (choiceForNewSubMenu != 4);

                        break;
                    case 2:
                        //Open Code
                        
                        //if(c)
                        //{

                        //}


                        HoldScreen();
                        break;
                    case 3:
                        //Save Code
                        Console.WriteLine("We will implement this later!");
                        HoldScreen();
                        break;
                }

            } while (choice != 4);

            Console.WriteLine("Thanks for using my program!");
        }

        static void MainMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Main Menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. New");
            Console.WriteLine("2. Array Stuff");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Exit");
            Console.WriteLine("--------------------");
        }

        static void NewSubMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("New Sub-Menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. New Project");
            Console.WriteLine("2. New Repo");
            Console.WriteLine("3. New File");
            Console.WriteLine("4. Go Back to Main Menu");
            Console.WriteLine("--------------------");
        }

        static void ClearScreen() 
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n");
            }
        }

        static void HoldScreen()
        {
            Console.WriteLine("Press Enter to Continue!");
            Console.ReadLine();
            Console.Clear();
        }

        static void ArrayMenu()
        {
            Console.WriteLine("1. Add more space to an array.");
            Console.WriteLine("2. Add something to the array.");
            Console.WriteLine("3. Display array contents.");
            Console.WriteLine("4. Delete something from the array.");
            Console.WriteLine("5. Display a specific item of the array.");
        }


    }
}