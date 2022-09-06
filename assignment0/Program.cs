// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace assignment0;
#pragma warning disable CS8600
class Program 
{
    static void Main (string[] args) {
        //Console.WriteLine("Hello, World!");
        
    
        string userInput = Console.ReadLine();
        int numericValue;
        if (int.TryParse(userInput, out numericValue)){
            var a0 = new Assignment0Class();
             int input = Convert.ToInt32(userInput);

            
            if(a0.isLeapYear(input)){
                Console.WriteLine("yay");
            }
            else {
                Console.WriteLine("nay");
            }
        }
        else {
            Console.WriteLine("User input must be a year after 1582.");
        }
        
        
        
        
        //Console.WriteLine(a0.isLeapYear(input));
    
        // med dotnet run <dit nummer> -- 0
        //Console.WriteLine(a0.isLeapYear(Int32.Parse(args[1])));
    }
    
    

}
