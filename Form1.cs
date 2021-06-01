using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETTCCalendar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = (FormBorderStyle)BorderStyle.FixedSingle;
        }

        private DateTime _endDate;

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            UpdateDates();
            AnimationWaitTimer.Enabled = true;
        }

        private void AnimationWaitTimerTick(object sender, EventArgs e)
        {
            UpdateDates(false);
            AnimationWaitTimer.Enabled = false;
        }

        private void ClipboardButtonClick(object sender, EventArgs e)
        {
            Graphics g1 = CreateGraphics();
            Image formImage = new Bitmap(ClientRectangle.Width, ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(formImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            Clipboard.SetDataObject(formImage);
        }

        private void NextMonthButtonClick(object sender, EventArgs e)
        {
            ProjectEndCalendar.SetSelectionRange(ProjectEndCalendar.GetDisplayRange(true).End.AddMonths(1), ProjectEndCalendar.GetDisplayRange(true).End.AddMonths(1));

            UpdateDates(false);
            AnimationWaitTimer.Enabled = true;
        }

        private void PrevMonthButtonClick(object sender, EventArgs e)
        {
            ProjectEndCalendar.SetSelectionRange(ProjectEndCalendar.GetDisplayRange(true).Start.AddMonths(-1), ProjectEndCalendar.GetDisplayRange(true).Start.AddMonths(-1));

            UpdateDates(false);
            AnimationWaitTimer.Enabled = true;
        }

        private void HolidayToggleButtonClick(object sender, EventArgs e)
        {
            CurrentCalendar.ShowHolidays = !CurrentCalendar.ShowHolidays;
            ProjectEndCalendar.ShowHolidays = !ProjectEndCalendar.ShowHolidays;

            if (CurrentCalendar.ShowHolidays)
            {
                HolidayToggleButton.Text = "Hide Holidays";
            }
            else
            {
                HolidayToggleButton.Text = "Show Holidays";
            }

            UpdateDates(false);
        }

        private void SingleCheckboxChanged(object sender, EventArgs e)
        {
            LengthEndPicker.Visible = !SingleCheckbox.Checked;
            label1.Visible = !SingleCheckbox.Checked;
        }

        private void StartDateLegendLabelPaint(object sender, PaintEventArgs e)
        {
           e.Graphics.DrawRectangle(new Pen(Brushes.DeepSkyBlue, 3), StartDateLegendLabel.DisplayRectangle.X + 1.5f, StartDateLegendLabel.DisplayRectangle.Y + 1.5f, StartDateLegendLabel.DisplayRectangle.Width - 3f, StartDateLegendLabel.DisplayRectangle.Height - 3f);
        }

        private void HolidayLegendLabelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Brushes.Red, 1), HolidayLegendLabel.DisplayRectangle.X + 0.5f, HolidayLegendLabel.DisplayRectangle.Y + 0.5f, HolidayLegendLabel.DisplayRectangle.Width - 1f, HolidayLegendLabel.DisplayRectangle.Height - 1f);
        }

        private void AboutButtonClick(object sender, EventArgs e)
        {
            var ab = new AboutBox1();
            ab.Show();
        }

        private void UpdateDates(bool changeSelection = true)
        {
            if (SingleCheckbox.Checked)
            {
                LengthEndPicker.Value = LengthStartPicker.Value;
            }


            if (LengthEndPicker.Value <= 0 || LengthEndPicker.Value < LengthStartPicker.Value)
            {
                return;
            }

            if (DaysRadioButton.Checked)
            {
                _endDate = StartDatePicker.Value.AddDays((int)LengthEndPicker.Value);
                if (changeSelection)
                {
                    ProjectEndCalendar.SetSelectionRange(_endDate.AddMonths(-1), _endDate.AddMonths(-1));
                    ProjectEndCalendar.SetSelectionRange(_endDate.AddMonths(1), _endDate.AddMonths(1));
                }

                CurrentCalendar.BlueHighlightedDates = _endDate.AddDays(-(int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1).To(_endDate);
                ProjectEndCalendar.BlueHighlightedDates = _endDate.AddDays(-(int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1).To(_endDate);

                ETTCResultBox.Text = $"{_endDate.AddDays(-(int)(LengthEndPicker.Value - LengthStartPicker.Value)).To(_endDate).First().ToShortDateString()}";

                if (!SingleCheckbox.Checked)
                {
                    ETTCResultBox.Text += $" to {_endDate.AddDays(-(int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1).To(_endDate).Last().ToShortDateString()}";
                }

                CurrentCalendar.HighlightedDates = StartDatePicker.Value.To(_endDate.AddDays(-(int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1));
                ProjectEndCalendar.HighlightedDates = StartDatePicker.Value.To(_endDate.AddDays(-(int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1));
            }
            else
            {
                _endDate = StartDatePicker.Value.AddDays(7 * (int)LengthEndPicker.Value);

                if (changeSelection)
                {
                    ProjectEndCalendar.SetSelectionRange(_endDate.AddMonths(-1), _endDate.AddMonths(-1));
                    ProjectEndCalendar.SetSelectionRange(_endDate.AddMonths(1), _endDate.AddMonths(1));
                }
                CurrentCalendar.BlueHighlightedDates = _endDate.AddDays(-7 * (int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1).To(_endDate);
                ProjectEndCalendar.BlueHighlightedDates = _endDate.AddDays(-7 * (int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1).To(_endDate);

                ETTCResultBox.Text = $"{_endDate.AddDays(-7 * (int)(LengthEndPicker.Value - LengthStartPicker.Value)).To(_endDate).First().ToShortDateString()}";

                if (!SingleCheckbox.Checked)
                {
                    ETTCResultBox.Text += $" to {_endDate.AddDays(-7 * (int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1).To(_endDate).Last().ToShortDateString()}";
                }

                CurrentCalendar.HighlightedDates = StartDatePicker.Value.To(_endDate.AddDays(-7 * (int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1));
                ProjectEndCalendar.HighlightedDates = StartDatePicker.Value.To(_endDate.AddDays(-7 * (int)(LengthEndPicker.Value - LengthStartPicker.Value) - 1));
            }

            CurrentCalendar.EndDate = _endDate;
            ProjectEndCalendar.EndDate = _endDate;

            CurrentCalendar.UpdateHighlightedDates(CurrentCalendar.CreateGraphics());
            ProjectEndCalendar.UpdateHighlightedDates(ProjectEndCalendar.CreateGraphics());

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool BitBlt(
           IntPtr hdcDest, // handle to destination DC 
           int nXDest, // x-coord of destination upper-left corner 
           int nYDest, // y-coord of destination upper-left corner 
           int nWidth, // width of destination rectangle 
           int nHeight, // height of destination rectangle 
           IntPtr hdcSrc, // handle to source DC 
           int nXSrc, // x-coordinate of source upper-left corner 
           int nYSrc, // y-coordinate of source upper-left corner 
           int dwRop // raster operation code 
       );
    }
}
