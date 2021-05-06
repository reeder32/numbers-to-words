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

      string result = converter.Convert(input, "world", "Universe");

      string output = "Hello Universe";

      Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ShouldReplaceCatWithDog_ConvertedString()
    {
      string input = "I am walking my cat to the cathedral";
      NumberConverter converter = new NumberConverter();

      string result = converter.Convert(input, "cat", "dog");

      string output = "I am walking my dog to the doghedral";

      Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ShouldReplace1_One()
    {
      string input = "1";
      NumberConverter converter = new NumberConverter();

      string result = converter.ConvertNumberToWord(input);

      string output = "one";

      Assert.AreEqual(result, output);
    }
  }
}