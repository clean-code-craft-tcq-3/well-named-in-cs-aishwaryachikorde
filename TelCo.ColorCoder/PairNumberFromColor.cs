using System;

namespace TelCo.ColorCoder
{
  partial class EvenCountColorCode
  {
    /// <summary>
    /// Given the two colors the function returns the pair number corresponding to them
    /// </summary>
    /// <param name="pair">Color pair with major and minor color</param>
    /// <returns></returns>
    private static int GetPairNumberFromColor(ColorPair pair)
    {
      // Find the major color in the array and get the index
      int majorIndex = -1;
      for (int i = 0; i < ColorMap.ColorMapMajor.Length; i++)
      {
        if (ColorMap.ColorMapMajor[i] == pair.MajorColor)
        {
          majorIndex = i;
          break;
        }
      }

      // Find the minor color in the array and get the index
      int minorIndex = -1;
      for (int i = 0; i < ColorMap.ColorMapMinor.Length; i++)
      {
        if (ColorMap.ColorMapMinor[i] == pair.MinorColor)
        {
          minorIndex = i;
          break;
        }
      }
      // If colors can not be found throw an exception
      if (majorIndex == -1 || minorIndex == -1)
      {
        throw new ArgumentException(string.Format("Unknown Colors: {0}", pair));
      }

      // Compute pair number and Return  
      // (Note: +1 in compute is because pair number is 1 based, not zero)
      return (majorIndex * ColorMap.ColorMapMajor.Length) + (minorIndex + 1);
    }
  }
}
