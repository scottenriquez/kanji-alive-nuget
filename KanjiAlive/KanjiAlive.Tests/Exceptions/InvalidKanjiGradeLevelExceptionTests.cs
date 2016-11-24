using KanjiAlive.Exceptions;
using KanjiAlive.Helpers;
using NUnit.Framework;

namespace KanjiAlive.Tests.Exceptions
{
    [TestFixture]
    public class InvalidKanjiGradeLevelExceptionTests
    {
        [Test]
        public void ShouldThrowKanjiGradeLevelException()
        {
            Assert.Throws<InvalidKanjiGradeLevelException>(() => { Ensure.KanjiGradeLevelIsValid(7); });
        }

        [Test]
        public void ShouldNotThrowKanjiGradeLevelException()
        {
            Assert.DoesNotThrow(() => { Ensure.KanjiGradeLevelIsValid(4); });
        }
    }
}
