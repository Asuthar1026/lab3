namespace Calculator.Tests;
public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestSubstract()
    {
        Assert.Equal(7L, Subtract.Eval(8L, 1L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestDivide()
    {
        Assert.Equal(3L, Divide.Eval(12L, 4L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestSubstractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(2, Evaluator.Eval("/", 10, 5));
    }
    [Fact]
    public void TestInvalidOperation()
    {
        Assert.Throws<Exception>(() => Evaluator.Eval("%", 9, 9));
    }

    [Fact]
    public void TestContinueOperations()
    {
        float result1 = Evaluator.Eval("+", 5, 10);
        Assert.Equal(15, result1);
        float result2 = Evaluator.Eval("-", result1, 5);
        Assert.Equal(10, result2);
        float result3 = Evaluator.Eval("*", result2, 2);
        Assert.Equal(20, result3);
        float result4 = Evaluator.Eval("/", result3, 4);
        Assert.Equal(5, result4);
    }
}