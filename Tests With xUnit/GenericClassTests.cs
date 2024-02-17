using FluentAssertions;
using Basics;

namespace Tests_With_xUnit;


public class GenericClassTests {

    [Fact]
    public void Test_Swap_With_ReferenceType() {
        
        // Arrange
        var first = new object();
        var second = new object();

        var originalFirst = first;
        var originalSecond = second;

        // Action
        NonGenericClass.Swap(ref first, ref second);

        // Assert
        first.Should().Be(originalSecond);
        second.Should().Be(originalFirst);
    }


}