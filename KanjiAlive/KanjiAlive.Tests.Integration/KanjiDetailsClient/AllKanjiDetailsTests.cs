using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Integration.KanjiDetailsClient
{
    [TestFixture]
    public class AllKanjiDetailsTests
    {
        [Test]
        public async Task ShouldExecuteGetAllKanjiDetails()
        {
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiDetailedResponse>> apiResponse = await client.KanjiDetailsClient.GetAllKanjiDetails();
            Assert.That(apiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}