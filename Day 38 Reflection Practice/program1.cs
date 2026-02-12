// H1) List Private + Protected + Internal Methods (Declared Only)
// Scenario: List all non-public instance methods declared ONLY in the given class (exclude inherited). Exclude special methods (get_/set_/add_/remove_).
// Input Format:
// Line 1: Type full name
// Output Format:
// Method names sorted ascending; TYPE_NOT_FOUND if type missing; NO_METHODS if none.
// Sample Input	Sample Output
// Assessment.DerivedSample	Hidden Inside Shield

// Answer (Full Working C# Code):
// NOTE: Each solution below is SELF-CONTAINED and includes required demo types.
// These demo types exist only to make Reflection questions testable in a single file.
// Type names used in sample inputs belong to this namespace: Assessment

using System;
using System.Linq;
using System.Reflection;

namespace Assessment
{
    public class BaseSample
    {
        // These are ignored because of BindingFlags.DeclaredOnly
        private void BasePrivate() { }
    }

    public class DerivedSample : BaseSample
    {
        // The targets for the logic
        private void Hidden() { }
        protected void Shield() { }
        internal void Inside() { }

        // These are ignored because they are public or special (get/set)
        public void Visible() { }
        public string Name { get; set; } 
    }
}

class Program
{
    static void Main()
    {
        string typeName = Console.ReadLine()?.Trim() ?? "";
        Type t = Type.GetType(typeName);

        if (t == null)
        {
            Console.WriteLine("TYPE_NOT_FOUND");
            return;
        }

        var methods = t.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName)
            .Select(m => m.Name)
            .OrderBy(n => n, StringComparer.Ordinal)
            .ToList();

        if (methods.Count == 0)
        {
            Console.WriteLine("NO_METHODS");
        }
        else
        {
            foreach (var name in methods) Console.WriteLine(name);
        }
    }
}