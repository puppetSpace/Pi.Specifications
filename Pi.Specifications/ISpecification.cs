namespace Pi.Specifications;
public interface ISpecification<TE>
{
    Task<bool> IsSatisfiedBy(TE candiate);
}
