using System;

namespace BinaryString
{
  public class BinaryStringConverter
  {
    /// <summary>
    /// Given a string of 1 and 0, convert the binary number to its integer value.
    /// Assume that the first digit in the string is the least significant bit.
    /// Throw an argument exception if the binaryString parameter is not a valid binary string
    /// </summary>
    /// <param name="binaryString"></param>
    /// <returns></returns>
    public int ConvertString(string binaryString)
    {
      if (string.IsNullOrEmpty(binaryString))
      {
        throw new ArgumentException();
      }

      var sum = 0;

      for (int i = 0; i < binaryString.Length; i++)
      {
        var currentCharacter = binaryString[i];

        if (currentCharacter == '1')
        {
          sum += (int)Math.Pow(2, i);
        }
        if (currentCharacter != '0' && currentCharacter != '1')
        {
          throw new ArgumentException();
        }
      }

      return sum;
    }
  }
}
