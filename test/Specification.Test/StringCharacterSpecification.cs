namespace FluentSpecification.Test
{
    public class StringCharacterSpecification<T> : CompositeSpecification<T>
    {
        public override bool IsSatisfiedBy(T obj)
        {
            return obj.ToString().Contains("_");
        }
    }
}
