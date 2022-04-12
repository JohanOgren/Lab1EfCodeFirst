using Lab1EfCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab1EfCodeFirst.Funktionella_Krav
{
    public class GetPersonInformation
    {
        EmployeeRegister context = new EmployeeRegister();

        public void GetPerson()
        {
            try
            {
                Console.WriteLine("which Person do you want to get info about");
                Console.Write("FirstName: ");
                string personName = Console.ReadLine();

                var leaveForm = from p in context.Employess
                                where p.FirstName == personName
                                orderby p.FirstName
                                select p.LeaveForms;
                Console.WriteLine($"\nThese are the confirmed away from work forms for this person ");
                foreach (var item in leaveForm)
                {
                    foreach (var i in item)
                    {

                        Console.WriteLine($"\n--Reason {i.Reason} --[From {i.DateFrom.ToString("dd/MM/yyyy")}] --[To {i.DateTo.ToString("dd/MM/yyyy")}]--");
                    }
                    
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                return;
            }

        }
    }
}
