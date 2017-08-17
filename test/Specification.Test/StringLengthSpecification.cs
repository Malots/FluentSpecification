namespace FluentSpecification.Test
{
    public class StringLengthSpecification<T> : Specification<T>
    {
        public override bool IsSatisfiedBy(T obj)
        {
            return obj.ToString().Length > 5;
        }
    }
}
