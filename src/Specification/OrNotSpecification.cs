namespace FluentSpecification
{
    public class OrNotSpecification<T> : Specification<T>
    {
        ISpecification<T> left;
        ISpecification<T> right;

        public OrNotSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override bool IsSatisfiedBy(T obj) => left.IsSatisfiedBy(obj) || right.IsSatisfiedBy(obj) != true;
    }
}