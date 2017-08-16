namespace FluentSpecification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);
        ISpecification<T> And(ISpecification<T> obj);
        ISpecification<T> AndNot(ISpecification<T> obj);
        ISpecification<T> Or(ISpecification<T> obj);
        ISpecification<T> OrNot(ISpecification<T> obj);
        ISpecification<T> Not();
    }
}
