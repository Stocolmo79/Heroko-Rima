﻿using System;
using System.Drawing;

namespace Calendar.NET
{
    /// <summary>
    /// An event that defines a holiday
    /// </summary>
    public class HolidayEvent : IEvent
    {
        public int? Attendance
        {
            get;
            set;
        }

        public int? MaxAttendance
        {
            get;
            set;
        }
        public int Rank
        {
            get;
            set;
        }

        public float EventLengthInHours
        {
            get;
            set;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public string Staff
        {
            get;
            set;
        }

        public CustomRecurringFrequenciesHandler CustomRecurringFunction
        {
            get;
            set;
        }

        public bool IgnoreTimeComponent
        {
            get;
            set;
        }

        public bool ReadOnlyEvent
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public Color EventColor
        {
            get;
            set;
        }

        public Font EventFont
        {
            get;
            set;
        }

        public string EventText
        {
            get;
            set;
        }

        public Color EventTextColor
        {
            get;
            set;
        }

        public RecurringFrequencies RecurringFrequency
        {
            get;
            set;
        }

        public bool TooltipEnabled
        {
            get;
            set;
        }

        public bool ThisDayForwardOnly
        {
            get;
            set;
        }
        public string EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// HolidayEvent Constructor
        /// </summary>
        public HolidayEvent()
        {
            Staff = "";
            Attendance = 0;
            MaxAttendance = 0;
            EventColor = Color.FromArgb(80, 170, 255);
            EventFont = new Font("Arial", 8, FontStyle.Bold);
            EventTextColor = Color.FromArgb(255, 255, 255);
            Rank = 1;
            EventLengthInHours = 24;
            ReadOnlyEvent = true;
            Enabled = true;
            IgnoreTimeComponent = true;
            TooltipEnabled = true;
            ThisDayForwardOnly = false;
            RecurringFrequency = RecurringFrequencies.None;
        }

        public IEvent Clone()
        {
            return new HolidayEvent
                         {
                             Staff = Staff,
                             CustomRecurringFunction = CustomRecurringFunction,
                             Date = Date,
                             Enabled = Enabled,
                             EventColor = EventColor,
                             EventFont = EventFont,
                             EventText = EventText,
                             EventTextColor = EventTextColor,
                             IgnoreTimeComponent = IgnoreTimeComponent,
                             Rank = Rank,
                             ReadOnlyEvent = ReadOnlyEvent,
                             RecurringFrequency = RecurringFrequency,
                             ThisDayForwardOnly = ThisDayForwardOnly,
                             EventLengthInHours = EventLengthInHours,
                             TooltipEnabled = TooltipEnabled,
                             Attendance = Attendance,
                             MaxAttendance = MaxAttendance
                         };
        }



    }
}
