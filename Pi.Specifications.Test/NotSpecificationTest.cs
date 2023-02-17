using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Specifications.Test;
public class NotSpecificationTest
{
    [Fact]
    public async Task Not_True_ShouldReturnFalse()
    {
        var isHigherThan10 = new IsHigherThan10();

        var result = await isHigherThan10.Not().IsSatisfiedBy(11);

        Assert.False(result);
    }

    [Fact]
    public async Task Not_False_ShouldReturnTrue()
    {
        var isHigherThan10 = new IsHigherThan10();

        var result = await isHigherThan10.Not().IsSatisfiedBy(9);

        Assert.True(result);
    }
}
