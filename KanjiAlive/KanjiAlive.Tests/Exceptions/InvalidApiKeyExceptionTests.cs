using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Exceptions;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Exceptions
{
    [TestFixture]
    public class InvalidApiKeyExceptionTests
    {
        [Test]
        public async Task ShouldThrowInvalidApiKeyException()
        {
            Assert.ThrowsAsync<InvalidApiKeyException>(async () =>
            {
                KanjiAliveClient client = new KanjiAliveClient("thisisaninvalidapikey");
                IApiResponse<List<KanjiSimpleResponse>> apiResponse = await client.BasicSearchClient.Search("rain");
            });
        }
    }
}