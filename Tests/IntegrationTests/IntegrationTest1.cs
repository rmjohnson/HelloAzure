using System.Net.Http;
using System.Threading.Tasks;
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
			var response = await client.GetAsync("https://faithliferyantest-test.azurewebsites.net/");
			var content = response.Content.ReadAsStringAsync();
			content.Should().Be("Hello Azure!");
		}
	}
}