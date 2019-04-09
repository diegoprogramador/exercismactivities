using System;
using System.Collections.Generic;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] splitString = new string[] { " ", "-" };    
        string[] acronym = phrase.Split(splitString, StringSplitOptions.RemoveEmptyEntries);

        int i = 0;

        phrase = "";

        foreach (var item in acronym)
        {
            phrase += acronym[i].Remove(1);
            i++;
        }
        return phrase.ToUpper();
    }
}