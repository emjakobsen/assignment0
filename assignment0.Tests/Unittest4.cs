using System.Reflection;
namespace assignment0;
//namespace assignment0.Tests;


public class UnitTest4
{
    [Fact]
    
    public void Is_this_leapyear_with_1700_should_return_false() {
      using var writer = new StringWriter();
        Console.SetOut(writer);
        var program = Assembly.Load(nameof(assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });
        var testProgram = new Assignment0Class();
        bool a = testProgram.isLeapYear(1700);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal(false, a); 
    }
}