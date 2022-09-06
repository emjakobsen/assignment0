using System.Reflection;
namespace assignment0;
//namespace assignment0.Tests;


public class UnitTest7
{
    [Fact]
    
    public void Is_this_leapyear_with_1600_should_return_true() {
      using var writer = new StringWriter();
        Console.SetOut(writer);
        var program = Assembly.Load(nameof(assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });
        var testProgram = new Assignment0Class();
        bool a = testProgram.isLeapYear(1600);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal(true, a); 
    }
}