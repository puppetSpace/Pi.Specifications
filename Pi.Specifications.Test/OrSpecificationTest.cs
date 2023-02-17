using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi.Specifications.Test;
public class OrSpecificationTest
{
    [Fact]
    public async Task Or_BothAreTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.Or(isHigherThan0).IsSatisfiedBy(11);

        Assert.True(result);
    }

    [Fact]
    public async Task Or_LeftIsTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan0.Or(isHigherThan10).IsSatisfiedBy(9);

        Assert.True(result);
    }

    [Fact]
    public async Task Or_RightIsTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan0.Or(isHigherThan10).IsSatisfiedBy(9);

        Assert.True(result);
    }

    [Fact]
    public async Task Or_BothAreFalse_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.Or(isHigherThan0).IsSatisfiedBy(-1);

        Assert.False(result);
    }
}
