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
    public class GetByKanjiGradeLevelTests
    {
        [Test]
        public async Task ShouldGetByKanjiGradeLevel()
        {
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiSimpleResponse>> apiResponse = await client.AdvancedSearchClient.SearchByKanjiGradeLevel(2);
            Assert.That(apiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}