﻿/// David Barlow 11/4/24 Project Euler

/// The first challenge I would like to do is the Multiples of 3 or 5
/// This Program should go through whatever number you give find the multples of 5 and 3 then add them together.

/// The second challenge I would like ot do is the Largest Prime factor
/// This programs should go through whatever number you give it find the factors
/// Then it should determine whether they are prime
/// Then witch one is the largest

/// The third challenge I would like to do is the Sum Square Difference 
/// Takes 2 numbers and squares each number up to those numbers
/// Then subtracts the first from the second

/// The fourth challenge I would like to do is the 10001st Prime
/// Takes a number and spits out the nth prime.

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

Console.Clear();
Console.Write(challengeMenu);
Console.WriteLine();
Console.Write("Witch program would you like to use?");
Console.WriteLine();