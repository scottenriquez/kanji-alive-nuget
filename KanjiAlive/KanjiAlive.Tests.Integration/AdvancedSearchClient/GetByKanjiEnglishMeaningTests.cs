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
            KanjiAliveClient Client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            IApiResponse<List<KanjiSimpleResponse>> ApiResponse = await Client.AdvancedSearchClient.GetByKanjiEnglishMeaning("parent");
            Assert.That(ApiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
