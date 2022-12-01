using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamReview
{
    public static class RunMattsProject
    {
        public static void Run()
        {
            ConsoleUI.MainMenu();

            int choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
