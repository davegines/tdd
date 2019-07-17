using System;
using MultiCurrency;
using Xunit;

namespace UnitTests
{
  public class MultiCurrencyTests
  {
    [Fact]
    public void testMultiplication()
    {
      Dollar five = new Dollar(5);
      five.times(2);
      Assert.Equal(10, five.amount);
    }
  }
}