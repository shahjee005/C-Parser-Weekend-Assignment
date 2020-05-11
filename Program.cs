using System;
using System.IO; //To read from files

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        //Option 1 : Prompt  user to enter a filename. 
        {
           

            int i = 0;
            Console.WriteLine("Step 01) Enter your File name here.....");
            string myNewFile = Console.ReadLine();
            while (i < 3)
            {
                i++;
                if (i == 1)
                {
                    File.WriteAllText(myNewFile, "You have created a new file");
                    Console.WriteLine("Congradulations! You have created a new file named:" + myNewFile);
                }
                // Option 2: will prompt the user to enter a string.
                if (i == 2)
                {
                    Console.WriteLine("Step 02) Write anything that you want to see in your file:");
                    string myString = Console.ReadLine();

                    string[] myStringArray = myString.Split(" ");
                    for (int loc = 0; loc < myStringArray.Length; loc++)
                    {
                        File.WriteAllText(myNewFile, myStringArray[loc]);
                        Console.WriteLine();

                    }
                }
            }
            // Option 03: While loop end and program will terminate .
            if (i == 3)
            {
                Console.WriteLine("Step 03) Press ENTER to exit...");
                Console.ReadLine();

                return;
            }

        }
    }

}

