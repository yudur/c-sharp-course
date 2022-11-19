using System;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("hello word");
        if(args.GetLength(0)>0){
            Console.WriteLine(args.GetValue(0));
        }
    }
}