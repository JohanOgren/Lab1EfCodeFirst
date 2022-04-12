using Lab1EfCodeFirst.Funktionella_Krav;
using Lab1EfCodeFirst.Models;
using System;
using System.Linq;

namespace Lab1EfCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddNewForm newForm = new AddNewForm();
            AdminHandler admin = new AdminHandler();
            GetPersonInformation personInfo = new GetPersonInformation();

            bool fortsätt = true;
            while (fortsätt)
            {
                Console.WriteLine("Press 1 to add new Leave form -- Press 2 for Person Information -- Press 3 for Administrator -- Press 4 to exit program");
                try
                {
                    int val = int.Parse(Console.ReadLine());
                    switch (val)
                    {
                        case 1:

                            newForm.NewForm();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            personInfo.GetPerson();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            admin.AdminInformation();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            fortsätt = false;
                            Console.WriteLine("Goodbye");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error can not do that.");
                    return;
                }
               
            }
        }
    }
}
