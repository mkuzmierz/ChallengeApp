string inputNumber = "4594";
int[] counts = new int[10];

foreach(char digit in inputNumber)
{
    if(char.IsDigit(digit))
    {
        int digitValue = digit - '0';
        counts[digitValue]++;
    }
}

for (int i = 0; i < 10; i++)

    if (counts[i] > 0)
    {
        Console.WriteLine($"Digit {i} occurs {counts[i]} times");
    }
