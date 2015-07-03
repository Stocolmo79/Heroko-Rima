using System.Windows.Forms.Calendar;


namespace MakeMake.Classes
{
  public class MonthViews
    {
      public static MonthView LoadMonthView(MonthView mv)
      {
          mv.MonthTitleColor = mv.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
          mv.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
          mv.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
          mv.DaySelectedTextColor = mv.ForeColor;
          return mv;
      }

       
    }
}
