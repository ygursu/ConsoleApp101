﻿Console.WriteLine("KAÇINCI AYDAYIZ:");
int ay = Convert.ToInt32(Console.ReadLine());
switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("kış mevsimi");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("ilkbahar mevsimi");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yaz mevsimi");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sonbahar mevsimi");
        break;
}