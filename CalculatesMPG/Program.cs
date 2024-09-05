
        // Declare variables to store input
        float milesDriven;
        float gallonsUsed;

        // Prompt the user to enter the number of miles driven
        Console.Write("Enter the number of miles driven: ");
        milesDriven = float.Parse(Console.ReadLine());

        // Ask the user to enter the amount of gasoline used (in gallons)
        Console.Write("Enter the amount of gasoline used: ");
        gallonsUsed = float.Parse(Console.ReadLine());

        // Calculating MPG
        double mpg = milesDriven / gallonsUsed;

        // Display the result
        Console.WriteLine("Mpg is {0} miles per gallon", mpg);


