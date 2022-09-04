namespace assignment0tests;

public class UnitTest1
{
    private readonly Program _p;

    public UnitTest1()
    {
        _p = new Program();
    }

    [Fact]
    public void IsLeapYearDivisibleByFourTest()
    {
        Assert.Equal(true,_p.IsLeapYear(2004));
        Assert.Equal(false,_p.IsLeapYear(2005));
    }

    [Fact]
    public void IsLeapYearExceptDivisibleByHundredTest()
    {
        Assert.Equal(false,_p.IsLeapYear(1700));
        Assert.Equal(false,_p.IsLeapYear(1800));
        Assert.Equal(false,_p.IsLeapYear(1900));
        Assert.Equal(true,_p.IsLeapYear(2004));
    }

    [Fact]
    public void IsLeapYearExceptDivisibleByFourHundredTest()
    {
        Assert.Equal(true,_p.IsLeapYear(1600));
        Assert.Equal(true,_p.IsLeapYear(2000));
    }
}