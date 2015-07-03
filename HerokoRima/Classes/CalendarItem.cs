using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mime;

namespace HerokoRima.Classes
{
    public class CalendarItem
    {
        public DateTime sTime;
        public DateTime eTime;
        public string txt;
        public int a;
        public int r;
        public int g;
        public int b;
        HatchStyle pattern;
        Color patternColor;

        public CalendarItem()
        { }

        public CalendarItem(DateTime startTime, DateTime endTime, string text, Color color)
        {
            sTime = startTime;
            eTime = endTime;
           txt = text;
            a = color.A;
            r = color.R;
            g= color.G;
            b = color.B;
        }

    }
}
