using System;

namespace TelCo.ColorCoder
{
  internal class ReferenceManual
  {
    internal static void PrintReferenceManual()
    {
      Console.WriteLine("\n");
      Console.WriteLine("****************************************     Reference Manual     *************************************************");
      Console.WriteLine("\n");

      int totalPair = ColorMap.ColorMapMajor.Length * ColorMap.ColorMapMinor.Length;

      for (int i = 0; i < totalPair; i++)
      {
        ColorPair pair = EvenCountColorCode.GetColorFromPairNumber(i + 1);

        Console.WriteLine(string.Format("Pair Number - {0}, Major Color - {1}, Minor Color - {2}", i + 1, pair.MajorColor.Name, pair.MinorColor.Name));
        Console.WriteLine("\n");

      }
    }
  }
}
