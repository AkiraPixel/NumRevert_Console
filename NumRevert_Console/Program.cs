// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Hello, World!");


int numToRevert = -12321;

bool resultPalindrome = ItsPalindrome(numToRevert);

Console.WriteLine($"Number {numToRevert} is palindrome = {resultPalindrome}");

static bool ItsPalindrome(int number)
{
    if (number < 0)
    {
        return false;
    }

    int temp = number;
    int currentNumber = 0;
    int stage;

    while (temp > 0)
    {
        stage = temp % 10;

        currentNumber = currentNumber * 10 + stage;

        temp = temp / 10;

    }

    return number.Equals(currentNumber);
}