using System;
using System.Collections.Generic;

namespace w5recap
{
    class Program
    {
        public enum DisplayOrientations
        {
            Landscape = 1,
            Portrait = 2,
        }
        static void Main(string[] args)
        {




            //1. Write a program and ask the user to enter a number. 
            // The number should be between 1 to 10. If the user enters 
            // a valid number, display "Valid" on the console. 
            // Otherwise, display "Invalid". (This logic is used a lot in 
            // applications where values entered into input boxes need to be validated.)
            //Validate();

            //2. Write a program which takes two numbers from the console and displays the maximum of the two.
            //Max();

            //3. Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            // is landscape or portrait. Use an enum for in which to group the landscape and portrait orientations
            //LandscapePortrait();


            // 4. Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            // penalty points. For every 5km/hr above the speed limit, 1 penalty point should be incurred and displayed on 
            // the console. If the number of penalty points is above 12, the program should display License Suspended.
            // SpeedLimit();


            //5. Write a program and continuously ask the user to enter different names, until the user presses Enter 
            // (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

            NameList();
        }

        //1. Write a program and ask the user to enter a number. 
        // The number should be between 1 to 10. If the user enters 
        // a valid number, display "Valid" on the console. 
        // Otherwise, display "Invalid". (This logic is used a lot in 
        // applications where values entered into input boxes need to be validated.)
        static void Validate()
        {
            while (true)
            {
                Console.WriteLine("Introduceti un nr: ");
                int nr = int.Parse(Console.ReadLine());
                if (nr > 0 && nr <= 10)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }

        //2. Write a program which takes two numbers from the console and displays the maximum of the two.
        static void Maxim()
        {
            while (true)
            {
                Console.WriteLine("Introduceti primul nr: ");
                int nr1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti al doilea nr: ");
                int nr2 = int.Parse(Console.ReadLine());
                if (nr1 > nr2)
                {
                    Console.WriteLine("Numarul mai mare este: " + nr1);
                }
                else
                {
                    Console.WriteLine("Numarul mai mare este: " + nr2);
                }
            }
        }

        //3. Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        // is landscape or portrait. Use an enum for in which to group the landscape and portrait orientations

        static void LandscapePortrait()
        {

            while (true)
            {
                Console.WriteLine("Introduceti latimea: ");
                int latimea = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti inaltimea: ");
                int inaltimea = int.Parse(Console.ReadLine());

                if (latimea > inaltimea)
                {
                    Console.WriteLine(DisplayOrientations.Landscape);
                }
                else
                {
                    Console.WriteLine(DisplayOrientations.Portrait);
                }
            }
        }


        // 4. Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        // penalty points. For every 5km/hr above the speed limit, 1 penalty point should be incurred and displayed on 
        // the console. If the number of penalty points is above 12, the program should display License Suspended.


        static void SpeedLimit()
        {

            while (true)
            {
                Console.WriteLine("Introduceti limita de viteza: ");
                int limita = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti viteaza: ");
                int viteza = int.Parse(Console.ReadLine());
                int vitezainplus = viteza - limita;
                int punctepenalizare = vitezainplus / 5;


                if (viteza > limita && punctepenalizare > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else if (viteza > limita && punctepenalizare <= 12)
                {
                    Console.WriteLine($"Ai {punctepenalizare} puncte de penalizare");
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
        }

        //Lists
        //<pattern>
        // 1) John, Mary and 3 others like your post
        // 2) John and Mary like your post
        // 3) John likes your post
        // </pattern>

        //5. Write a program and continuously ask the user to enter different names, until the user presses Enter 
        // (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        // dupa multe incercari esuate l-am acceptat pe acesta dar l-am inteles;

        public static void NameList()
        {
            var names = new List<string>();

            while (true)
            {
                var name = AskForName();

                if (string.IsNullOrEmpty(name))
                    break;

                names.Add(name);
                Console.WriteLine(GetLikesMessage(names));
            }
        }

        private static string AskForName()
        {
            Console.WriteLine("Enter a name: (Leave it empty to close the program)");
            return Console.ReadLine();
        }

        private static string GetLikesMessage(List<string> names)
        {
            if (names.Count > 2)
                return names[0] + ", " + names[1] + " and " + GetExtraLikes(names).Count + " liked your post";
            if (names.Count == 2)
                return names[0] + " and " + names[1] + " liked your post";

            return names[0] + " liked your post";
        }

        private static List<string> GetExtraLikes(List<string> names)
        {
            return names.GetRange(2, names.Count - 2);
        }
    }
}
    


