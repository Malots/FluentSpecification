namespace FluentSpecification
{
    public class OrSpecification<T> : Specification<T>
    {
        ISpecification<T> left;
        ISpecification<T> right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override bool IsSatisfiedBy(T obj) => left.IsSatisfiedBy(obj) || right.IsSatisfiedBy(obj);
    }
}