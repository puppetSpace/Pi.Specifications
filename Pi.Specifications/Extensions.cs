using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jdn.Specifications;
public static class Extensions
{
    public static ISpecification<TE> And<TE>(this ISpecification<TE> left, ISpecification<TE> right ) => new AndSpecification<TE>(left,right);
    public static ISpecification<TE> Or<TE>(this ISpecification<TE> left, ISpecification<TE> right ) => new OrSpecification<TE>(left,right);
    public static ISpecification<TE> AndNot<TE>(this ISpecification<TE> left, ISpecification<TE> right ) => new AndNotSpecification<TE>(left,right);
    public static ISpecification<TE> OrNot<TE>(this ISpecification<TE> left, ISpecification<TE> right ) => new OrNotSpecification<TE>(left,right);
    public static ISpecification<TE> Not<TE>(this ISpecification<TE> specification) => new NotSpecification<TE>(specification);
}
