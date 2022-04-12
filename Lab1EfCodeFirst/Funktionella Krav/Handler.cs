using Lab1EfCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1EfCodeFirst.Funktionella_Krav
{
    public class Handler
    {
        //EmployeeRegister context = new EmployeeRegister();
        //public void AddNewForm()
        //{
        //    try
        //    {
        //        Console.Write("Who are you?.. First Name please :");
        //        string readName = Console.ReadLine();

        //        Console.Write("Reason you need to stay away from work? :");
        //        Console.WriteLine("Sick - Childcare - Vacation - Other");
        //        string Reason = Console.ReadLine();
        //        if (Reason == "Sick")
        //        {
        //             string leaveReason = "Sick";
        //            Console.WriteLine("What date do you need to be away from work?");

        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateFrom :");
        //            string DateFrom = Console.ReadLine();
        //            Console.Clear();

        //            Console.WriteLine("What Date do you plan on coming back?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateTo :");
        //            string DateTo = Console.ReadLine();
        //            Console.Clear();

        //            var datum = DateFrom.Split(",");
        //            var datum2 = DateTo.Split(",");
        //            Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
        //            context.LeaveForms.Add(new LeaveForm
        //            {

        //                Reason = leaveReason,

        //                DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
        //                DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
        //                DateOfRegister = DateTime.Now,
        //                Employee = employee
        //            });
        //            context.SaveChanges();
        //            Console.WriteLine("Your Leave Form have been accepted");
        //            Console.WriteLine("Goodbye.");
        //        }
        //        else if (Reason == "Childcare")
        //        {
        //            string leaveReason = "Childcare";
        //            Console.WriteLine("What date do you need to be away from work?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateFrom :");
        //            string DateFrom = Console.ReadLine();
        //            Console.Clear();

        //            Console.WriteLine("What Date do you plan on coming back?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateTo :");
        //            string DateTo = Console.ReadLine();
        //            Console.Clear();

        //            var datum = DateFrom.Split(",");
        //            var datum2 = DateTo.Split(",");
        //            Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
        //            context.LeaveForms.Add(new LeaveForm
        //            {

        //                Reason = leaveReason,

        //                DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
        //                DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
        //                DateOfRegister = DateTime.Now,
        //                Employee = employee
        //            });
        //            context.SaveChanges();
        //            Console.WriteLine("Your Leave Form have been accepted");
        //            Console.WriteLine("Goodbye.");
        //        }
        //        else if (Reason == "Vacation")
        //        {
        //            string leaveReason = "Vacation";
        //            Console.WriteLine("What date do you need to be away from work?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateFrom :");
        //            string DateFrom = Console.ReadLine();
        //            Console.Clear();

        //            Console.WriteLine("What Date do you plan on coming back?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateTo :");
        //            string DateTo = Console.ReadLine();
        //            Console.Clear();

        //            var datum = DateFrom.Split(",");
        //            var datum2 = DateTo.Split(",");
        //            Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
        //            context.LeaveForms.Add(new LeaveForm
        //            {

        //                Reason = leaveReason,

        //                DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
        //                DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
        //                DateOfRegister = DateTime.Now,
        //                Employee = employee
        //            });
        //            context.SaveChanges();
        //            Console.WriteLine("Your Leave Form have been accepted");
        //            Console.WriteLine("Goodbye.");
        //        }
        //        else if (Reason == "Other")
        //        {

        //            string leaveReason = "Other";
        //            Console.WriteLine("What date do you need to be away from work?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateFrom :");
        //            string DateFrom = Console.ReadLine();
        //            Console.Clear();

        //            Console.WriteLine("What Date do you plan on coming back?");
        //            Console.WriteLine("Write in the date like 2022,01,01");
        //            Console.WriteLine("Press Enter when done");
        //            Console.Write("DateTo :");
        //            string DateTo = Console.ReadLine();
        //            Console.Clear();

        //            var datum = DateFrom.Split(",");
        //            var datum2 = DateTo.Split(",");
        //            Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
        //            context.LeaveForms.Add(new LeaveForm
        //            {

        //                Reason = leaveReason,

        //                DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
        //                DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
        //                DateOfRegister = DateTime.Now,
        //                Employee = employee
        //            });
        //            context.SaveChanges();
        //            Console.WriteLine("Your Leave Form have been accepted");
        //            Console.WriteLine("Goodbye.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid Reason...Try again");
        //        }
                
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Invalid input. Please try again.");
        //        return;
        //        throw;
        //    }
            
        //}




        //public void GetPerson()
        //{
        //    try
        //    {
        //        Console.Write("Witch Person do you want to get info about");
        //        Console.Write("FirstName: ");
        //        string personName = Console.ReadLine();

        //        var leaveForm = from p in context.Employess
        //                              where p.FirstName == personName
        //                              orderby p.FirstName
        //                              select p.LeaveForms;
        //        Console.WriteLine($"These are the confirmed away from work forms for this person ");
        //        foreach (var item in leaveForm)
        //        {
        //            foreach (var i in item)
        //            {
                        
        //                Console.WriteLine($"Reason {i.Reason} [From {i.DateFrom.ToString("dd/mm/yyyy")}] [To {i.DateTo.ToString("dd/mm/yyyy")}]" );
        //            }
        //            //Console.WriteLine($"Id: {item.EmployeeID}");
        //            //Console.WriteLine($"FirstName: {item.FirstName}");
        //            //Console.WriteLine($"LastName: {item.LastName}");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
            
        //}
        //public void AdminHandler()
        //{



        //    try
        //    {
        //        Console.Write("in between wich dates do you want to search on?");
        //        Console.Write("DateFrom: ");
                
        //        DateTime dateFrom = Convert.ToDateTime(Console.ReadLine());
        //        DateTime dateTo = Convert.ToDateTime(Console.ReadLine());
        //        var adminHistoryForms = context.LeaveForms.Where(p => p.DateFrom >= dateFrom && p.DateTo < dateTo).ToList();
        //        TimeSpan interval = dateFrom - dateTo;
                
        //        foreach (var item in adminHistoryForms)
        //        {
        //            Console.WriteLine($"Person ID:{item.LeaveFormID}\nDateRegister [{item.DateOfRegister}]\nStartDate [{item.DateFrom.ToString("dd/mm/yyyy")}]\nEndDate [{item.DateTo.ToString("dd/mm/yyyy")}]" +
        //                $"\nTotal days of leave [{ (item.DateFrom - item.DateTo).TotalDays}]");
        //            Console.WriteLine("-----------------------------\n");
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
