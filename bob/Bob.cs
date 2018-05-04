using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().Equals(""))
        {
            return "Fine. Be that way!";
        }

        if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }

      if(statement.ToUpper().EndsWith("?") || statement.ToUpper().EndsWith("!"))
        {
            return "Whoa, chill out!";
        }

        return "Whatever.";

    }
}