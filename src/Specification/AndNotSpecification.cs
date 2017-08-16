namespace FluentSpecification
{
    public class AndNotSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> left;
        ISpecification<T> right;

        public AndNotSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override bool IsSatisfiedBy(T obj) => left.IsSatisfiedBy(obj) && right.IsSatisfiedBy(obj) != true;
    }
}