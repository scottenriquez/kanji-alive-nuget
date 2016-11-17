using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            Assert.Throws<ApiInternalServerErrorException>(() =>
            {
                Ensure.ResponseIsNotInternalServerError(HttpStatusCode.InternalServerError);
            });
        }
    }
}
