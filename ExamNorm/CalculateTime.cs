using System;
using System.Collections.Generic;
using System.Text;

namespace ExamNorm
{
    class CalculateTime
    {
        readonly int hour;
        readonly int minute;

        public CalculateTime(int hours, int minutes)
        {
            this.minute = minutes;
            this.hour = hours;
        }

        public double CalculateDegreesMain()
        {
            double hourDegrees = this.hour * 30 + this.minute * 0.5;
            double minuteDegrees = this.minute * 6;
            double result = Math.Abs(hourDegrees - minuteDegrees); 
            return (result == 360) ? 0: result;
        }
    }
}
