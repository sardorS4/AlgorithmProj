// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
////1 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else
//{
//    Console.WriteLine(number);
//}
// [24.01.2023 14:48]
////2 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else
//{
//    Console.WriteLine(number - 2);
//}
//Behruz, [24.01.2023 14:48]
//2 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else
//{
//    Console.WriteLine(number - 2);
//}

//Behruz, [24.01.2023 14:50]
////3 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else if (number < 0)
//{
//    Console.WriteLine(number - 2);
//}
//else
//{
//    number = 10;
//    Console.WriteLine(number);
//}
//27 misol;
int x = int.Parse(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine(0);
}
else if ((x <= 0 && x < 1) || (x <= 2 && x < 3))
{
    Console.WriteLine(1);
}
else if ((x <= 1 && x < 2) || (x <= 3 && x < 4)) ;