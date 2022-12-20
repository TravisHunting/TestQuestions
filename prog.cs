// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        var result = new List<string>();
        foreach (string name in names1)
        {
            if (!result.Contains(name))
            {
                result.Add(name);
            }
        }

        foreach (string name in names2)
        {
            if (!result.Contains(name))
            {
                result.Add(name);
            }
        }

        return result.ToArray();
    }

    //public static void Main(string[] args)
    //{
    //    string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
    //    string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
    //    Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    //}
}