using System;
namespace task5; 

class program
{
    static void Main(string[] args)
    {
        string Fname = "REMSHA";
        string Sname = "TARIQ";
        {
            Console.WriteLine(Fname + Sname);
        }
        string fullname = Fname + Sname;

        {
            Console.WriteLine(fullname);
            Console.WriteLine(fullname.ToUpper());
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(fullname.IndexOf('R'));
        }
        String str = "ABCD";
        {
            Console.WriteLine(str[0]);
            Console.WriteLine(str[1]);
            Console.WriteLine(str[2]);
            Console.WriteLine(str[3]);
        }
        Console.WriteLine(str.Length);
    }
}
