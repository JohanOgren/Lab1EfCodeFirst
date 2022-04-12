using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1EfCodeFirst.Models
{
    public class AddNewForm
    {
        EmployeeRegister context = new EmployeeRegister();
        public void NewForm()
        {
            try
            {

                var getNames = from n in context.Employess
                               select n.FirstName;

                Console.WriteLine("Who are you?..");
                foreach (var item in getNames)
                {
                    Console.Write($"[{item}]\n");
                }
                Console.Write("Name: ");
                string readName = Console.ReadLine();

                Console.Write("Reason you need to stay away from work? :");
                Console.WriteLine("Sick - Childcare - Vacation - Other");
                string Reason = Console.ReadLine();
                if (Reason == "sick")
                {
                    string leaveReason = "Sick";
                    Console.WriteLine("What date do you need to be away from work?");

                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateFrom :");
                    string DateFrom = Console.ReadLine();

                    Console.WriteLine("What Date do you plan on coming back?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateTo :");
                    string DateTo = Console.ReadLine();
                    Console.Clear();

                    var datum = DateFrom.Split(",");
                    var datum2 = DateTo.Split(",");
                    Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
                    context.LeaveForms.Add(new LeaveForm
                    {
                        Reason = leaveReason,
                        DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
                        DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
                        DateOfRegister = DateTime.Now,
                        Employee = employee
                    });
                    context.SaveChanges();
                    Console.WriteLine("Your Leave Form have been accepted");
                    
                }
                else if (Reason == "Childcare")
                {
                    string leaveReason = "Childcare";
                    Console.WriteLine("What date do you need to be away from work?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateFrom :");
                    string DateFrom = Console.ReadLine();

                    Console.WriteLine("What Date do you plan on coming back?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateTo :");
                    string DateTo = Console.ReadLine();
                    Console.Clear();

                    var datum = DateFrom.Split(",");
                    var datum2 = DateTo.Split(",");
                    Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
                    context.LeaveForms.Add(new LeaveForm
                    {

                        Reason = leaveReason,

                        DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
                        DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
                        DateOfRegister = DateTime.Now,
                        Employee = employee
                    });
                    context.SaveChanges();
                    Console.WriteLine("Your Leave Form have been accepted");
                }
                else if (Reason == "Vacation")
                {
                    string leaveReason = "Vacation";
                    Console.WriteLine("What date do you need to be away from work?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateFrom :");
                    string DateFrom = Console.ReadLine();

                    Console.WriteLine("What Date do you plan on coming back?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateTo :");
                    string DateTo = Console.ReadLine();
                    Console.Clear();

                    var datum = DateFrom.Split(",");
                    var datum2 = DateTo.Split(",");
                    Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
                    context.LeaveForms.Add(new LeaveForm
                    {

                        Reason = leaveReason,

                        DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
                        DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
                        DateOfRegister = DateTime.Now,
                        Employee = employee
                    });
                    context.SaveChanges();
                    Console.WriteLine("Your Leave Form have been accepted");
                }
                else if (Reason == "Other")
                {

                    string leaveReason = "Other";
                    Console.WriteLine("What date do you need to be away from work?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateFrom :");
                    string DateFrom = Console.ReadLine();

                    Console.WriteLine("What Date do you plan on coming back?");
                    Console.WriteLine("Write in the date like 2022,01,01");
                    Console.WriteLine("Press Enter when done");
                    Console.Write("DateTo :");
                    string DateTo = Console.ReadLine();
                    Console.Clear();

                    var datum = DateFrom.Split(",");
                    var datum2 = DateTo.Split(",");
                    Employee employee = context.Employess.FirstOrDefault(c => c.FirstName == readName);
                    context.LeaveForms.Add(new LeaveForm
                    {

                        Reason = leaveReason,

                        DateFrom = new DateTime(int.Parse(datum[0]), int.Parse(datum[1]), int.Parse(datum[2])).Date,
                        DateTo = new DateTime(int.Parse(datum2[0]), int.Parse(datum2[1]), int.Parse(datum2[2])).Date,
                        DateOfRegister = DateTime.Now,
                        Employee = employee
                    });
                    context.SaveChanges();
                    Console.WriteLine("Your Leave Form have been accepted");
                }
                else
                {
                    Console.WriteLine("Invalid Reason or Name doesnt exist...Try again");
                    Console.ReadKey();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please try again.");
                
                throw;
            }

        }
    }
}
