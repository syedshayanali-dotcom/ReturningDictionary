using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static Dictionary<int,int> GetDictionaryList(List<int> n)
    {
        return n.GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count());

    
    }


    public static void Main()
    { 
        List<int> list = new List<int>() { 1,3,3,3,1,5,5,9,5};
        var res = GetDictionaryList(list);

        foreach (var item in res)
        {
            Console.WriteLine(item.Key+":"+item.Value);

        }
    
    }

}