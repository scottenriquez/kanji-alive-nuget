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
            KanjiSimpleResponse controlKanjiSimpleResponse = new KanjiSimpleResponse
            {
                Kanji = new KanjiSimple
                {
                    Character = "雨",
                    Stroke = 8
                },
                Radical = new RadicalSimple
                {
                    Character = "雨",
                    Stroke = 8,
                    Order = 210
                }
            };
            //sample API response data in JSON format
            string json = "{\"kanji\":{\"character\":\"雨\",\"stroke\":8},\"radical\":{\"character\":\"雨\",\"stroke\":8,\"order\":210}}";
            Connection connection = new Connection(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            KanjiSimpleResponse deserializedKanjiSimpleResponse = connection.DeserializeJson<KanjiSimpleResponse>(json);
            //assert
            Assert.That(controlKanjiSimpleResponse, Is.EqualTo(deserializedKanjiSimpleResponse));
        }

        [Test]
        public void ShouldDeserializeJsonToKanjiSimpleResponseList()
        {
            //instantiate control object for testing
            List<KanjiSimpleResponse> controlKanjiSimpleResponses = new List<KanjiSimpleResponse>();
            controlKanjiSimpleResponses.Add(new KanjiSimpleResponse
            {
                Kanji = new KanjiSimple
                {
                    Character = "雨",
                    Stroke = 8
                },
                Radical = new RadicalSimple
                {
                    Character = "雨",
                    Stroke = 8,
                    Order = 210
                }
            });
            //sample API response data in JSON format
            string json = "[{\"kanji\":{\"character\":\"雨\",\"stroke\":8},\"radical\":{\"character\":\"雨\",\"stroke\":8,\"order\":210}}]";
            Connection connection = new Connection(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            List<KanjiSimpleResponse> deserializedKanjiSimpleResponses = connection.DeserializeJson<List<KanjiSimpleResponse>>(json);
            //assert
            Assert.That(controlKanjiSimpleResponses, Is.EqualTo(deserializedKanjiSimpleResponses));
        }
    }
}