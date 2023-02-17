using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Specifications.Test;
public class OrNotSpecificationTest
{
    [Fact]
    public async Task OrNot_BothAreTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.OrNot(isHigherThan0).IsSatisfiedBy(11);

        Assert.True(result);
    }

    [Fact]
    public async Task OrNot_LeftIsTrue_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan0.OrNot(isHigherThan10).IsSatisfiedBy(9);

        Assert.True(result);
    }

    [Fact]
    public async Task OrNot_RightIsTrue_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.OrNot(isHigherThan0).IsSatisfiedBy(9);

        Assert.False(result);
    }

    [Fact]
    public async Task OrNot_BothAreFalse_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();
        var isHigherThan0 = new IsHigherThan0();

        var result = await isHigherThan10.OrNot(isHigherThan0).IsSatisfiedBy(-1);

        Assert.True(result);
    }
}
