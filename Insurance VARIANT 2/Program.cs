using System;
using System.Collections.Generic;
using System.Linq;
using Insurance_VARIANT_2.Company;
using Insurance_VARIANT_2.Human;
using Insurance_VARIANT_2.Calculations;
using Insurance_VARIANT_2.Displaying;

namespace Insurance_VARIANT_2
{

    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Insurance Compensation Calculator!");

                Injured injured = new Injured()
                {
                    Name = Consoling.WritingName(),
                    LastName = Consoling.WritingLastName(),
                    CarName = Consoling.WritingCar(),
                    AccidentCircumstances = Consoling.WritingAccidentCircumstances(),
                };

                Police police = new Police()
                {
                    Name = Consoling.WritingOfficerName(),
                    LastName = Consoling.WritingOfficerLastName(),
                    OfficerBadgeNumber = Consoling.WritingOfficerBadgeNumber()
                };

                List<Damage> damages = new List<Damage>();
                bool doneAddingDamages = false;

                while (!doneAddingDamages)
                {
                    Console.Write("Please enter the damaged part of the car (or 'done' to finish): ");
                    string partName = Console.ReadLine();

                    if (partName.ToLower() == "done")
                    {
                        doneAddingDamages = true;
                    }
                    else
                    {
                        Console.Write("Please enter the estimated cost to repair the {0}: ", partName);
                        decimal partCost;
                        if (!decimal.TryParse(Console.ReadLine(), out partCost))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid decimal value.");
                            continue;
                        }

                        damages.Add(new Damage(partName, partCost));
                    }
                }
              

                Console.WriteLine("The total estimated cost of damages is: {0:C}", Calculation.CalculationDamages(damages));

                InsuranceCompany insuranceCompany = new InsuranceCompany()
                {
                    CompanyName = Consoling.WritingInsureName(),
                    CompanyAddress = Consoling.WritingInsureAddress(),
                    CompanyPhoneNumber = Consoling.WritingInsurePhone()
                };

                Console.WriteLine();

                Consoling.RecipeCheck(injured.Name, injured.LastName, injured.CarName, injured.AccidentCircumstances, police.Name, police.LastName, police.OfficerBadgeNumber, damages, insuranceCompany.CompanyName, insuranceCompany.CompanyAddress, insuranceCompany.CompanyPhoneNumber);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

    
}