while (true)
{
    Console.WriteLine("Choose your options:");

    Console.WriteLine("1. Convert Celcius to Fahrenheit");
    Console.WriteLine("2. Convert Fehrenheit to Celcius");

    int choice_Options = 0;

    try
    {
        choice_Options = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.FormatException) { }


    switch (choice_Options)
    {
        case 1:
            Console.WriteLine("Enter Celcius temperature: ");
            int celciusBeforeFehren = Convert.ToInt32(Console.ReadLine());
            int fehrenAfterCelcius = (int)(celciusBeforeFehren * 1.8 + 32);
            Console.WriteLine("Your Fehrenheit temperature is: " + fehrenAfterCelcius);

            Thread.Sleep(500);

            Console.WriteLine("Do you wish to continue?");
            string continueOption1 = Console.ReadLine();
            if (continueOption1 == "Yes")
            {
                break;
            }
            else { return; }

        case 2:
            Console.WriteLine("Enter Fehrenheit temperature:");
            int fehrenBeforeCelcius = Convert.ToInt32(Console.ReadLine());
            int celciusAfterFehren0 = (int)(fehrenBeforeCelcius - 32);
            int celciusAfterFehren = (int)(celciusAfterFehren0 * 0.5556);
            Console.WriteLine("Your Celsius temperature is: " + celciusAfterFehren);

            Thread.Sleep(500);

            Console.WriteLine("Do you wish to continue?");
            string continueOption2 = Console.ReadLine();
            if (continueOption2 == "Yes")
            {
                break;
            }
            else { return; }

        default:
            Console.WriteLine("\nWrong choice.\n");
            break;
    }
}
