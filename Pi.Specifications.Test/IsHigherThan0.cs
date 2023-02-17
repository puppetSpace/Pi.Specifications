using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi.Specifications.Test;

public class IsHigherThan0 : ISpecification<int>
{
    public Task<bool> IsSatisfiedBy(int candiate)
    {
        return Task.FromResult(candiate > 0);
    }
}
