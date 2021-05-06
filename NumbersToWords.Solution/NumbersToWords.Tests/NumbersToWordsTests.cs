using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordsModels;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberToWordsTest
  {
    [TestMethod]

    public void ShouldReplaceOneWord_Hello_Universe()
    {
      string input = "Hello world";
      NumberConverter converter = new NumberConverter();

      string result = converter.Convert(input);

      string output = "Hello Univers";

      Assert.AreEqual(result, output);
    }

  }
}