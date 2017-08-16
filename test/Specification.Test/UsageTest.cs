using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentSpecification.Test
{
    [TestClass]
    public class UsageTest
    {
        [TestMethod]
        [TestCategory("And Specification")]
        public void GiveTwoStringSpecificationToTestValidAndSpecification()
        {
            var value = "stringcontent_";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andSpecification = lengthSpecification.And(characterSpecification);
            Assert.IsTrue(andSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("And Specification")]
        public void GiveTwoStringSpecificationToTestInvalidAndSpecification()
        {
            var value = "string";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andSpecification = lengthSpecification.And(characterSpecification);
            Assert.IsFalse(andSpecification.IsSatisfiedBy(value));
        }
    }
}
