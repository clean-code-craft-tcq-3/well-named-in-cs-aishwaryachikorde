using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  partial class EvenCountColorCode
  {
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    private static void Main()
    {
      int pairNumber = 4;
      ColorPair testPair1 = EvenCountColorCode.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.MajorColor == Color.White);
      Debug.Assert(testPair1.MinorColor == Color.Brown);

      pairNumber = 5;
      testPair1 = EvenCountColorCode.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.MajorColor == Color.White);
      Debug.Assert(testPair1.MinorColor == Color.SlateGray);

      pairNumber = 23;
      testPair1 = EvenCountColorCode.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.MajorColor == Color.Violet);
      Debug.Assert(testPair1.MinorColor == Color.Green);

      ColorPair testPair2 = new ColorPair() { MajorColor = Color.Yellow, MinorColor = Color.Green };
      pairNumber = EvenCountColorCode.GetPairNumberFromColor(testPair2);
      Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
      Debug.Assert(pairNumber == 18);

      testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Blue };
      pairNumber = EvenCountColorCode.GetPairNumberFromColor(testPair2);
      Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
      Debug.Assert(pairNumber == 6);

      ReferenceManual.PrintReferenceManual();
    }
  }
}
