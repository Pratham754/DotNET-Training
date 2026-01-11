using System;
using System.Reflection;
using Reflection;
public class ReflectionExeFinder
{
    public static void Main()
    {
        Department dep = new();
        var depp = dep.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        foreach(var v in depp)
        {
            System.Console.WriteLine(v.Name);
        }
    }
}