# Specification Pattern
>In computer programming, the specification pattern is a particular software design pattern, whereby business rules can be recombined by chaining the business rules together using boolean logic. The pattern is frequently used in the context of domain-driven design.
>
>A specification pattern outlines a business rule that is combinable with other business rules. In this pattern, a unit of business logic inherits its functionality from the abstract aggregate Composite Specification class. The Composite Specification class has one function called IsSatisfiedBy that returns a boolean value. After instantiation, the specification is "chained" with other specifications, making new specifications easily maintainable, yet highly customizable business logic. Furthermore, upon instantiation the business logic may, through method invocation or inversion of control, have its state altered in order to become a delegate of other classes such as a persistence repository.
>
>As a consequence of performing runtime composition of high-level business/domain logic, the Specification pattern is a convenient tool for converting ad-hoc user search criteria into low level logic to be processed by repositories.
>
>Since a specification is an encapsulation of logic in a reusable form it is very simple to thoroughly unit test, and when used in this context is also an implementation of the humble object pattern.

## Usage
Create own specifications by implementing the interface `ISpecification<TE>`. Then you can use the extensions methods on `ISpecification<TE>` to combine the specifications using boolean logic

### Available extension methods
- And
- AndNot
- Or
- OrNot
- Not

### Example
**rule that number is higher than 10**
```
public class IsHigherThan10 : ISpecification<int>
{
    public Task<bool> IsSatisfiedBy(int candiate)
    {
        return Task.FromResult(candiate > 10);
    }
}
```
**rule that number is higher tha 0**
```
public class IsHigherThan0 : ISpecification<int>
{
    public Task<bool> IsSatisfiedBy(int candiate)
    {
        return Task.FromResult(candiate > 0);
    }
}
```

```
//check if number is between 0 and 10
var isHigherThan10 = new IsHigherThan10();
var isHigherThan0 = new IsHigherThan0();

var result = await isHigherThan0.AndNot(isHigherThan10).IsSatisfiedBy(9);
if(result){
    // business rule is good.
}
´´´