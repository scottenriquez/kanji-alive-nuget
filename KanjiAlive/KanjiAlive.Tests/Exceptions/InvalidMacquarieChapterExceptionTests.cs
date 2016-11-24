using KanjiAlive.Exceptions;
using KanjiAlive.Helpers;
using NUnit.Framework;

namespace KanjiAlive.Tests.Exceptions
{
    [TestFixture]
    public class InvalidMacquarieChapterExceptionTests
    {
        [Test]
        public void ShouldThrowMacquarieChapterException()
        {
            Assert.Throws<InvalidMacquarieChapterException>(() => { Ensure.MacquarieChapterIsValid(5); });
        }

        [Test]
        public void ShouldNotThrowMacquarieChapterException()
        {
            Assert.DoesNotThrow(() => { Ensure.MacquarieChapterIsValid(15); });
        }
    }
}
