using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Specifications.Test;
public class AndNotSpecificationTest
{
    [Fact]
    public async Task AndNot_BothAreTrue_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.AndNot(isHigherThan0).IsSatisfiedBy(11);

        Assert.False(result);
    }

    [Fact]
    public async Task AndNot_LeftIsTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan0.AndNot(isHigherThan10).IsSatisfiedBy(9);

        Assert.True(result);
    }

    [Fact]
    public async Task AndNot_RightIsTrue_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.AndNot(isHigherThan0).IsSatisfiedBy(9);

        Assert.False(result);
    }

    [Fact]
    public async Task AndNot_BothAreFalse_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.AndNot(isHigherThan0).IsSatisfiedBy(-1);

        Assert.False(result);
    }
}
