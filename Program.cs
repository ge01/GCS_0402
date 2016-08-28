using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0402
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Named constants
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                // Local variables
                decimal hoursWorked;        // Number of hours worked
                decimal hourlyPayRate;      // Hourly pay rate
                decimal basePay;            // Pay not including overtime
                decimal overtimeHours;      // overtime hours worked
                decimal overtimePay;        // overtime pay
                decimal grossPay;           // total gross pay

                // Get the hours worked and hourly pay rate.
                Console.Write("Hours worked: ");
                hoursWorked = decimal.Parse(Console.ReadLine());

                Console.Write("Hourly pay rate: ");
                hourlyPayRate = decimal.Parse(Console.ReadLine());

                // Determine the gross pay.
                if (hoursWorked > BASE_HOURS)
                {
                    // Calculate the base pay (without overtime).
                    basePay = hourlyPayRate * BASE_HOURS;

                    // Calculate the number of overtime hours.
                    overtimeHours = hoursWorked - BASE_HOURS;

                    // Calculate the number of overtime hours.
                    overtimePay = overtimeHours * hourlyPayRate *
                        OT_MULTIPLIER;

                    // Calculate the gross pay.
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // Calculate the gross pay
                    grossPay = hoursWorked * hourlyPayRate;
                }

                // Display the gross pay.
                Console.WriteLine(grossPay.ToString("c"));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Display an error message.
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
