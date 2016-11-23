using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Integration.BasicSearchClient
{
    [TestFixture]
    public class BasicSearchClientTests
    {
        [Test]
        public async Task ShouldExecuteBasicSearch()
        {
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiSimpleResponse>> apiResponse = await client.BasicSearchClient.Search("rain");
            Assert.That(apiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}