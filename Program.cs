using System;

int x = 17 / 5;
int y = 17 % 5;
Console.WriteLine($"{x}, {y}");

int a1 = 5;
int res1 = ++a1 * 2;
Console.WriteLine($"{res1} ({a1})");

int a2 = 5;
int res2 = a2++ * 2;
Console.WriteLine($"{res2} ({a2})");

int divInt = 7 / 2;
double divDouble = 7.0 / 2;
Console.WriteLine($"{divInt}, {divDouble}");

int remNegative = -15 % 4;
Console.WriteLine(remNegative);

int x2 = 10;
x2 = x2++ + ++x2;
Console.WriteLine(x2);

try { int max = int.MaxValue; int res = checked(max + 1); }
catch (OverflowException ex) { Console.WriteLine(ex.GetType().Name); }

int maxUnchecked = int.MaxValue;
int resUnchecked = unchecked(maxUnchecked + 1);
Console.WriteLine(resUnchecked);

double inf = 1.0 / 0.0;
double nan = 0.0 / 0.0;
Console.WriteLine($"{inf}, {nan}");

int a = 8, b = 3;
int c = a - b * 2 + a / b;
Console.WriteLine(c);