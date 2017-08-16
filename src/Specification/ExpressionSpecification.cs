using System;
using System.Linq.Expressions;

namespace FluentSpecification
{
    public abstract class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        public abstract Expression<Func<T, bool>> AsExpression();
        public override bool IsSatisfiedBy(T obj) => AsExpression().Compile()(obj);
    }
}
