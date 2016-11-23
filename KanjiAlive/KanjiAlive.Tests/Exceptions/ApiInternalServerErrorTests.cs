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
    }
}