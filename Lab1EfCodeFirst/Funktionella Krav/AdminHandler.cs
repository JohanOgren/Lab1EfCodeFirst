using Lab1EfCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1EfCodeFirst.Funktionella_Krav
{
    public class AdminHandler
    {
         EmployeeRegister context = new EmployeeRegister();

        public void AdminInformation()
        {
            try
            {
                Console.Write("in between wich dates do you want to search on?\n");
                Console.Write("DateFrom: ");
                DateTime dateFrom = Convert.ToDateTime(Console.ReadLine());
                Console.Write("DateTo: ");
                DateTime dateTo = Convert.ToDateTime(Console.ReadLine());

                var getNamez = context.Employess.ToList();
                var adminHistoryForms = context.LeaveForms.Where(p => p.DateFrom >= dateFrom && p.DateTo <= dateTo).ToList();
                
                foreach (var item in adminHistoryForms) 
                {
                    Console.WriteLine($"\nName :{item.Employee.FirstName} {item.Employee.LastName}");
                    Console.WriteLine($"\nDateRegister [{item.DateOfRegister}]\nStartDate [{item.DateFrom.ToString("dd/MM/yyyy")}]\nEndDate [{item.DateTo.ToString("dd/MM/yyyy")}]" +
                        $"\nTotal days of leave [{ (item.DateTo - item.DateFrom).TotalDays}]"); 
                    Console.WriteLine("----------------------------------");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                
            }
        }
    }
}
