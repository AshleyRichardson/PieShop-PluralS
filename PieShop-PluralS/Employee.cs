using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShop_PluralS
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType employeeType;
        
        //constructors set the values of fields from above
        public Employee(string first, string last, string em, DateTime bd): this(first, last, em, bd, 0, EmployeeType.StoreManager)//uses a default for enum which is Store Manager
        {

        }
        public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType empType) 
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
            employeeType = empType;
        } 

        public void PerformWork()
        {
            //numOfHoursWorked++;
            //Console.WriteLine($"{firstName} {lastName} has worked for {numOfHoursWorked} hour(s)!");

            //invoke bottom method inside this method
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numOfHours)
        {
            numOfHoursWorked += numOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (numOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }


        //using out keyword
        //same as ref but argument does not need to be initialized in caller i.e bonusTax
        //parameter must be assigned before you exit the method
        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {

            bonusTax = 0; 
            if (numOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

            return bonus;
        }

        /*  public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
          {
              if (numOfHoursWorked > 10)
                  bonus *= 2;

              if(bonus >= 200)
               {
                  bonusTax = bonus / 10;
                  bonus -= bonusTax;
              }

              Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

              return bonusTax;
          }
        */

        //using a list of strings
        //practicing w/Using Statements as well
        public static void UsingACustomType()
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
        }

        //means converting current object to JSON string and passing it to SerializeObject method
        //need to install Neton.JSOFT
        /*public string ConvertToJson()
        {
            //"this" references current object
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        */


        public double ReceiveWage(bool resetHours = true)
        {
           if(employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager!");
                wage = numOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = numOfHoursWorked * hourlyRate;
            }

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numOfHoursWorked = 0;

            return wage;
        }

        /* public double ReceiveWage(bool resetHours = true)
         {
             wage = numOfHoursWorked * hourlyRate;

             Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numOfHoursWorked} hour(s) of work.");

             if(resetHours)
                 numOfHoursWorked = 0;

             return wage;
         }
        */
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail:\t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
    }
}
