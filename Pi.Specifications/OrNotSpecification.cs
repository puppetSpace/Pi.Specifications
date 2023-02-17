using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Specifications;
public class OrNotSpecification<TE> : ISpecification<TE>
{
    private readonly ISpecification<TE> _left;
    private readonly ISpecification<TE> _right;

    public OrNotSpecification(ISpecification<TE> left, ISpecification<TE> right)
    {
        _left = left;
        _right = right;
    }

    public async Task<bool> IsSatisfiedBy(TE candiate)
    {
        return await _left.IsSatisfiedBy(candiate) || !await _right.IsSatisfiedBy(candiate);
    }
}
