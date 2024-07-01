using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class nametouppercase
{
    static void Main(string[] args)
    {
        //Enter Data
        Console.Write(" Enter Your First Name : ");
        string fname = Console.ReadLine();

        Console.Write(" Enter Your Last Name : ");
        string lname = Console.ReadLine();

        Console.WriteLine("\n");        //Add a Blank Line inbetween.

        //Calling the Static Method - DisplayName
        Display(fname, lname);

        Console.ReadKey();
    }

    //Static Method - DisplayName
    static void Display(string fname, string lname)
    {
        //First Display Original Name.
        Console.WriteLine("   Original Input from User : - ");
        Console.WriteLine($"   First Name : {fname} ");
        Console.WriteLine($"   Last  Name : {lname} ");

        Console.WriteLine("\n");        //Add a Blank Line.

        //Now Display Name in UpperCase 
        Console.WriteLine("   Name After Changing Case :- ");

        //Change Last Name into UpperCase and store it in diff string name - 'Lname'. Used String Function 
        string Lname = lname.ToUpper();

        //Now Print Name in UpperCase
        Console.WriteLine($"   First Name in UpperCase : {fname.ToUpper()} "); //Directly Change First name into UpperCase during output using string function. 
        Console.WriteLine($"   Last  Name in UpperCase : {Lname} ");
    }
}

