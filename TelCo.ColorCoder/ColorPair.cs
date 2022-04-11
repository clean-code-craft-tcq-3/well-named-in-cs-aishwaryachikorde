using System.Drawing;

namespace TelCo.ColorCoder
{
  /// <summary>
  /// The class defined to hold the major and minor color pair
  /// </summary>
  public class ColorPair
  {
    internal Color MajorColor;
    internal Color MinorColor;

    public override string ToString()
    {
      return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
    }
  }
}
