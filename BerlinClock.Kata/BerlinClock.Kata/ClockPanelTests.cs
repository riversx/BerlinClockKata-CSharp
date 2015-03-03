using NUnit.Framework;
using System;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class ClockPanelTests
    {

        [TestCase(0, 0, 0, "Y")]
        [TestCase(0, 0, 1, "O")]
        [TestCase(0, 0, 2, "Y")]
        public void ClockPanelConstructor_InitWithSeconds_ShowsCorretlyRow1(int hours, int minutes, int seconds, string expected)
        {
            ClockPanel clock = new ClockPanel(new TimeSpan(hours, minutes, seconds));

            Assert.AreEqual(expected, clock.Row1);
        }

        [TestCase(0, 0, 0, "OOOO")]
        [TestCase(0, 1, 0, "YOOO")]
        [TestCase(0, 2, 0, "YYOO")]
        [TestCase(0, 5, 0, "OOOO")]
        public void ClockPanelConstructor_InitWithMinutes_ShowsCorretlyRow5(int hours, int minutes, int seconds, string expected)
        {
            ClockPanel clock = new ClockPanel(new TimeSpan(hours, minutes, seconds));

            Assert.AreEqual(expected, clock.Row5);
        }

        [TestCase(0, 0, 0, "OOOOOOOOOOO")]
        [TestCase(0, 5, 0, "YOOOOOOOOOO")]
        [TestCase(0, 6, 0, "YOOOOOOOOOO")]
        [TestCase(0, 10, 0, "YYOOOOOOOOO")]
        [TestCase(0, 15, 0, "YYROOOOOOOO")]
        public void ClockPanelConstructor_InitWithMinutes_ShowsCorretlyRow4(int hours, int minutes, int seconds, string expected)
        {
            ClockPanel clock = new ClockPanel(new TimeSpan(hours, minutes, seconds));

            Assert.AreEqual(expected, clock.Row4);
        }

        [TestCase(0, 0, 0, "OOOO")]
        [TestCase(1, 0, 0, "ROOO")]
        [TestCase(2, 0, 0, "RROO")]
        [TestCase(5, 0, 0, "OOOO")]
        public void ClockPanelConstructor_InitWithHours_ShowsCorrettlyRow3(int hours, int minutes, int seconds, string expected)
        {
            ClockPanel clock = new ClockPanel(new TimeSpan(hours, minutes, seconds));

            Assert.AreEqual(expected, clock.Row3);
        }

        [TestCase(0, 0, 0, "OOOO")]
        [TestCase(5, 0, 0, "ROOO")]
        [TestCase(15, 0, 0, "RRRO")]
        [TestCase(23, 0, 0, "RRRR")]
        public void ClockPanelConstructor_InitWithHours_ShowsCorrectlyRow2(int hours, int minutes, int seconds, string expected)
        {
            ClockPanel clock = new ClockPanel(new TimeSpan(hours, minutes, seconds));

            Assert.AreEqual(expected, clock.Row2);
        }

        [TestCase(0, 0, 0, "Y\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO")]
        [TestCase(16, 50, 6, "Y\nRRRO\nROOO\nYYRYYRYYRYO\nOOOO")]
        [TestCase(23, 59, 59, "O\nRRRR\nRRRO\nYYRYYRYYRYY\nYYYY")]
        [TestCase(11, 37, 01, "O\nRROO\nROOO\nYYRYYRYOOOO\nYYOO")]
        public void ClockPanelConstructor_InitWithSpecicTime_ShowsCorrectyAllRows(int hours, int minutes, int seconds, string expected)
        {
            ClockPanel clock = new ClockPanel(new TimeSpan(hours, minutes, seconds));

            Assert.AreEqual(expected, clock.ToString());
        }

    }
}
