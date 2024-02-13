using System.Runtime.ExceptionServices;
using Basics;

namespace Tests;
[TestFixture]
public class GenericClassTests {
    [Test]
    public void TestGenericAddMethod() {
        var repo = new Repository<string>();

        repo.Add("George");

        Assert.That(repo.All().First() == "George");

    }


}