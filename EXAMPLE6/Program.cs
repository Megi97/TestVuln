// See https://aka.ms/new-console-template for more information
using System;
namespace example6;
public enum productsCode 
{
    milk=0,
    coffee=1,
    sugar=2
}
class Example6
{
    static void printtext()
    {
        Console.WriteLine("lalalvefjk nug,nkjltg jkggdg");
    }
    static int printSum()
    {
        Console.WriteLine("44444");

        if (4<5)
            return 0;
        else
            return 1;
    }
static void Main(string [] args)
    {
        productsCode test=productsCode.milk;
        Console.WriteLine(test);
        printtext();
        printSum();

    }

}

