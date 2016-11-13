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
                KanjiAliveClient Client = new KanjiAliveClient("thisisaninvalidapikey");
                IApiResponse<List<KanjiSimpleResponse>> ApiResponse = await Client.BasicSearchClient.Get("rain");
            });
        }
    }
}
