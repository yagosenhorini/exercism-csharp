using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var cont = 0;
        var test = multiples.Select(e => e / e == 0 ? e : 0).Sum();
        return test;

        foreach(var item in multiples){
            if(item / item == 0){
                cont += item; 
            }
        }

    }
}