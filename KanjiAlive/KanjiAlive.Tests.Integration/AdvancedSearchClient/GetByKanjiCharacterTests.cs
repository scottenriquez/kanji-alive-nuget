using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Integration.AdvancedSearchClient
{
    [TestFixture]
    public class GetByKanjiCharacterTests
    {
        [Test]
        public async Task ShouldGetByKanjiCharacter()
        {
            KanjiAliveClient Client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY"));
            IApiResponse<List<KanjiSimpleResponse>> ApiResponse = await Client.AdvancedSearchClient.SearchByKanjiCharacter("訪");
            Assert.That(ApiResponse.HttpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
