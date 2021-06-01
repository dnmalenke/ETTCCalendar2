using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PublicHoliday;

namespace ETTCCalendar2
{
    public class CustomMonthCalendar : MonthCalendar
    {
        public CustomMonthCalendar()
        {
            ShowWeekNumbers = true;
        }

        public bool ShowHolidays { get; set; } = true;
        public List<DateTime> HighlightedDates { get; set; } = new List<DateTime>();
        public List<DateTime> BlueHighlightedDates { get; set; } = new List<DateTime>();
        public DateTime EndDate { get { return _endDate; } set { _endDate = value.Date; } }

        private DateTime _endDate;
        private List<DateTime> _prevBlueHighlightedDates = new List<DateTime>();
        private List<DateTime> _prevHighlightedDates = new List<DateTime>();
        private List<Point> _cornerPoints = new List<Point>();
        private Size _dateSize;

        protected static int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                Graphics graphics = Graphics.FromHwnd(Handle);
                PaintEventArgs pe = new PaintEventArgs(graphics, new Rectangle(0, 0, Width, Height));
                OnPaint(pe);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Visible)
            {
                Graphics graphics = e.Graphics;

                base.OnPaint(e);

                UpdateHighlightedDates(graphics);
            }
            else
            {
                e.Graphics.Clear(Color.Transparent);
            }
        }

        public void UpdateHighlightedDates(Graphics graphics)
        {
            UpdateCornerPoints();
            UpdateDateSize();

            if(HighlightedDates == null)
            {
                return;
            }

            foreach (var date in HighlightedDates)
            {
                if (date.Date >= GetDisplayRange(true).Start && date.Date <= GetDisplayRange(true).End)
                {
                    var dateRect = GetDateRect(date);

                    graphics.FillRectangle(Brushes.Yellow, dateRect);

                    WriteDateText(date, dateRect, graphics);

                    if (new USAPublicHoliday().IsPublicHoliday(date) && ShowHolidays)
                    {
                        graphics.DrawRectangle(new Pen(Brushes.Red, 1), dateRect.X + 0.5f, dateRect.Y + 0.5f, dateRect.Width - 1f, dateRect.Height - 1f);
                    }
                }
            }

            foreach (var date in _prevHighlightedDates.Except(HighlightedDates))
            {
                if (date.Date >= GetDisplayRange(true).Start && date.Date <= GetDisplayRange(true).End)
                {
                    var dateRect = GetDateRect(date);

                    graphics.FillRectangle(Brushes.White, dateRect);

                    WriteDateText(date, dateRect, graphics);
                }
            }

            foreach (var date in BlueHighlightedDates.Except(HighlightedDates.Except(new List<DateTime> { _endDate })))
            {
                if (date.Date >= GetDisplayRange(true).Start && date.Date <= GetDisplayRange(true).End)
                {
                    var dateRect = GetDateRect(date);
                    if (date.Date == _endDate.Date)
                    {
                        graphics.FillRectangle(Brushes.DeepSkyBlue, dateRect);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.LightBlue, dateRect);
                    }

                    WriteDateText(date, dateRect, graphics);

                    if (new USAPublicHoliday().IsPublicHoliday(date) && ShowHolidays)
                    {
                        graphics.DrawRectangle(new Pen(Brushes.Red, 1), dateRect.X + 0.5f, dateRect.Y + 0.5f, dateRect.Width - 1f, dateRect.Height - 1f);
                    }
                }
            }

            foreach (var date in _prevBlueHighlightedDates.Except(BlueHighlightedDates).Except(HighlightedDates))
            {
                if (date.Date >= GetDisplayRange(true).Start && date.Date <= GetDisplayRange(true).End)
                {
                    var dateRect = GetDateRect(date);

                    graphics.FillRectangle(Brushes.White, dateRect);

                    WriteDateText(date, dateRect, graphics);
                }
            }

            if (SelectionStart.Date >= GetDisplayRange(true).Start && SelectionStart.Date <= GetDisplayRange(true).End)
            {
                var dateRect = GetDateRect(SelectionStart);

                graphics.FillRectangle(Brushes.White, dateRect);

                WriteDateText(SelectionStart.Date, dateRect, graphics);
            }

            HighlightToday(graphics);

            if (HighlightedDates != null && HighlightedDates.Any())
            {
                if (HighlightedDates.First().Date >= GetDisplayRange(true).Start && HighlightedDates.First().Date <= GetDisplayRange(true).End)
                {
                    var dateRect = GetDateRect(HighlightedDates.First());

                    WriteDateText(HighlightedDates.First(), dateRect, graphics);

                    graphics.DrawRectangle(new Pen(Brushes.DeepSkyBlue, 3), dateRect.X + 1.5f, dateRect.Y + 1.5f, dateRect.Width - 3f, dateRect.Height - 3f);
                }
            }

            _prevBlueHighlightedDates = BlueHighlightedDates.ConvertAll(d => new DateTime(d.Ticks));
            _prevHighlightedDates = HighlightedDates.ConvertAll(d => new DateTime(d.Ticks));

        }

        public void HighlightToday(Graphics graphics)
        {
            if (DateTime.Today.Date >= GetDisplayRange(true).Start && DateTime.Today.Date <= GetDisplayRange(true).End)
            {
                var dateRect = GetDateRect(DateTime.Today);

                graphics.FillRectangle(Brushes.Orange, dateRect);

                WriteDateText(DateTime.Today.Date, dateRect, graphics);
            }
        }

        private void WriteDateText(DateTime date, Rectangle dateRect, Graphics graphics)
        {
            var dayFont = new Font(Font.FontFamily, Font.Size, Font.Style, GraphicsUnit.Point, Font.GdiCharSet, Font.GdiVerticalFont);

            var dayStringSize = TextRenderer.MeasureText(graphics, "30", dayFont);

            var textRect = new Rectangle(1 + dateRect.X + (dateRect.Width / 2) - dayStringSize.Width / 2, dateRect.Y, dayStringSize.Width, dateRect.Height);

            TextRenderer.DrawText(graphics, date.Day.ToString(), Font, textRect, Color.Black, TextFormatFlags.Right);
        }

        private void UpdateDateSize()
        {
            _dateSize = GetDateSize(_cornerPoints.First());
        }

        private void UpdateCornerPoints()
        {
            _cornerPoints.Clear();

            for (int i = 0; i < CalendarDimensions.Width; i++)
            {
                _cornerPoints.Add(GetCornerPoint(i));
            }
        }

        private Rectangle GetDateRect(DateTime date)
        {
            int monthOffset = 0;

            for (int i = 0; i < CalendarDimensions.Width; i++)
            {
                if (date.Month == GetDisplayRange(true).Start.AddMonths(i).Month)
                {
                    break;
                }
                else
                {
                    monthOffset++;
                }
            }

            int row = (date.Day + (int)date.Date.AddDays(-date.Day).DayOfWeek) / 7;

            int col = (int)date.DayOfWeek;

            return new Rectangle(new Point(_cornerPoints[monthOffset].X + col * _dateSize.Width, _cornerPoints[0].Y + row * _dateSize.Height), _dateSize);
        }

        private Point GetCornerPoint(int monthNum = 0)
        {
            int y = 0;
            int x = 10 + monthNum * (SingleMonthSize.Width - 1);

            while (HitTest(x, y).HitArea != HitArea.WeekNumbers)
            {
                y++;
                if (HitTest(x, y).HitArea == HitArea.Nowhere)
                {
                    x++;
                }
            }

            while (HitTest(x, y).HitArea == HitArea.WeekNumbers)
            {
                x++;
            }

            x++;

            while (HitTest(x, y).HitArea == HitArea.CalendarBackground)
            {
                y++;
            }

            return new Point(x, y);
        }

        private Size GetDateSize(Point cornerPoint)
        {
            int xOffset = 0;
            int yOffset = 0;
            int width = 1;
            int height = 1;

            while (HitTest(cornerPoint.X + 2, cornerPoint.Y + yOffset).HitArea == HitArea.PrevMonthDate)
            {
                yOffset++;
            }

            while (HitTest(cornerPoint.X + xOffset, cornerPoint.Y + yOffset).HitArea != HitArea.Date)
            {
                xOffset++;
            }

            DateTime prevDate = HitTest(cornerPoint.X + xOffset + width, cornerPoint.Y + yOffset).Time.Date;

            while (HitTest(cornerPoint.X + xOffset + width, cornerPoint.Y + yOffset).Time == prevDate)
            {
                width++;
            }

            prevDate = HitTest(cornerPoint.X + xOffset, cornerPoint.Y + height + yOffset).Time.Date;

            while (HitTest(cornerPoint.X + xOffset, cornerPoint.Y + height + yOffset).Time.Date == prevDate)
            {
                height++;
            }

            return new Size(width, height);
        }
    }
}
