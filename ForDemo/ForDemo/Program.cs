﻿class HelloWorld
{
    static void Main()
    {
        //Console.WriteLine("Hello World!");
        for(int i=1; i<=5; i++)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
