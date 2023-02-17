namespace Jdn.Specifications;
public interface ISpecification<TE>
{
    Task<bool> IsSatisfiedBy(TE candiate);
}
