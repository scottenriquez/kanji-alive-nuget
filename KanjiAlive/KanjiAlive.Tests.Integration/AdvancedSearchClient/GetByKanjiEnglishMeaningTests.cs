using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Integration.AdvancedSearchClient
{
    [TestFixture]
    public class GetByKanjiEnglishMeaningTests
    {
        [Test]
        public async Task ShouldGetByKanjiEnglishMeaning()
        {
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiSimpleResponse>> apiResponse = await client.AdvancedSearchClient.SearchByKanjiEnglishMeaning("parent");
            Assert.That(apiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}