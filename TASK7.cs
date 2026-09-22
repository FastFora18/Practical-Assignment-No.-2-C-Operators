using System;

object obj1 = "Hello";
bool check1 = obj1 is string;
Console.WriteLine(check1);

object obj2 = 123;
string? s2 = obj2 as string;
Console.WriteLine(s2 == null ? "null" : s2);

try
{
    object obj3 = 123;
    string s3 = (string)obj3;
}
catch (InvalidCastException ex)
{
    Console.WriteLine(ex.GetType().Name);
}

Console.WriteLine(typeof(int) == typeof(Int32));

Console.WriteLine(sizeof(long));

Console.WriteLine(null is string);

object? x7 = null;
bool b7 = x7 is null;
Console.WriteLine(b7);

Console.WriteLine((int)3.99);

object o9 = 42;
bool blockExecuted = false;
if (o9 is int val && val > 40)
{
    blockExecuted = true;
}
Console.WriteLine(blockExecuted);