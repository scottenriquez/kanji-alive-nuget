using KanjiAlive.Exceptions;
using KanjiAlive.Helpers;
using NUnit.Framework;

namespace KanjiAlive.Tests.Exceptions
{
    [TestFixture]
    public class InvalidApExamChapterExceptionTests
    {
        [Test]
        public void ShouldThrowApExamChapterException()
        {
            Assert.Throws<InvalidApExamChapterException>(() => { Ensure.ApExamChapterIsValid(21); });
        }

        [Test]
        public void ShouldNotThrowApExamChapterException()
        {
            Assert.DoesNotThrow(() => { Ensure.ApExamChapterIsValid(15); });
        }
    }
}
