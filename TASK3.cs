using System;

bool Foo() => true;

bool logic1 = !true || false && true;
Console.WriteLine(logic1);

bool logic2 = false && Foo();
Console.WriteLine(logic2);

bool logic3 = false & Foo();
Console.WriteLine(logic3);

bool logic4 = true ^ false ^ true;
Console.WriteLine(logic4);

bool logic5 = !(5 > 2 || 3 < 1);
Console.WriteLine(logic5);

bool a6 = true, b6 = false;
bool logic6 = a6 && !b6 || b6 && !a6;
Console.WriteLine(logic6);

int x7 = 5;
bool logic7 = true || (x7 / 0 == 1);
Console.WriteLine(logic7);

bool logic8 = false & (10 / 1 == 1);
Console.WriteLine(logic8);

bool A = true, B = false;
bool deMorgan1 = !(A && B) == (!A || !B);
Console.WriteLine(deMorgan1);

bool deMorgan2 = !(A || B) == (!A && !B);
Console.WriteLine(deMorgan2);