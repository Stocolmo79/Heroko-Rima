﻿using System;
using System.Drawing;

namespace Calendar.NET
{
    /// <summary>
    /// A custom or user-defined event
    /// </summary>
    public class CustomEvent : IEvent
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

        public string StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// CustomEvent Constructor
        /// </summary>
        public CustomEvent()
        {
            Staff = "";
            StartTime = "";
            EndTime = "";
            Attendance = 0;
            MaxAttendance = 0;
            EventColor = Color.FromArgb(255, 80, 80);
            EventFont = new Font("Arial", 8, FontStyle.Bold);
            EventTextColor = Color.FromArgb(255, 255, 255);
            Rank = 2;
            EventLengthInHours = 1.0f;
            ReadOnlyEvent = false;
            Enabled = true;
            IgnoreTimeComponent = false;
            TooltipEnabled = true;
            ThisDayForwardOnly = true;
            RecurringFrequency = RecurringFrequencies.None;
        }

        public IEvent Clone()
        {
            return new CustomEvent
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
                MaxAttendance = MaxAttendance,
                Attendance = Attendance,
                EndTime = EndTime,
                StartTime = StartTime
                
                
            };
        }


      
    }
}