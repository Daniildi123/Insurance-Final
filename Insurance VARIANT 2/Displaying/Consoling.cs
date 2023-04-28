using Insurance_VARIANT_2.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_VARIANT_2.Displaying
{
    public static class Consoling
    {
        public static string WritingName()
        {
            Console.Write("Please enter your first name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        public static string WritingLastName()
        {
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string WritingCar()
        {
            Console.Write("Please enter the make of your car: ");
            string carMake = Console.ReadLine();
            return carMake;
        }

        public static string WritingAccidentCircumstances()
        {
            Console.Write("Please enter the circumstances of the accident: ");
            string accidentCircumstances = Console.ReadLine();
            return accidentCircumstances;
        }
        public static string WritingOfficerName()
        {
            Console.Write("Please enter the police officer's first name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        public static string WritingOfficerLastName()
        {
            Console.Write("Please enter the police officer's last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string WritingOfficerBadgeNumber()
        {
            Console.Write("Please enter the police officer's badge number: ");
            string officerBadgeNumber = Console.ReadLine();
            return officerBadgeNumber;
        }

        public static string WritingInsureName()
        {
            Console.Write("Please enter the name of the insurance company to file a claim with: ");
            string insuranceCompanyName = Console.ReadLine();
            return insuranceCompanyName;
        }

        public static string WritingInsurePhone()
        {
            Console.Write("Please enter the phone number of the insurance company: ");
            string insuranceCompanyPhoneNumber = Console.ReadLine();
            return insuranceCompanyPhoneNumber;
        }

        public static string WritingInsureAddress()
        {
            Console.Write("Please enter the address of the insurance company: ");
            string insuranceCompanyAddress = Console.ReadLine();
            return insuranceCompanyAddress;
        }

        public static void RecipeCheck(string firstName, string lastName, string carMake, string accidentCircumstances, string officerFirstName, string officerLastName, string officerBadgeNumber, List<Damage> damages, string insuranceCompanyName, string insuranceCompanyPhoneNumber, string insuranceCompanyAddress)
        {
            Console.WriteLine("Generating receipt...");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Insurance Compensation Receipt");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Victim Information:");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Car Make: {0}", carMake);
            Console.WriteLine("Accident Circumstances: {0}", accidentCircumstances);
            Console.WriteLine();
            Console.WriteLine("Police Officer Information:");
            Console.WriteLine("Name: {0} {1}", officerFirstName, officerLastName);
            Console.WriteLine("Badge Number: {0}", officerBadgeNumber);
            Console.WriteLine();
            Console.WriteLine("Damage Information:");
            foreach (var damage in damages)
            {
                Console.WriteLine("{0}: {1:C}", damage.PartName, damage.Cost);
            }
            Console.WriteLine();
            Console.WriteLine("Total Estimated Damage Cost: {0:C}", Calculation.CalculationDamages(damages));
            Console.WriteLine();
            Console.WriteLine("Insurance Company Information:");
            Console.WriteLine("Name: {0}", insuranceCompanyName);
            Console.WriteLine("Phone Number: {0}", insuranceCompanyPhoneNumber);
            Console.WriteLine("Address: {0}", insuranceCompanyAddress);
            Console.WriteLine("--------------------------------------------------");
        }

    }
}
