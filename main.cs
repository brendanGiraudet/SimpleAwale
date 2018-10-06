using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        // opponent
        string opBowls = Console.ReadLine();
        var opList = opBowls.Split(' ').ToList();
        // me
        string myBowls = Console.ReadLine();
        var myList = myBowls.Split(' ').ToList();
        // index of choosen bowl
        int num = int.Parse(Console.ReadLine());
        // display opponent bowls
        DisplayBowls(opList);
        // display my bowls
        DisplayBowls(myList);
    }

    static void DisplayBowls(List<string> bowlList)
    {
        var line = "";
        bowlList.ForEach( b => {
            // if last bowl => reserve
            if(bowlList.IndexOf(b) == bowlList.Count -1)
            {
                line += " [" + b + "]";
            }
            else
            {
                line += " " + b;
            }
            System.Console.Error.WriteLine(b);
        });
        System.Console.WriteLine(line.Trim());
    }
}