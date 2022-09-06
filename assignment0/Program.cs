// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace assignment0;
class Program 
{
    static void Main (string[] args) {
        //Console.WriteLine("Hello, World!");
        
    

        var a0 = new Assignment0Class();
        int input = Convert.ToInt32(Console.ReadLine());
        
        
        
        Console.WriteLine(a0.isLeapYear(input));
    
        // med dotnet run <dit nummer> -- 0
        //Console.WriteLine(a0.isLeapYear(Int32.Parse(args[1])));
    }
    
    

}
