using System;
using System.Linq;
using System.Collections;
public class miniMax
{
    public static void Main(string[] args)
    {
        int[] arr = { 793810624, 895642170, 685903712, 623789054, 468592370 };
        long max = 0;
        long min = 0;
        ArrayList maxArr = new ArrayList();
        ArrayList minArr = new ArrayList();
        foreach (int i in arr)
        {
            if (i == arr.Min())
            {
                continue;
            }
            else
            {
                maxArr.Add(i);
            }
        }
        foreach(int i in arr)
        {
            if (i == arr.Max())
            {
                continue;
            }
            else
            {
                minArr.Add(i);
            }
        }
        foreach(int i in minArr)
        {
            min += i;
        }
        foreach(int i in maxArr)
        {
            max += i; 
        }
        Console.WriteLine("{0},{1}", min, max);
    }
}