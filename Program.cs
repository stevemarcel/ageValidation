// This app is used to group people between the ages of 1 to 100 into 3 groups for daily stipend collection
using System.Collections.Generic;
using System;

namespace pizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
           string personName = "";
           int age = 0;
        
          List<string> child = new List<string>();
          List<string> teenager = new List<string>();
          List<string> adult = new List<string>();
          int[] salary = new int[3];
          salary[0] = 100;
          salary[1] = 1000;
          salary[2] = 3000;

          Console.Write("Please enter your name: ");
          personName = Console.ReadLine();

          Console.Write("Good day " + personName + ", please enter your age: ");
          age = int.Parse(Console.ReadLine());

            if (age <= 0 || age > 100 )
            {
              Console.WriteLine(personName + ", you have entered an invalid age");
            }
            else if (age <= 12 )
            {
              child.Add(personName);
              Console.WriteLine(personName + ", you have been added to the children's group.");
              Console.WriteLine("Your daily stipend is " + salary[0] + " naira.");
            }
            else if (age <= 19)
            {
              teenager.Add(personName);
              Console.WriteLine(personName + ", you have been added to the teenager's group.");
              Console.WriteLine("Your daily stipend is " + salary[1] + " naira.");
            }
            else if (age <= 100)
            {
              adult.Add(personName);
              Console.WriteLine(personName + ", you have been added to the adult's group.");
              Console.WriteLine("Your daily stipend is " + salary[2] + " naira.");
            }

        }
    }
}
