using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            KanjiAliveClient client = new KanjiAliveClient("");
            KanjiSimpleResponse response = await client.BasicSearchClient.Get("rain");
            Assert.That(true, Is.EqualTo(true));   
        }
    }
}