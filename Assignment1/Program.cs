﻿using System;

namespace Assignment1
{
    class Program
    {
        public static int choice;
        public static void Main(string[] args)
        {
            try
            {
                Rectangle r = new Rectangle();
                
                do
                {
                    Console.WriteLine("Please enter the length of a Rectangle:");
                    int user_entered_length = Convert.ToInt32(Console.ReadLine());
                    if (user_entered_length >= 1)
                    {
                       Console.WriteLine("Please enter the width of a Rectangle:");
                       int user_entered_width = Convert.ToInt32(Console.ReadLine());
                       if (user_entered_width >= 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-----Menu options are as follows: -------");
                            Console.WriteLine("1. Get Rectangle Length");
                            Console.WriteLine("2. Change Rectangle Length");
                            Console.WriteLine("3. Get Rectangle Width");
                            Console.WriteLine("4. Change Rectangle Width");
                            Console.WriteLine("5. Get Rectangle Perimeter");
                            Console.WriteLine("6. Get Rectangle Area");
                            Console.WriteLine("7. Exit");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("Please select a menu option, by entering a valid number (i.e. 1-7)");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (choice > 0 && choice <= 7)
                            {
                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("The \"Get Rectangle Length\" option is selected by the user");
                                        int length_Result = r.GetLength();
                                        length_Result = user_entered_length;
                                        Console.WriteLine("The length of a Rectangle is: {0}", length_Result);
                                        break;

                                    case 2:
                                        Console.WriteLine("The \"Change Rectangle Length\" option is selected by the user");
                                        Console.WriteLine("Please enter a new Length for the Rectangle:");
                                        int new_Length = Convert.ToInt32(Console.ReadLine());
                                        int new_Rectangle_Length = r.SetLength(new_Length);
                                        Console.WriteLine("The new Length of a Rectangle is: {0}", new_Rectangle_Length);
                                        break;

                                    case 3:
                                        Console.WriteLine("The \"Get Rectangle Width\" option is selected by the user");
                                        int width_Result = r.GetWidth();
                                        width_Result = user_entered_width;
                                        Console.WriteLine("The width of a Rectangle is: {0}", width_Result);
                                        break;

                                    case 4:
                                        Console.WriteLine("The \"Change Rectangle Width\" option is selected by the user");
                                        Console.WriteLine("Please enter a new Width for the Rectangle:");
                                        int new_width = Convert.ToInt32(Console.ReadLine());
                                        int new_Rectangle_Width = r.SetWidth(new_width);
                                        Console.WriteLine("The new width of a Rectangle is: {0}", new_Rectangle_Width);
                                        break;

                                    case 5:
                                        Console.WriteLine("The \"Get Rectangle Perimeter\" option is selected by the user");
                                        new_Rectangle_Length = r.SetLength(user_entered_length);
                                        new_Rectangle_Width = r.SetWidth(user_entered_width);
                                        int perimeter = r.GetPerimeter();
                                        Console.WriteLine("The Permiter of a Rectangle is: {0}", perimeter);
                                        break;

                                    case 6:
                                        Console.WriteLine("The \"Get Rectangle Area\" option is selected by the user");
                                        new_Rectangle_Length = r.SetLength(user_entered_length);
                                        new_Rectangle_Width = r.SetWidth(user_entered_width);
                                        int area = r.GetArea();
                                        Console.WriteLine("The Area of a Rectangle is: {0}", area);
                                        break;

                                    case 7:
                                        Console.WriteLine("Good Bye! See you soon...");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid menu option i.e. {0}", choice);
                                        Console.WriteLine("Please re-try with some valid input (i.e. between 1-7)");
                                        Console.WriteLine("----------------------------");
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("That's not a valid menu option i.e. {0}", choice);
                                Console.WriteLine("Please try again\n");
                            }
                        }
                            else 
                                Console.WriteLine("The width of a Rectangle can't be less than one\n");
                        }
                        else 
                            Console.WriteLine("The length of a Rectangle can't be less than one\n");
                 
                }
                while (choice != 1 || choice != 2 || choice != 3 || choice != 4 || choice != 5 ||
                        choice != 6 || choice != 7);
               // while (choice != 1 && choice != 7) ;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
