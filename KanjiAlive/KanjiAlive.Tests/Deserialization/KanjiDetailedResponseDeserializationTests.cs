using System;
using System.Collections.Generic;
using KanjiAlive.Http;
using KanjiAlive.Models.Core;
using KanjiAlive.Models.Response;
using NUnit.Framework;

namespace KanjiAlive.Tests.Deserialization
{
    [TestFixture]
    public class KanjiDetailedResponseDeserializationTests
    {
        [Test]
        public void ShouldDeserializeJsonToKanjiDetailedResponse()
        {
            //instantiate control objects for testing
            List<double> timings = new List<double>();
            timings.Add(0);
            timings.Add(1);
            timings.Add(1.933333);
            timings.Add(3);
            timings.Add(3.6);
            timings.Add(4.466667);
            timings.Add(5.8);
            timings.Add(6.533333);
            timings.Add(8.266667);
            timings.Add(9.58);
            timings.Add(11.591667);
            timings.Add(17);
            List<string> images = new List<string>();
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_1.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_2.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_3.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_4.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_5.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_6.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_7.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_8.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_9.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_10.svg");
            images.Add("https://media.kanjialive.com/kanji_strokes/otozu(reru)_11.svg");
            List<string> animation = new List<string>();
            animation.Add("https://media.kanjialive.com/rad_frames/gonben0.svg");
            animation.Add("https://media.kanjialive.com/rad_frames/gonben1.svg");
            animation.Add("https://media.kanjialive.com/rad_frames/gonben2.svg");
            List<Example> examples = new List<Example>();
            examples.Add(new Example
            {
                Japanese = "歴訪する（れきほうする）",
                Meaning = new Meaning
                {
                    English = "make a tour of"
                },
                Audio = new Audio
                {
                    Opus = "https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_a.opus",
                    Aac = "https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_a.aac",
                    Ogg = "https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_a.ogg",
                    Mp3 = "https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_a.mp3"
                }
            });
            examples.Add(new Example
            {
                Japanese = "訪問する（ほうもんする）",
                Meaning = new Meaning
                {
                    English = "visit [v.t.]"
                },
                Audio = new Audio
                {
                    Opus = "https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_b.opus",
                    Aac = "https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_b.aac",
                    Ogg = "https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_b.ogg",
                    Mp3 = "https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_b.mp3"
                }
            });
            examples.Add(new Example
            {
                Japanese = "訪れる（おとずれる）",
                Meaning = new Meaning
                {
                    English = "visit [v.i., v.t.]"
                },
                Audio = new Audio
                {
                    Opus = "https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_c.opus",
                    Aac = "https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_c.aac",
                    Ogg = "https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_c.ogg",
                    Mp3 = "https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_c.mp3"
                }
            });
            examples.Add(new Example
            {
                Japanese = "訪ねる（たずねる）",
                Meaning = new Meaning
                {
                    English = "visit [v.t.]"
                },
                Audio = new Audio
                {
                    Opus = "https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_d.opus",
                    Aac = "https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_d.aac",
                    Ogg = "https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_d.ogg",
                    Mp3 = "https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_d.mp3"
                }
            });
            KanjiDetailedResponse controlKanjiDetailedResponse = new KanjiDetailedResponse
            {
                Kanji = new KanjiDetailed
                {
                    Character = "訪",
                    Meaning = new Meaning
                    {
                        English = "visit"
                    },
                    Strokes = new Strokes
                    {
                        Count = 11,
                        Timings = timings,
                        Images = images
                    },
                    Onyomi = new Onyomi
                    {
                        Romaji = "hou",
                        Katakana = "ホウ"
                    },
                    Kunyomi = new Kunyomi
                    {
                        Romaji = "otozureru, tazuneru, otozu, tazu",
                        Hiragana = "おとず、たず"
                    },
                    Video = new Video
                    {
                        Poster = "https://media.kanjialive.com/kanji_strokes/otozu(reru)_11.svg",
                        Mp4 = "https://media.kanjialive.com/kanji_animations/kanji_mp4/otozu(reru)_00.mp4",
                        Webm = "https://media.kanjialive.com/kanji_animations/kanji_webm/otozu(reru)_00.webm"
                    }
                },
                Radical = new RadicalDetailed
                {
                    Character = "a",
                    Strokes = 7,
                    Image = "https://media.kanjialive.com/radical_character/gonben.svg",
                    Position = new Position
                    {
                        Hiragana = "へん",
                        Romaji = "hen",
                        Icon = "https://media.kanjialive.com/rad_positions/hen.svg"
                    },
                    Name = new Name
                    {
                        Hiragana = "ごんべん",
                        Romaji = "gonben"
                    },
                    Meaning = new Meaning
                    {
                        English = "words, to speak, say"
                    },
                    Animation = animation
                },
                References = new References
                {
                    Grade = 6,
                    Kodansha = "985",
                    Classic_Nelson = "4326"
                },
                Examples = examples
            };
            //sample API response data in JSON format
            string json = "{\"kanji\":{\"character\":\"訪\",\"meaning\":{\"english\":\"visit\"},\"strokes\":{\"count\":11,\"timings\":[0,1,1.933333,3,3.6,4.466667,5.8,6.533333,8.266667,9.58,11.591667,17],\"images\":[\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_1.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_2.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_3.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_4.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_5.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_6.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_7.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_8.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_9.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_10.svg\",\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_11.svg\"]},\"onyomi\":{\"romaji\":\"hou\",\"katakana\":\"ホウ\"},\"kunyomi\":{\"romaji\":\"otozureru, tazuneru, otozu, tazu\",\"hiragana\":\"おとず、たず\"},\"video\":{\"poster\":\"https://media.kanjialive.com/kanji_strokes/otozu(reru)_11.svg\",\"mp4\":\"https://media.kanjialive.com/kanji_animations/kanji_mp4/otozu(reru)_00.mp4\",\"webm\":\"https://media.kanjialive.com/kanji_animations/kanji_webm/otozu(reru)_00.webm\"}},\"radical\":{\"character\":\"a\",\"strokes\":7,\"image\":\"https://media.kanjialive.com/radical_character/gonben.svg\",\"position\":{\"hiragana\":\"へん\",\"romaji\":\"hen\",\"icon\":\"https://media.kanjialive.com/rad_positions/hen.svg\"},\"name\":{\"hiragana\":\"ごんべん\",\"romaji\":\"gonben\"},\"meaning\":{\"english\":\"words, to speak, say\"},\"animation\":[\"https://media.kanjialive.com/rad_frames/gonben0.svg\",\"https://media.kanjialive.com/rad_frames/gonben1.svg\",\"https://media.kanjialive.com/rad_frames/gonben2.svg\"]},\"references\":{\"grade\":6,\"kodansha\":\"985\",\"classic_nelson\":\"4326\"},\"examples\":[{\"japanese\":\"歴訪する（れきほうする）\",\"meaning\":{\"english\":\"make a tour of\"},\"audio\":{\"opus\":\"https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_a.opus\",\"aac\":\"https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_a.aac\",\"ogg\":\"https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_a.ogg\",\"mp3\":\"https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_a.mp3\"}},{\"japanese\":\"訪問する（ほうもんする）\",\"meaning\":{\"english\":\"visit [v.t.]\"},\"audio\":{\"opus\":\"https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_b.opus\",\"aac\":\"https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_b.aac\",\"ogg\":\"https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_b.ogg\",\"mp3\":\"https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_b.mp3\"}},{\"japanese\":\"訪れる（おとずれる）\",\"meaning\":{\"english\":\"visit [v.i., v.t.]\"},\"audio\":{\"opus\":\"https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_c.opus\",\"aac\":\"https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_c.aac\",\"ogg\":\"https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_c.ogg\",\"mp3\":\"https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_c.mp3\"}},{\"japanese\":\"訪ねる（たずねる）\",\"meaning\":{\"english\":\"visit [v.t.]\"},\"audio\":{\"opus\":\"https://media.kanjialive.com/examples_audio/audio-opus/otozu(reru)_06_d.opus\",\"aac\":\"https://media.kanjialive.com/examples_audio/audio-aac/otozu(reru)_06_d.aac\",\"ogg\":\"https://media.kanjialive.com/examples_audio/audio-ogg/otozu(reru)_06_d.ogg\",\"mp3\":\"https://media.kanjialive.com/examples_audio/audio-mp3/otozu(reru)_06_d.mp3\"}}]}";
            Connection connection = new Connection(Environment.GetEnvironmentVariable("MASHAPE_API_KEY", EnvironmentVariableTarget.Machine));
            KanjiDetailedResponse deserializedKanjiDetailedResponse = connection.DeserializeJson<KanjiDetailedResponse>(json);
            Assert.That(controlKanjiDetailedResponse, Is.EqualTo(deserializedKanjiDetailedResponse));
        }
    }
}