namespace FluentSpecification
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> right;
        public NotSpecification(ISpecification<T> right) => this.right = right;
        public override bool IsSatisfiedBy(T left) => !right.IsSatisfiedBy(left);
    }
}