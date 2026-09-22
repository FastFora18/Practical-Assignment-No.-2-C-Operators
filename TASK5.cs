using System;

int x1 = 5;
x1 += 5;
Console.WriteLine(x1);

int a2 = 10;
a2 *= 2 + 3;
Console.WriteLine(a2);

int x3 = 12;
x3 >>= 2;
Console.WriteLine(x3);

int? x4 = null;
x4 ??= 42;
Console.WriteLine(x4);

string str = null;
str ??= "default";
str ??= "custom";
Console.WriteLine(str);

byte b6 = 1;
b6 += 2;
Console.WriteLine(b6);

int a7 = 5, b7 = 10, c7 = 0;
c7 = a7 = b7;
Console.WriteLine(c7);

int mask = 1;
mask <<= 3;
mask |= 2;
Console.WriteLine(mask);

int x9 = 15;
x9 %= 4;
Console.WriteLine(x9);

int defInt = default(int);
string? defStr = default(string);
Console.WriteLine($"{defInt} {(defStr == null ? "null" : defStr)}");