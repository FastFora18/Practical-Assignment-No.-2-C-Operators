using System;

bool comp1 = 5 > 3;
bool comp2 = 5 >= 5;
Console.WriteLine($"{comp1}, {comp2}");

bool strEqual = "hello" == "hello";
Console.WriteLine(strEqual);

bool nanEqual = double.IsNaN == double.IsNaN;
Console.WriteLine(nanEqual);

object objA = new int[] { 1 };
object objB = new int[] { 1 };
bool objEqual = objA == objB;
Console.WriteLine(objEqual);

bool doubleEqual = 10 != 10.0;
Console.WriteLine(doubleEqual);

bool nullComp = null == null;
Console.WriteLine(nullComp);

bool exprComp = (3 < 5) == (10 >= 20);
Console.WriteLine(exprComp);

bool resAnd = 4 <= 4 && 5 > 2;
Console.WriteLine(resAnd);

char Char = 'b';
bool charComp = Char > 'a';
Console.WriteLine(charComp);

bool zeroComp = -0.0 == 0.0;
Console.WriteLine(zeroComp);