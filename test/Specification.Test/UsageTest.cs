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

        [TestMethod]
        [TestCategory("AndNot Specification")]
        public void GiveTwoStringSpecificationToTestValidAndNotSpecification()
        {
            var value = "string";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andNotSpecification = lengthSpecification.AndNot(characterSpecification);
            Assert.IsTrue(andNotSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("AndNot Specification")]
        public void GiveTwoStringSpecificationToTestInvalidAndNotSpecification()
        {
            var value = "stringcontent_";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andNotSpecification = lengthSpecification.AndNot(characterSpecification);
            Assert.IsFalse(andNotSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("Not Specification")]
        public void GiveTwoStringSpecificationToTestValidNotSpecification()
        {
            var value = "string";
            var lengthSpecification = new StringLengthSpecification<string>();
            Assert.IsTrue(lengthSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("Not Specification")]
        public void GiveTwoStringSpecificationToTestInvalidNotSpecification()
        {
            var value = "str";
            var lengthSpecification = new StringLengthSpecification<string>();
            Assert.IsFalse(lengthSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("OrNot Specification")]
        public void GiveTwoStringSpecificationToTestValidOrNotSpecification()
        {
            var value = "string";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andNotSpecification = lengthSpecification.OrNot(characterSpecification);
            Assert.IsTrue(andNotSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("OrNot Specification")]
        public void GiveTwoStringSpecificationToTestInvalidOrNotSpecification()
        {
            var value = "str";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andNotSpecification = lengthSpecification.OrNot(characterSpecification);
            Assert.IsTrue(andNotSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("Or Specification")]
        public void GiveTwoStringSpecificationToTestValidOrSpecification()
        {
            var value = "str_";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andNotSpecification = lengthSpecification.Or(characterSpecification);
            Assert.IsTrue(andNotSpecification.IsSatisfiedBy(value));
        }

        [TestMethod]
        [TestCategory("Or Specification")]
        public void GiveTwoStringSpecificationToTestInvalidOrSpecification()
        {
            var value = "str";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andNotSpecification = lengthSpecification.Or(characterSpecification);
            Assert.IsFalse(andNotSpecification.IsSatisfiedBy(value));
        }
    }
}
