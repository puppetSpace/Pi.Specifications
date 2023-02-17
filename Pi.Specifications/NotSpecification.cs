using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi.Specifications;
public class NotSpecification<TE> : ISpecification<TE>
{
    private readonly ISpecification<TE> _specification;

    public NotSpecification(ISpecification<TE> specification)
    {
        _specification = specification;
    }

    public async Task<bool> IsSatisfiedBy(TE candiate)
    {
        return !await _specification.IsSatisfiedBy(candiate);
    }
}
