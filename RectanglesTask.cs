using System;

namespace Rectangles;

public static class RectanglesTask
{
    // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
        int xMax = Math.Min(r1.Left + r1.Width, r2.Left + r2.Width);
        int xMin=Math.Max(r1.Left, r2.Left);
        int yMax=Math.Min(r1.Top+r1.Height, r2.Top + r2.Height);
        int yMin=Math.Max(r1.Top, r2.Top);
        if (xMin <= xMax && yMin <= yMax)
        {
            return true;
        }
        else return false;
    }

    // Площадь пересечения прямоугольников
    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        if(AreIntersected(r1, r2)==true)
        {
            int xMax = Math.Min(r1.Left + r1.Width, r2.Left + r2.Width);
            int xMin = Math.Max(r1.Left, r2.Left);
            int yMax = Math.Min(r1.Top + r1.Height, r2.Top + r2.Height);
            int yMin = Math.Max(r1.Top, r2.Top);
            int a = xMax-xMin;
            int b = yMax-yMin;
            int s = a * b;
            return s;
        }
        else return 0;
    }

    // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
    // Иначе вернуть -1
    // Если прямоугольники совпадают, можно вернуть номер любого из них.
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
        if(r1.Left>=r2.Left&& r1.Left+r1.Width<=r2.Left+r2.Width&& r1.Top>=r2.Top&& r1.Top+r1.Height<=r2.Top+r2.Height)
        {
            return 0;
        }
        if (r2.Left >= r1.Left && r2.Left + r2.Width <= r1.Left + r1.Width && r2.Top >= r1.Top && r2.Top + r2.Height <= r1.Top + r1.Height)
        {
            return 1;
        }
        return -1;
    }
}