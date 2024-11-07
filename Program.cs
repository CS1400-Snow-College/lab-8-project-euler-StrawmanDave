/// David Barlow 11/4/24 Project Euler

/// The first challenge I would like to do is the Multiples of 3 or 5
/// This Program should go through whatever number you give find the multples of 5 and 3 then add them together.

/// The second challenge I would like ot do is the Largest Prime factor
/// This programs should go through whatever number you give it find the factors
/// Then it should determine whether they are prime
/// Then witch one is the largest

/// The third challenge I would like to do is the Sum Square Difference 
/// Takes 1 numbers and squares each number up to that numbers
/// It adds each number up then finds the squar and it also finds the squar of each number then addes them up.

/// The fourth challenge I would like to do is the 10001st Prime
/// Takes a number and spits out the nth prime.
using System.Diagnostics;
string challengeMenu = @"
1.(Multiples of 3 or 5) 
This program will take a number you give it find all the multiples of 4 and 3 then add them together and return the sum.

2.(Largest Prime factor)
This progarm will find the factors of a number you give it. Then it will elimnate the non-prime numbers. Then it will return the largest one.

3.(Sum Squar Difference)
This program takes in 2 numbers and squares each number up to both numbers and adds them. Then it subtracts each sum and returns the value.

4.(10001st Prime)
This program takes a number and spits out the number nth prime that you gave it. 
";

startMenu();
//FindnPrime();

void startMenu()
{
Console.Clear();
Console.Write(challengeMenu);
Console.WriteLine();
Console.Write("Witch program would you like to use? Pick by choosing a number. ");
long chooseNum = ReadNumber();
    switch (chooseNum)
    {
        case 1:
        FiveAndThreeMultiples();
        break;
        case 2:
        LargestPrimeFactor();
        break;
        case 3:
        squarDifference();
        break;
        case 4:
        FindnPrime();
        break;
        default:
        Console.WriteLine("That number is not on the list. ");
        break;
    }
}

// FiveAndThreeMultiples();

void FiveAndThreeMultiples()
{
    Console.Clear();
    Console.Write("What number would you like to know all the multiples of 5 and 3 added up? ");
    long maxNumber = ReadNumber();

    int three = 0;
    int five = 0;
    for(int i = 0; i<maxNumber; i +=3)
    {
        //Console.Write($"{i} ");
        three = i + three;
    }

    // Console.Write($"multiples of three added up are {three} ");
    // Console.WriteLine();

    for(int j = 0; j<maxNumber; j +=5)
    {
        //Console.Write($"{j} ");
        five = j + five;
    }
    // Console.Write($"multiples of five added up are {five} ");
    int output = five + three;
    // Console.WriteLine();
    Console.Write($"All the multiples of 5 and 3 added up are {output}.");
    Console.WriteLine();
}

// LargestPrimeFactor();

void LargestPrimeFactor()
{
    Console.Clear();
    long factor = 0;
    long primeFactor = 0;
    Console.Write("What number would you like to find the Largest Prime factor of? ");
    long numToFactor = ReadNumber();

    double squarFactor = Math.Sqrt(numToFactor);

    for(long i = 2; i <= squarFactor; i++)
    {
        //Console.Write($"{i} ");
        if(numToFactor % i == 0)
        {
            factor  = i;
            // Console.Write($"{factor} ");
            // Console.WriteLine(); 
            if(isPrime(factor) == true)
            {
                primeFactor = factor;
                Console.Write($"{factor} ");
            }
        }
    }
    long biggestPrime = primeFactor;
    Console.Write($"The biggest prime is {biggestPrime}");
    Console.WriteLine();
}

// squarDifference();

void squarDifference ()
{
    Console.Clear();
    Console.Write("What number would you like to find the Sum Squar Difference of? ");
    long num1 = ReadNumber();
    long added1 = 0;
    long added2 = 0;
    long firstNumSquar;
    long difference = 1;
    for(int i = 1; i<= num1; i++)
    {
        firstNumSquar = i * i;
        added1 = firstNumSquar + added1;
        //Console.Write($"{added1} ");
    }
    //firstNumSquar = firstNumSquar + firstNumSquar;

    for(int j = 1; j<= num1; j++)
    {
        added2 = added2 + j;
        //Console.Write($"{added2} ");
    }
    difference = (added2 * added2) - added1;
    Console.Write(difference);
    Console.WriteLine();
}

void FindnPrime()
{
    Console.Clear();
    Console.Write("What nth prime would you like to find? ");
    long nth = ReadNumber();
    long i = 1;
    long x = 0;
    long nthPrime = i;
    //look for a prime until you get the nth one.
    do
    {
        i++;
        if(isPrime(i) == true)
        {
            x++;
            if(x > nth)
            {
                break;
            }
            //Console.Write($"{i} ");
            nthPrime = i;
        } //nth times break
    }
    while(true);

Console.Write(nthPrime);
Console.WriteLine();
}

bool isPrime (long num)
{
    double squar = Math.Sqrt(num);
    for(int i = 2; i <= squar; i++)
    {
        if(num % i == 0)
            return false;
    }
    return true;
}

long ReadNumber()
{
    while(true)
    {
        long holder = 0;
        //Console.Write("Please Enter a number ");
        string num = Console.ReadLine();

        bool isNum = long.TryParse(num, out holder);
        if(isNum == false) // Checks if the user put in a number
        {
            Console.WriteLine("That was not a number try again");
        }else
        {
            long number = Convert.ToInt64(num);
            return number;
        }
    }
}