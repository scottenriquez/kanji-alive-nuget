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
            KanjiAliveClient Client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            IApiResponse<List<KanjiSimpleResponse>> ApiResponse = await Client.BasicSearchClient.Get("rain");
            Assert.That(ApiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));   
        }
    }
}