

string exampleStr = "Something";

void ReverseString(string value)
{
    string reversedString = string.Empty;

    for(int i = value.Length - 1; i >= 0; i--)
    {
        reversedString += value[i];
    }

    Console.WriteLine("Reversed string: " + reversedString);
}
ReverseString(exampleStr);

void NumberOfVowels(string value)
{
    int vowelCounter = 0;
    for(int i = 0; i < value.Length; i++)
    {
        switch (value[i].ToString().ToLower())
        {
            case "a": vowelCounter++;
                break;            
            case "e": vowelCounter++;
                break;           
            case "i": vowelCounter++;
                break;            
            case "o": vowelCounter++;
                break;            
            case "u": vowelCounter++;
                break;           
        }
    }

    Console.WriteLine("Number of vowels: " + vowelCounter);
}
NumberOfVowels(exampleStr);

void IsPalindrome(string value)
{
    string reversedString = string.Empty;

    for (int i = value.Length - 1; i >= 0; i--)
    {
        reversedString += value[i];
    }

    if(value == reversedString)
    {
        Console.WriteLine($"Palindrom. ({value})");
    }
    else
    {
        Console.WriteLine($"Non-Palindrom. ({value})");
    }
}
IsPalindrome("noon");
IsPalindrome("noons");

void NumberOfWords(string value)
{
    int wordCounter = 1;

    foreach(var v in value)
    {
        if(v == ' ') 
            wordCounter++;
    }
    Console.WriteLine($"Number of words: {wordCounter} ({value})");
}
NumberOfWords("There was a house.");

Console.ReadKey();
