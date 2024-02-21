using System;
using Xunit;

public class ShapeTests
{
    [Fact]
    public void TestCircleArea()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.GetArea(), 2);
    }

    [Fact]
    public void TestTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.GetArea(), 2);
    }

    [Fact]
    public void TestRightTriangleCheck()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        Assert.True(rightTriangle.IsRightTriangle());

        var nonRightTriangle = new Triangle(3, 4, 6);
        Assert.False(nonRightTriangle.IsRightTriangle());
    }
}
