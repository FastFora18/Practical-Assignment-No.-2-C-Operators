using System;

int bitAnd = 5 & 3;
Console.WriteLine(bitAnd);

int bitOr = 5 | 3;
Console.WriteLine(bitOr);

int bitXor = 5 ^ 3;
Console.WriteLine(bitXor);

int bitNot = ~0;
Console.WriteLine(bitNot);

int bitShift = 1 << 4;
Console.WriteLine(bitShift);

int bitShiftRight = 40 >> 2;
Console.WriteLine(bitShiftRight);

int n37 = 15;
bool hasBit3 = (n37 & (1 << 3)) != 0;
Console.WriteLine(hasBit3);

int n38 = 0;
n38 |= (1 << 2);
Console.WriteLine(n38);

int n39 = 16;
n39 &= ~(1 << 4);
Console.WriteLine(n39);

int bitShiftNegative = (-16) >> 2;
Console.WriteLine(bitShiftNegative);