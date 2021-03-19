using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            List<string> units = new List<string>(new string[] { "inch", "foot", "fidgetspinner", "meme" });
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Units Allowed: inch, fidgetspinner, foot, meme");
                    Console.WriteLine("Please enter a number with unit in format: [number] [unit]");
                    string input = Console.ReadLine();
                    string[] inputs = input.Split('');
                    double number = Convert.ToDouble(inputs[0]);
                    string inputUnit = inputs[1].ToLower();
                    Console.WriteLine("Please enter a unit to convert to:");
                    string outputUnit = Console.ReadLine().ToLower();

                    if (!(units.Contains(inputUnit) && units.Contains(outputUnit) && number >= 0.0))
                    {
                        Console.WriteLine("Invalid Inputs!");
                        Console.WriteLine("Enter Number Greater than 0.0 and Units should be correctly spelled as shown.");
                        continue;
                    }

                    if (outputUnit.Contains("fidgetspinner") && inputUnit.Contains("inch"))
                    {
                        Console.WriteLine(InchesToFidgetSpinners(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("fidgetspinner") && inputUnit.Contains("foot"))
                    {
                        Console.WriteLine(FeetToFidgetSpinners(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("meme") && inputUnit.Contains("inch"))
                    {
                        Console.WriteLine(InchesToMemes(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("meme") && inputUnit.Contains("foot"))
                    {
                        Console.WriteLine(FeetToMemes(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("foot") && inputUnit.Contains("inch"))
                    {
                        Console.WriteLine(InchesToFeet(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("inch") && inputUnit.Contains("foot"))
                    {
                        Console.WriteLine(FeetToInches(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("inch") && inputUnit.Contains("fidgetspinner"))
                    {
                        Console.WriteLine(FidgetSpinnersToInches(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("inch") && inputUnit.Contains("meme"))
                    {
                        Console.WriteLine(MemesToInches(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("foot") && inputUnit.Contains("meme"))
                    {
                        Console.WriteLine(MemesToFeet(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("foot") && inputUnit.Contains("fidgetspinner"))
                    {
                        Console.WriteLine(FidgetSpinnersToFeet(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("meme") && inputUnit.Contains("fidgetspinner"))
                    {
                        Console.WriteLine(FidgetSpinnersToMemes(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains("fidgetspinner") && inputUnit.Contains("meme"))
                    {
                        Console.WriteLine(MemesToFidgetSpinners(number) + " " + outputUnit);
                    }
                    else if (outputUnit.Contains(inputUnit) || inputUnit.Contains(outputUnit))
                    {
                        Console.WriteLine("I was made for a greater purpose.... Anyways:");
                        Console.WriteLine(number + " " + outputUnit);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error found, did you give correct inputs?");
                }
                finally
                {

                    Console.WriteLine("Would you like to do more calculations? enter yes/no");
                    string affirmation = Console.ReadLine().ToLower();
                    if (!affirmation.Contains("yes"))
                    {
                        isRunning = false;
                    }
                }
                
                
            }
        }

        private static double InchesToFidgetSpinners(double inches)
        {
            return inches * 3.5;
        }

        private static double FidgetSpinnersToInches(double fidgetSpinners)
        {
            return fidgetSpinners/3.5;
        }

        private static double InchesToFeet(double inches)
        {
            return inches * 0.0833333;
        }

        private static double FeetToInches(double feet)
        {
            return feet / 0.0833333;
        }

        private static double FeetToMemes(double feet)
        {
            return feet * 5;
        }

        private static double MemesToFeet(double memes)
        {
            return memes / 5;
        }

        private static double InchesToMemes(double inches)
        {
            return FeetToMemes(InchesToFeet(inches));
        }

        private static double MemesToInches(double memes)
        {
            return FeetToInches(MemesToFeet(memes));
        }

        private static double FeetToFidgetSpinners(double feet)
        {
            return FidgetSpinnersToInches(FeetToInches(feet));
        }

        private static double FidgetSpinnersToFeet(double fidgetSpinners)
        {
            return InchesToFeet(FidgetSpinnersToInches(fidgetSpinners));
        }

        private static double FidgetSpinnersToMemes(double fidgetSpinners)
        {
            return FeetToMemes(FidgetSpinnersToFeet(fidgetSpinners));
        }

        private static double MemesToFidgetSpinners(double memes)
        {
            return InchesToFidgetSpinners(MemesToInches(memes));
        }

    }
}
