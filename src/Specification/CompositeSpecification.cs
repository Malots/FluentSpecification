using System;
using System.Linq.Expressions;

namespace FluentSpecification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T obj);
        public ISpecification<T> And(ISpecification<T> obj) => new AndSpecification<T>(this, obj);
        public ISpecification<T> AndNot(ISpecification<T> obj) => new AndNotSpecification<T>(this, obj);
        public ISpecification<T> Or(ISpecification<T> obj) => new OrSpecification<T>(this, obj);
        public ISpecification<T> OrNot(ISpecification<T> obj) => new OrNotSpecification<T>(this, obj);
        public ISpecification<T> Not() => new NotSpecification<T>(this);
    }
}
