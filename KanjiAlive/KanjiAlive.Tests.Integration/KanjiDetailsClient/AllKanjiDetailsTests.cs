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
            KanjiAliveClient Client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiDetailedResponse>> ApiResponse = await Client.KanjiDetailsClient.GetAllKanjiDetails();
            Assert.That(ApiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
