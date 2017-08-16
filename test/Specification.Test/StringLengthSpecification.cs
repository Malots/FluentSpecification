namespace FluentSpecification.Test
{
    public class StringLengthSpecification<T> : CompositeSpecification<T>
    {
        public override bool IsSatisfiedBy(T obj)
        {
            return obj.ToString().Length > 5;
        }
    }
}
