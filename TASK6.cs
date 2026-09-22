using System;

int score = 75;
string res1 = score >= 60 ? "Pass" : "Fail";
Console.WriteLine(res1);

int x = 5;
int y = (x > 10) ? 100 : (x > 2) ? 50 : 0;
Console.WriteLine(y);

var task3Result = true ? 10 : 15.5;
Console.WriteLine(task3Result.GetType().Name.ToLower());

string? s4 = null;
Console.WriteLine(s4?.Length);

string? s = null;
Type typeOfLength = typeof(int?);
Console.WriteLine(typeOfLength);

string? name = null;
string res6 = name ?? "Anonymous";
Console.WriteLine(res6);

string? a = null, b = "User", c = "Admin";
string res7 = a ?? b ?? c;
Console.WriteLine(res7);

int res8 = false ? (10 / 1) : 42;
Console.WriteLine(res8);
Console.WriteLine("Нет / Ошибка компиляции");

int? count = null;
int res10 = count?.GetHashCode() ?? -1;
Console.WriteLine(res10);