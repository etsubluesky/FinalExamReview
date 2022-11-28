using System.Runtime.CompilerServices;

namespace FinalExamReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primitive
            int wholeNumber = 8;
            //char letterOrANumber;
            //bool trueOrFalse;
            //double realNumbers;
            //float anotherRealNumberMorePrecision;
            //decimal anotherRealNumberMoreAccuracy;

            //long bigWholeNumber;
            //byte smallWholeNumber;
            //short smallWholeNumberButLargerThenAByteSmallerThenAnInt;

            //ref data type
            char[] letters = { 'a', 'b', 'c'};
            char[] letters2 = { 'a', 'd', 'c' };
            
            
            //model but it is also a ref data type
            string name = "Matt";

            //!= 
            //==
            //<
            //>
            //<=
            //>=

            if(letters.Length == letters2.Length)
            {
                bool isEqual = true;

                //keep checking
                for (int i = 0, y = 4; i < letters.Length; i++)
                {
                    if (letters[i] != letters2[i])
                    {
                        isEqual = false;
                    }
                }
                
                if(isEqual)
                {
                    Console.WriteLine("They are equal!");
                }
                else
                {
                    Console.WriteLine("They are not equal!");
                }
            }
            else 
            {
                Console.WriteLine("They are not the same length");
            }

            switch(name)
            {
                case "Matt":
                    //do something
                    break;
                case "Casey":
                    //do something
                    break;
                default:
                    //this will awlays run if none of the other case work
                    break;
            }

            foreach (char item in letters)
            {
                Console.WriteLine(item);
            }

            while(true)
            {
                //repeat while true
            }

            do
            {
                //do it at least one time

            } while (true);
        }
    }
}