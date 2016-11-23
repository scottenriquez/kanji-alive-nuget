using KanjiAlive.Exceptions;
using NUnit.Framework;

namespace KanjiAlive.Tests.Exceptions
{
    [TestFixture]
    public class EmptyApiKeyExceptionTests
    {
        [Test]
        public void ShouldThrowEmptyApiExceptionForEmptyString()
        {
            Assert.Throws<EmptyApiKeyException>(() => new KanjiAliveClient(""));
        }

        [Test]
        public void ShouldThrowEmptyApiExceptionForNull()
        {
            Assert.Throws<EmptyApiKeyException>(() => new KanjiAliveClient(null));
        }
    }
}