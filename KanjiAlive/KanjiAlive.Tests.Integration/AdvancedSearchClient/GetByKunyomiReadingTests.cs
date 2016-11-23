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
    public class GetByKunyomiReadingTests
    {
        [Test]
        public async Task ShouldGetByKunyomiReading()
        {
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiSimpleResponse>> apiResponse = await client.AdvancedSearchClient.SearchByKunyomiReading("oya");
            Assert.That(apiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}