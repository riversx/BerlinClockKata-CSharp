using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{

    public class ClockPanel
    {

        public string Row1 { get; private set; }

        public object Row2 { get; private set; }

        public string Row3 { get; private set; }

        public string Row4 { get; private set; }

        public string Row5 { get; private set; }

        private ClockPanel() { }

        public ClockPanel(TimeSpan time)
        {
            SetRow1(time.Seconds);
            SetRow2(time.Hours / 5);
            SetRow3(time.Hours % 5);
            SetRow4(time.Minutes / 5);
            SetRow5(time.Minutes % 5);
        }

        private void SetRow1(int seconds)
        {
            Row1 = (seconds % 2 == 0) ? "Y" : "O";
        }

        private void SetRow2(int fiveHours)
        {
            Row2 = "RRRR".Substring(0, fiveHours) + "OOOO".Substring(fiveHours);
        }

        private void SetRow3(int lastFiveHours)
        {
            Row3 = "RRRR".Substring(0, lastFiveHours) + "OOOO".Substring(lastFiveHours);
        }

        private void SetRow4(int fiveMinutes)
        {
            Row4 = "YYRYYRYYRYY".Substring(0,fiveMinutes) + "OOOOOOOOOOO".Substring(fiveMinutes);
        }

        private void SetRow5(int lastFiveMinutes)
        {
            Row5 = "YYYY".Substring(0, lastFiveMinutes) + "OOOO".Substring(lastFiveMinutes);
        }

        public override string ToString()
        {
            return Row1 + "\n" + Row2 + "\n" + Row3 + "\n" + Row4 + "\n" + Row5;
        }

    }

}
