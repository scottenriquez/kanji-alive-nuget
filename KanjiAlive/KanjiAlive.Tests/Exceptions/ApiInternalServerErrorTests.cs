using System.Net;
using KanjiAlive.Exceptions;
using KanjiAlive.Helpers;
using NUnit.Framework;

namespace KanjiAlive.Tests.Exceptions
{
    [TestFixture]
    public class ApiInternalServerErrorTests
    {
        [Test]
        public void ShouldThrowApiInternalServerErrorException()
        {
            Assert.Throws<ApiInternalServerErrorException>(() => { Ensure.ResponseIsNotInternalServerError(HttpStatusCode.InternalServerError); });
        }

        [Test]
        public void ShouldNotThrowApiInternalServerErrorException()
        {
            Assert.DoesNotThrow(() => { Ensure.ResponseIsNotInternalServerError(HttpStatusCode.OK); });
        }
    }
}