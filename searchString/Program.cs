namespace searchString
{
    internal class Program
    {
        public static string theString = "29535123p48723487597645723645";

        static void Main()
        {
            List<string> validStrings = new List<string>();
            char[] characters = theString.ToCharArray();

            for (int i = 0; i < theString.Length; i++)
            {
                if (Char.IsDigit(characters[i]))
                {
                    string currentSubstring = "";
                    int startIndex = i;

                    for (int j = i; j < theString.Length; j++)
                    {
                        if (Char.IsDigit(characters[j]))
                        {

                            if (currentSubstring.Length == 0)
                            {
                                startIndex = j;
                            }

                            currentSubstring += characters[j];

                            if (currentSubstring.Length > 1 && currentSubstring[0] == characters[j])
                            {
                                validStrings.Add(currentSubstring);
                                if (startIndex > 0)
                                {
                                    Console.Write(theString.Substring(0, startIndex));
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(currentSubstring);
                                Console.ResetColor();
                                Console.Write(theString.Substring(j + 1));
                                Console.WriteLine();
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            long totalSum = 0;

            foreach (string validString in validStrings)
            {
                if (long.TryParse(validString, out long number))
                {
                    totalSum += number;
                }
            }

            Console.WriteLine($"Total Sum: {totalSum}");
        }
    }
}
