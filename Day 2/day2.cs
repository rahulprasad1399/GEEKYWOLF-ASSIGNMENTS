// Print first 20 numbers using for loop
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}


// Print odd numbers less than 50 using while loop
int number = 1;
while (number <= 50)
{
    if (number % 2 != 0)
    {
        Console.WriteLine(number);
    }
    number++;
}


// Large amount 3 numbers
Console.WriteLine("Enter the 1st Number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2nd Number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3rd Number");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The larger number is : ");
if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine(num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}


// Reverse of a number
Console.WriteLine("Enter the Number to be reversed : ");
string numberToBeReversed = Console.ReadLine();
string reversedNumber = "";
int i = numberToBeReversed.Length - 1;

while (i >= 0)
{
    reversedNumber = reversedNumber + numberToBeReversed[i];
    i--;
}
Console.WriteLine("The reversed number is :");
Console.WriteLine(reversedNumber);


//Sum of the digits of a number
Console.WriteLine("Enter the Number :");
string stringNumber = Console.ReadLine();
int sumOfDigits = 0;
int i = 0;

while (i < stringNumber.Length)
{
    sumOfDigits = sumOfDigits + Convert.ToInt32(stringNumber[i].ToString());
    i++;
}
Console.WriteLine(sumOfDigits);


// Check prime number
Console.WriteLine("Enter a Number to check whether it is prime or not");
int userEnteredNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 1;
while (i < (userEnteredNumber / 2))
{
    if (userEnteredNumber % i == 0)
    {
        count = count + 1;
    }
    i++;
}

if (count == 1)
{
    Console.WriteLine("Prime Number");
}
else
{
    Console.WriteLine("Not a Prime Number");
}


// Print all prime numbers below 100
for (int i = 2; i < 100; i++)
{
    int count = 0;
    for (int j = 2; j <= (i / 2); j++)
    {
        if (i % j == 0)
        {
            count = count + 1;
            break;
        }
    }
    if (count == 0)
    {
        Console.WriteLine(i);
    }
}


// Fibonacci series
int num1 = 0;
int num2 = 1;
Console.WriteLine("Enter the Number :");
int limit = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (limit == 0)
{
    Console.WriteLine("Print a positive number");
}
else if (limit == 1)
{
    Console.WriteLine("Fibonacci series is :");
    Console.WriteLine(num1);
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Fibonacci series is :");
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    while (i < limit)
    {
        int sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.WriteLine(sum);
        i++;
    }
}


// Tax calculation program, input the amount and display the tax
int amount = Convert.ToInt32(Console.ReadLine());
switch (amount)
{
    case <= 10000:
        Console.WriteLine("5% tax");
        break;
    case > 10000 and <= 15000:
        Console.WriteLine("7.5% tax");
        break;
    case > 15000 and <= 20000:
        Console.WriteLine("10% tax");
        break;
    case > 20000 and <= 25000:
        Console.WriteLine("12.5% tax");
        break;
    case >= 25000:
        Console.WriteLine("15% tax");
        break;
}


// Input a character from console and display the sports name corresponding to it
Console.WriteLine("Please Enter a Character. \nThe Available Characters are c, f, h, t, b");
string str1 = Console.ReadLine();
switch (str1)
{
    case "c":
        Console.WriteLine("Cricket");
        break;
    case "f":
        Console.WriteLine("Football");
        break;
    case "h":
        Console.WriteLine("Hockey");
        break;
    case "t":
        Console.WriteLine("Tennis");
        break;
    case "b":
        Console.WriteLine("Badminton");
        break;
    default:
        Console.WriteLine("Enter a valid character");
        break;
}