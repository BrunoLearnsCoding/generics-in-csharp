using System.Runtime.ExceptionServices;
using Basics;
using FluentAssertions;

namespace Tests;
[TestFixture]
public class GenericClassTests {
    [Test]
    public void TestGenericAddMethod() {
        var repo = new Repository<string>();

        repo.Add("George");

        // Assert.That(repo.All().First() == "George");
        repo.All().FirstOrDefault().Should().NotBeNull();
        repo.All().FirstOrDefault().Should().Be("George");
    }
}