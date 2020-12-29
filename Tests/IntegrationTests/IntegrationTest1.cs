using System.Net.Http;
using FluentAssertions;
using NUnit.Framework;

namespace IntegrationTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public async Task Test1()
		{
			var client = new HttpClient();
			var response = client.GetAsync("https://faithliferyantest-test.azurewebsites.net/");
			var content = response.Content.ReadAsStringAsync();
			content.Should().Be("Hello Azure!");
		}
	}
}