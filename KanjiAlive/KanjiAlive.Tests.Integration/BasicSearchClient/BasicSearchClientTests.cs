using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            KanjiAliveClient client = new KanjiAliveClient(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            List<KanjiSimpleResponse> response = await client.BasicSearchClient.Get("rain");
            Assert.That(response, !Is.Null);   
        }
    }
}
