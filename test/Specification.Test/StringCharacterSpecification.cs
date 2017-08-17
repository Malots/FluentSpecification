namespace FluentSpecification.Test
{
    public class StringCharacterSpecification<T> : Specification<T>
    {
        public override bool IsSatisfiedBy(T obj)
        {
            return obj.ToString().Contains("_");
        }
    }
}
