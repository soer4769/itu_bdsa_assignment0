namespace assignment0tests;

public class UnitTest1
{
    [Fact]
    public void IsLeapYearDivisibleByFourTest()
    {
        Assert.Equal(true,Program.IsLeapYear(2004));
        Assert.Equal(false,Program.IsLeapYear(2005));
    }

    [Fact]
    public void IsLeapYearExceptDivisibleByHundredTest()
    {
        Assert.Equal(false,Program.IsLeapYear(1700));
        Assert.Equal(false,Program.IsLeapYear(1800));
        Assert.Equal(false,Program.IsLeapYear(1900));
        Assert.Equal(true,Program.IsLeapYear(2004));
    }

    [Fact]
    public void IsLeapYearExceptDivisibleByFourHundredTest()
    {
        Assert.Equal(true,Program.IsLeapYear(1600));
        Assert.Equal(true,Program.IsLeapYear(2000));
    }
}