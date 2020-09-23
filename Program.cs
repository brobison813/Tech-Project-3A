using System;
/* Programmer Brian Robison
 * tech project 3a 
 * 9/24/2020
 * This project is designed to demo a method.
 */
namespace Tech_Project_3A
{
    class Program
    {
        static void Main(string[] args)
        {   
            //user instructions
            Console.WriteLine("Please enter your name.");
            //taking input to a varible for the name
            string name = Console.ReadLine();
            // calling method Output_Name
            Output_Name(name);
        }// end of main
        //method for displaying the input varible but to the user
        private static void Output_Name(string input)
        {
            // pass varible to output the user name
            Console.WriteLine("Hello " + input + " Go Lightning!");
        }//end of Output_Name
    }//End of class
}//end of namespace

