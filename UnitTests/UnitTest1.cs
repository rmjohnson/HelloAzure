using FluentAssertions;
using NUnit.Framework;

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
			1.Should().Be(1);
		}
	}
}