namespace RomanNumerals.Tests;

public class UnitTest1
{
    [Fact]
    public void Should_Convert_1_To_I()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(1);
        Assert.Equal("I", result);
    }    
    [Fact]
    public void Should_Convert_2_To_II()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(2);
        Assert.Equal("II", result);
    }
    [Fact]
    public void Should_Convert_3_To_III()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(3);
        Assert.Equal("III", result);
    } 
    [Fact]
    public void Should_Convert_4_To_IV()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(4);
        Assert.Equal("IV", result);
    } 
    [Fact]
    public void Should_Convert_5_To_V()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(5);
        Assert.Equal("V", result);
    }
    [Fact]
    public void Should_Convert_6_To_VI()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(6);
        Assert.Equal("VI", result);
    } 
    [Fact]
    public void Should_Convert_10_To_X()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(10);
        Assert.Equal("X", result);
    }
    [Fact]
    public void Should_Convert_9_To_IX()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(9);
        Assert.Equal("IX", result);
    }
    [Fact]
    public void Should_Convert_21_To_XXI()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(21);
        Assert.Equal("XXI", result);
    }    
    [Fact]
    public void Should_Convert_50_To_L()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(50);
        Assert.Equal("L", result);
    }  
    [Fact]
    public void Should_Convert_100_To_C()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(100);
        Assert.Equal("C", result);
    }    
    [Fact]
    public void Should_Convert_500_To_D()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(500);
        Assert.Equal("D", result);
    }
    [Fact]
    public void Should_Convert_1000_To_M()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(1000);
        Assert.Equal("M", result);
    }
    
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(9, "IX")]
    [InlineData(23, "XXIII")]
    [InlineData(47, "XLVII")]
    [InlineData(162, "CLXII")]
    [InlineData(403, "CDIII")]
    [InlineData(91, "XCI")]
    [InlineData(923, "CMXXIII")]
    [InlineData(1150, "MCL")]
    [InlineData(1999, "MCMXCIX")]
    public void Should_Convert_Number_To_RomanNumerals(int number, string romanNumeral)
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(number);
        Assert.Equal(romanNumeral, result);
    }
}