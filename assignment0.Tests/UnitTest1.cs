using System.Reflection;
namespace assignment0;
//namespace assignment0.Tests;


public class UnitTest1
{
    [Fact]
    /*
    public void Test1()
    {
      // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        //output.Should().Be("Hello, World!");   
        Assert.Equal("Hello, World!", output); 
    }*/
    public void Is_this_leapyear_with_4_should_return_true()
    {
      // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });
        
        var testProgram = new Assignment0Class();
        
        bool a = testProgram.isLeapYear(4);
        // Assert
        

        var output = writer.GetStringBuilder().ToString().TrimEnd();
         
        Assert.Equal(true, a); 
    }
    public void Is_this_leapyear_with_6_should_return_false() {
      using var writer = new StringWriter();
        Console.SetOut(writer);
        var program = Assembly.Load(nameof(assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });
        var testProgram = new Assignment0Class();
        bool a = testProgram.isLeapYear(6);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        Assert.Equal(false, a); 
    }
}