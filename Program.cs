using System;

class Program
{
    static void Main()
    {
        bool result1 = (5 > 3) && !(10 <= 2) || (4 == 5);
        Console.WriteLine($"Задание 1: {result1}");

        bool result2 = !(true && false) ^ (true || false && false);
        Console.WriteLine($"Задание 2: {result2}");

        bool result3 = ((10 & 6) == 2) && ((10 | 6) == 14);
        Console.WriteLine($"Задание 3: {result3}");

        bool result4 = (15 >> 1 == 7) && (7 << 2 == 28);
        Console.WriteLine($"Задание 4: {result4}");

        bool result5 = (8 > 5) && (3 + 2 * 4 == 11) && !(false || !true);
        Console.WriteLine($"Задание 5: {result5}");

        bool result6 = (true || false) && (false || true) ^ (true && !false);
        Console.WriteLine($"Задание 6: {result6}");

        bool result7 = (100 / 10 == 0) && (100 % 30 == 10) && !(5 - 5 != 0);
        Console.WriteLine($"Задание 7: {result7}");

        bool result8 = (4 ^ 4) == 0 && (4 ^ 0) == 4 && (0 ^ 0) == 0;
        Console.WriteLine($"Задание 8: {result8}");

        bool result9 = !(6 != 5) && ((3 >= 3) || (10 / 1 == 1));
        Console.WriteLine($"Задание 9: {result9}");

        bool result10 = (false && (10 / 1 == 1)) || (true && (20 > 15));
        Console.WriteLine($"Задание 10: {result10}");

        bool result11 = (12 & 10) > 5 || (12 | 10) < 15 && !(3 == 3);
        Console.WriteLine($"Задание 11: {result11}");

        bool result12 = ((20 >> 2) == 5) ^ ((5 << 1) == 11);
        Console.WriteLine($"Задание 12: {result12}");

        bool result13 = !(!(true || false) && (true && !false));
        Console.WriteLine($"Задание 13: {result13}");

        bool result14 = (7 > 2 ? 10 : 20) == 10 && (3 < 1 ? 5 : 15) == 15;
        Console.WriteLine($"Задание 14: {result14}");

        bool result15 = (5 & 1) == 1 && (6 & 1) == 0 && (7 & 1) == 1;
        Console.WriteLine($"Задание 15: {result15}");

        bool result16 = ((10 > 5 ? true : false) ^ (3 > 8 ? true : false)) && !false;
        Console.WriteLine($"Задание 16: {result16}");

        bool result17 = !((5 > 2 && 10 > 20) || (3 == 3 && 4 <= 4));
        Console.WriteLine($"Задание 17: {result17}");

        bool result18 = ((1 << 3) == 8) && ((16 >> 4) == 1) && ((2 << 2) == 8);
        Console.WriteLine($"Задание 18: {result18}");

        bool result19 = ((10 & 7) == 2) || ((10 | 7) == 15) ^ !(4 > 1);
        Console.WriteLine($"Задание 19: {result19}");

        bool result20 = false || true && false || true && !false;
        Console.WriteLine($"Задание 20: {result20}");

        bool result21 = (25 % 4 == 1) && (17 / 3 == 5) && (17 % 3 == 2);
        Console.WriteLine($"Задание 21: {result21}");

        bool result22 = ((5 ^ 3 ^ 3) == 5) && ((10 ^ 0) == 10);
        Console.WriteLine($"Задание 21: {result22}");

        bool result23 = (true ? (false ? 1 : 2) : (true ? 3 : 4)) == 2;
        Console.WriteLine($"Задание 23: {result23}");

        bool result24 = !(true && !(false || !false));
        Console.WriteLine($"Задание 24: {result24}");

        bool result25 = ((~0 == -1) && (~(-1) == 0));
        Console.WriteLine($"Задание 25: {result25}");

        bool result26 = ((8 & 4) == 0) && ((8 | 4) == 12) && ((8 ^ 4) == 12);
        Console.WriteLine($"Задание 26: {result26}");

        bool result27 = !(10 >= 10) || (5 < 3) && (2 == 2) || !(false);
        Console.WriteLine($"Задание 27: {result27}");

        bool result28 = !((15 & ~1) == 14) && ((14 | 1) == 15);
        Console.WriteLine($"Задание 28: {result28}");

        bool result29 = ((true || false) ? (false && true ? 10 : 20) : 30) == 20;
        Console.WriteLine($"Задание 29: {result29}");

        bool result30 = ((10 > 2) && (5 < 9)) ^ (!(4 >= 5) && (6 != 7));
        Console.WriteLine($"Задание 30: {result30}");

        bool result31 = (7 & 3 & 1) == 1 && (7 | 3 | 1) == 7;
        Console.WriteLine($"Задание 31: {result31}");

        bool result32 = ((10 > 5 && 3 < 1) || (8 == 8 && !(5 > 10))) && (4 + 4 == 8);
        Console.WriteLine($"Задание 32: {result32}");

        bool result33 = !((!(true && false) || !(true || false)) && !false);
        Console.WriteLine($"Задание 33: {result33}");

        bool result34 = ((32 >> 3 == 4) && (4 << 3 == 32)) ^ ((15 & 7) == 7 && (15 | 7) == 15);
        Console.WriteLine($"Задание 34: {result34}");

        bool result35 = ((5 > 3 ? (2 > 1 ? true : false) : false) && !((10 > 20) || (30 < 15)));
        Console.WriteLine($"Задание 35: {result35}");
    }
}









