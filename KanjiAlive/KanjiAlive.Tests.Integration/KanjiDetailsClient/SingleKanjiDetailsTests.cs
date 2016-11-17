using System;
using System.Net;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Integration.KanjiDetailsClient
{
    [TestFixture]
    public class SingleKanjiDetailsTests
    {
        [Test]
        public async Task ShouldGetSingleKanjiDetails()
        {
            KanjiAliveClient Client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<KanjiDetailedResponse> ApiResponse = await Client.KanjiDetailsClient.GetSingleKanjiDetails("訪");
            Assert.That(ApiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
