using System;

public static class Bob
{
    public static string Response(string statement)
    {
        if(statement.Trim() == ""){
            return "Fine. Be that way!";
        }
        else if (statement.EndsWith("?")){
            return "Sure.";
        } 
        return "Whatever.";

    }
}