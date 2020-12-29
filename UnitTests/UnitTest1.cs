using NUnit.Framework;
using FluentAssertions;

namespace UnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void One_ShouldBeOne()
		{
			"one".Should().Be("one");
		}

		[Test]
		public void One_ShouldNotBeTwo()
		{
			"one".Should().NotBe("two");
		}
	}
}