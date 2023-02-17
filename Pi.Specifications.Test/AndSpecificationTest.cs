namespace Jdn.Specifications.Test;

public class AndSpecificationTest
{
    [Fact]
    public async Task And_BothAreTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.And(isHigherThan0).IsSatisfiedBy(11);

        Assert.True(result);
    }

    [Fact]
    public async Task And_LeftIsTrue_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan0.And(isHigherThan10).IsSatisfiedBy(9);

        Assert.False(result);
    }

    [Fact]
    public async Task And_RightIsTrue_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.And(isHigherThan0).IsSatisfiedBy(9);

        Assert.False(result);
    }

    [Fact]
    public async Task And_BothAreFalse_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.And(isHigherThan0).IsSatisfiedBy(-1);

        Assert.False(result);
    }
}