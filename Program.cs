while (true)
{
    string userEnteredString = String.Empty;

    while (string.IsNullOrWhiteSpace(userEnteredString))
    {
        Console.Write("Please, enter any string (no empty or just spaces):");
        userEnteredString = Console.ReadLine();
    }

    string trimmedUserEnteredString = userEnteredString.Trim();

    int userEnteredStringLenght = trimmedUserEnteredString.Length;

    Console.Write($"You've entered string: '{trimmedUserEnteredString}' which lenght is " +
        $"{userEnteredStringLenght} {(userEnteredStringLenght > 1 ? "characters (incl spaces)" : "character")}.");
    Console.WriteLine();
}

//Just to check if 'Build the console app' GitHub action starts after push the commit with this test change
