# Kanji Alive Public API NuGet Package
This NuGet package provides a C# interface to easily query and fetch kanji data from the [Kanji Alive](https://kanjialive.com/) public API. This package is designed to simplify development of Japanese learning desktop and web applications on the C#/.NET platform.

# Usage
All of the API endpoints are accessible using the <code>KanjiAliveClient</code>. To use the client, simply instantiate while passing your Mashape API key as the sole constructor parameter. You can obtain an API key [here](https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji).

<code>KanjiAliveClient client = new KanjiAliveClient("MY_API_KEY");</code>

Nested inside of the main client are three subclients that mirror the structure of the API endpoints: <code>AdvancedSearchClient</code>, <code>BasicSearchClient</code>, and <code>KanjiDetailsClient</code>. The endpoints are exposed as asynchronous instance methods, so be sure to <code>await</code> them.

<code>var apiResponse = await client.AdvancedSearchClient.SearchByKanjiStrokeNumber(5);</code>

# Contributing
In order to obfuscate your API key for integration tests, add your API key to the Windows Registry as a string value with the key set to <code>MASHAPE_API_KEY</code>. This allows you to discreetly fetch your key using <code>Environment.GetEnvironmentVariable("MASHAPE_API_KEY")</code> instead of exposing it in the source code.

Please ensure that any code additions follow the styling laid out in the <code>.DotSettings</code> file and that all unit and integration tests pass before submitting a pull request.

For break fixes, please add tests. For any questions, issues, or enhancements, please use the issue tracker for this repository.

# Build Information
[![Build Status](https://travis-ci.org/scottenriquez/kanji-alive-nuget.svg?branch=master)](https://travis-ci.org/scottenriquez/kanji-alive-nuget)

# Thanks
Special thanks to the Kanji Alive team for not only providing their kanji data in a clean, consumable format, but also for hosting a RESTful API to expose it too. Note that if you would like to include this kanji data locally in your project, you can download the language data and media directly from [this repo](https://github.com/kanjialive/data-media).
