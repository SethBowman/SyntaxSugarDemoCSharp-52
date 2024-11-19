namespace SyntaxSugarDemoCSharp_52;

class Program
{
    static void Main(string[] args)
    {
        //Explicit typing
        int number = 10;
        string word;
        
        //Inferred typing
        var myVariable = 10.0;
        
        //inline if statement (ternary operator)
        var age = 3;

        Console.WriteLine(age >= 18 ? "You're an adult!" : age < 5  ? "You're a child!" : "You're a minor!");
        
        //string interpolation vs concatenation
        var middleInitial = 'S';

        Console.WriteLine($"Brandon {middleInitial} Bowman");
        Console.WriteLine("Brandon" + " " + middleInitial + " " + "Bowman");
    }
}
