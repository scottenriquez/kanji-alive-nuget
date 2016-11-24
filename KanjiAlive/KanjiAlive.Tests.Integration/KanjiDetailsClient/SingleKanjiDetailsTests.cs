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
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<KanjiDetailedResponse> apiResponse = await client.KanjiDetailsClient.GetSingleKanjiDetails("訪");
            Assert.That(apiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(apiResponse.Content.Kanji.Character, Is.EqualTo("訪"));
        }
    }
}