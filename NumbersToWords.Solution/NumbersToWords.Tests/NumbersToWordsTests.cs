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

    [TestMethod]
    public void ShouldReplace11_Eleven()
    {
      string input = "11";
      NumberConverter converter = new NumberConverter();

      string result = converter.ConvertNumberToWord(input);

      string output = "eleven";

      Assert.AreEqual(output, result);
    }

    [TestMethod]
    public void ShouldReplace23_TwentyThree()
    {
      string input = "23";
      NumberConverter converter = new NumberConverter();

      string result = converter.ConvertNumberToWord(input);

      string output = "twenty three";

      Assert.AreEqual(output, result);
    }
  }
}
// input = "1"
// convert to int -> wordNumbers[int.input]
// let wordNumbers = ["zero", "one", "two", "three"]

//go backwards through number string
//based on position look up dictionary
// 1253
// check how long to determine what to divide by
// 1253 / 1000 = 1
// 1253 % 1000 = 253
// continue for 100, 10

//dictionary ones = {1, "one"}, ...
//teens, tens
//array of words for hundred, thousands etc
//every number broken up into threes