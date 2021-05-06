
using System.Collections.Generic;

namespace NumberToWordsModels
{
  public class NumberConverter
  {
    public string Convert(string wholeWord, string replaceWord, string wordToInsert)
    {
      return wholeWord.Replace(replaceWord, wordToInsert);
    }

    public string ConvertNumberToWord(string numString)
    {
      return "one";
    }
  }
}