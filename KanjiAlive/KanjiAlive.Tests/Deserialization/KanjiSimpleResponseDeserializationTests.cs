using System;
using System.Collections.Generic;
using KanjiAlive.Http;
using KanjiAlive.Models.Core;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Deserialization
{
    [TestFixture]
    public class KanjiSimpleResponseDeserializationTests
    {
        [Test]
        public void ShouldDeserializeJsonToKanjiSimpleResponse()
        {
            //instantiate control object for testing
            KanjiSimpleResponse ControlKanjiSimpleResponse = new KanjiSimpleResponse()
            {
                Kanji = new KanjiSimple()
                {
                    Character = "雨",
                    Stroke = 8
                },
                Radical = new RadicalSimple()
                {
                    Character = "雨",
                    Stroke = 8,
                    Order = 210
                }
            };
            //sample API response data in JSON format
            string Json = "{\"kanji\":{\"character\":\"雨\",\"stroke\":8},\"radical\":{\"character\":\"雨\",\"stroke\":8,\"order\":210}}";
            Connection Connection = new Connection(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            KanjiSimpleResponse DeserializedKanjiSimpleResponse = Connection.DeserializeJson<KanjiSimpleResponse>(Json);
            //assert
            Assert.That(ControlKanjiSimpleResponse, Is.EqualTo(DeserializedKanjiSimpleResponse));

        }

        [Test]
        public void ShouldDeserializeJsonToKanjiSimpleResponseList()
        {
            //instantiate control object for testing
            List<KanjiSimpleResponse> ControlKanjiSimpleResponses = new List<KanjiSimpleResponse>();
            ControlKanjiSimpleResponses.Add(new KanjiSimpleResponse()
            {
                Kanji = new KanjiSimple()
                {
                    Character = "雨",
                    Stroke = 8
                },
                Radical = new RadicalSimple()
                {
                    Character = "雨",
                    Stroke = 8,
                    Order = 210
                }
            });
            //sample API response data in JSON format
            string Json = "[{\"kanji\":{\"character\":\"雨\",\"stroke\":8},\"radical\":{\"character\":\"雨\",\"stroke\":8,\"order\":210}}]";
            Connection Connection = new Connection(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            List<KanjiSimpleResponse> DeserializedKanjiSimpleResponses = Connection.DeserializeJson<List<KanjiSimpleResponse>>(Json);
            //assert
            Assert.That(ControlKanjiSimpleResponses, Is.EqualTo(DeserializedKanjiSimpleResponses));

        }
    }
}
