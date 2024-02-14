using System.Runtime.ExceptionServices;
using Basics;

namespace Tests;
[TestFixture]
public class GenericMethodTests
{
    // [SetUp]
    // public void Setup()
    // {
    // }

    [Test]
    public void TestGenericMothodWithInteger()
    {
        int a = 78;
        int b = 56;

        NonGenericClass.Swap(ref a, ref b);

        Assert.That(a == 56);
        Assert.That(b == 78);
    }

    [Test]
    public void TestGenericMothodWithObject()
    {
        object first = new object();
        object second = new object();

        object originalFirst = first;
        object originalSecond = second;


        NonGenericClass.Swap(ref first, ref second);

        Assert.That(first ==  originalSecond);
        Assert.That(second == originalFirst);
    }    

    [Test]
    public void TestGenericMothodWithString()
    {
        string first = "George";
        string second = "Steve";

        NonGenericClass.Swap(ref first, ref second);

        Assert.That(first ==  "Steve");
        Assert.That(second == "George");
    }    

}