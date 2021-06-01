namespace ETTCCalendar2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrentCalendar = new ETTCCalendar2.CustomMonthCalendar();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateBox = new System.Windows.Forms.GroupBox();
            this.ETTCGroupBox = new System.Windows.Forms.GroupBox();
            this.ETTCResultBox = new System.Windows.Forms.RichTextBox();
            this.ProjectLengthBox = new System.Windows.Forms.GroupBox();
            this.SingleCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LengthEndPicker = new System.Windows.Forms.NumericUpDown();
            this.WeeksRadioButton = new System.Windows.Forms.RadioButton();
            this.DaysRadioButton = new System.Windows.Forms.RadioButton();
            this.LengthStartPicker = new System.Windows.Forms.NumericUpDown();
            this.ProjectEndCalendar = new ETTCCalendar2.CustomMonthCalendar();
            this.AnimationWaitTimer = new System.Windows.Forms.Timer(this.components);
            this.ClipboardButton = new System.Windows.Forms.Button();
            this.PrevMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.ShowEndButton = new System.Windows.Forms.Button();
            this.HolidayToggleButton = new System.Windows.Forms.Button();
            this.LegendGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HolidayLegendLabel = new System.Windows.Forms.Label();
            this.StartDateLegendLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.StartDateBox.SuspendLayout();
            this.ETTCGroupBox.SuspendLayout();
            this.ProjectLengthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthEndPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthStartPicker)).BeginInit();
            this.LegendGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentCalendar
            // 
            this.CurrentCalendar.BlueHighlightedDates = null;
            this.CurrentCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.CurrentCalendar.Enabled = false;
            this.CurrentCalendar.EndDate = new System.DateTime(((long)(0)));
            this.CurrentCalendar.HighlightedDates = null;
            this.CurrentCalendar.Location = new System.Drawing.Point(2, 2);
            this.CurrentCalendar.Name = "CurrentCalendar";
            this.CurrentCalendar.ShowHolidays = true;
            this.CurrentCalendar.ShowToday = false;
            this.CurrentCalendar.ShowTodayCircle = false;
            this.CurrentCalendar.ShowWeekNumbers = true;
            this.CurrentCalendar.TabIndex = 0;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(6, 22);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(135, 23);
            this.StartDatePicker.TabIndex = 1;
            // 
            // StartDateBox
            // 
            this.StartDateBox.Controls.Add(this.StartDatePicker);
            this.StartDateBox.Location = new System.Drawing.Point(8, 166);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(153, 60);
            this.StartDateBox.TabIndex = 2;
            this.StartDateBox.TabStop = false;
            this.StartDateBox.Text = "Start Date";
            // 
            // ETTCGroupBox
            // 
            this.ETTCGroupBox.Controls.Add(this.ETTCResultBox);
            this.ETTCGroupBox.Location = new System.Drawing.Point(518, 188);
            this.ETTCGroupBox.Name = "ETTCGroupBox";
            this.ETTCGroupBox.Size = new System.Drawing.Size(261, 56);
            this.ETTCGroupBox.TabIndex = 2;
            this.ETTCGroupBox.TabStop = false;
            this.ETTCGroupBox.Text = "Estimated Time to Complete";
            // 
            // ETTCResultBox
            // 
            this.ETTCResultBox.BackColor = System.Drawing.Color.White;
            this.ETTCResultBox.Location = new System.Drawing.Point(6, 22);
            this.ETTCResultBox.Name = "ETTCResultBox";
            this.ETTCResultBox.ReadOnly = true;
            this.ETTCResultBox.Size = new System.Drawing.Size(250, 23);
            this.ETTCResultBox.TabIndex = 10;
            this.ETTCResultBox.TabStop = false;
            this.ETTCResultBox.Text = "";
            // 
            // ProjectLengthBox
            // 
            this.ProjectLengthBox.Controls.Add(this.SingleCheckbox);
            this.ProjectLengthBox.Controls.Add(this.UpdateButton);
            this.ProjectLengthBox.Controls.Add(this.label1);
            this.ProjectLengthBox.Controls.Add(this.LengthEndPicker);
            this.ProjectLengthBox.Controls.Add(this.WeeksRadioButton);
            this.ProjectLengthBox.Controls.Add(this.DaysRadioButton);
            this.ProjectLengthBox.Controls.Add(this.LengthStartPicker);
            this.ProjectLengthBox.Location = new System.Drawing.Point(180, 166);
            this.ProjectLengthBox.Name = "ProjectLengthBox";
            this.ProjectLengthBox.Size = new System.Drawing.Size(317, 78);
            this.ProjectLengthBox.TabIndex = 3;
            this.ProjectLengthBox.TabStop = false;
            this.ProjectLengthBox.Text = "Project Length";
            // 
            // SingleCheckbox
            // 
            this.SingleCheckbox.AutoSize = true;
            this.SingleCheckbox.Location = new System.Drawing.Point(164, 12);
            this.SingleCheckbox.Name = "SingleCheckbox";
            this.SingleCheckbox.Size = new System.Drawing.Size(58, 19);
            this.SingleCheckbox.TabIndex = 1;
            this.SingleCheckbox.TabStop = false;
            this.SingleCheckbox.Text = "Single";
            this.SingleCheckbox.UseVisualStyleBackColor = true;
            this.SingleCheckbox.CheckedChanged += new System.EventHandler(this.SingleCheckboxChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(230, 22);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // LengthEndPicker
            // 
            this.LengthEndPicker.Location = new System.Drawing.Point(94, 22);
            this.LengthEndPicker.Name = "LengthEndPicker";
            this.LengthEndPicker.Size = new System.Drawing.Size(54, 23);
            this.LengthEndPicker.TabIndex = 3;
            this.LengthEndPicker.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // WeeksRadioButton
            // 
            this.WeeksRadioButton.AutoSize = true;
            this.WeeksRadioButton.Checked = true;
            this.WeeksRadioButton.Location = new System.Drawing.Point(164, 50);
            this.WeeksRadioButton.Name = "WeeksRadioButton";
            this.WeeksRadioButton.Size = new System.Drawing.Size(59, 19);
            this.WeeksRadioButton.TabIndex = 2;
            this.WeeksRadioButton.TabStop = true;
            this.WeeksRadioButton.Text = "Weeks";
            this.WeeksRadioButton.UseVisualStyleBackColor = true;
            // 
            // DaysRadioButton
            // 
            this.DaysRadioButton.AutoSize = true;
            this.DaysRadioButton.Location = new System.Drawing.Point(164, 31);
            this.DaysRadioButton.Name = "DaysRadioButton";
            this.DaysRadioButton.Size = new System.Drawing.Size(50, 19);
            this.DaysRadioButton.TabIndex = 1;
            this.DaysRadioButton.Text = "Days";
            this.DaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // LengthStartPicker
            // 
            this.LengthStartPicker.Location = new System.Drawing.Point(7, 22);
            this.LengthStartPicker.Name = "LengthStartPicker";
            this.LengthStartPicker.Size = new System.Drawing.Size(56, 23);
            this.LengthStartPicker.TabIndex = 2;
            this.LengthStartPicker.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ProjectEndCalendar
            // 
            this.ProjectEndCalendar.BlueHighlightedDates = null;
            this.ProjectEndCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.ProjectEndCalendar.Enabled = false;
            this.ProjectEndCalendar.EndDate = new System.DateTime(((long)(0)));
            this.ProjectEndCalendar.HighlightedDates = null;
            this.ProjectEndCalendar.Location = new System.Drawing.Point(506, 2);
            this.ProjectEndCalendar.Name = "ProjectEndCalendar";
            this.ProjectEndCalendar.ShowHolidays = true;
            this.ProjectEndCalendar.ShowToday = false;
            this.ProjectEndCalendar.ShowTodayCircle = false;
            this.ProjectEndCalendar.ShowWeekNumbers = true;
            this.ProjectEndCalendar.TabIndex = 4;
            // 
            // AnimationWaitTimer
            // 
            this.AnimationWaitTimer.Interval = 500;
            this.AnimationWaitTimer.Tick += new System.EventHandler(this.AnimationWaitTimerTick);
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.Location = new System.Drawing.Point(901, 159);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.Size = new System.Drawing.Size(112, 23);
            this.ClipboardButton.TabIndex = 6;
            this.ClipboardButton.TabStop = false;
            this.ClipboardButton.Text = "Copy to Clipboard";
            this.ClipboardButton.UseVisualStyleBackColor = true;
            this.ClipboardButton.Click += new System.EventHandler(this.ClipboardButtonClick);
            // 
            // PrevMonthButton
            // 
            this.PrevMonthButton.Location = new System.Drawing.Point(517, 159);
            this.PrevMonthButton.Name = "PrevMonthButton";
            this.PrevMonthButton.Size = new System.Drawing.Size(118, 23);
            this.PrevMonthButton.TabIndex = 7;
            this.PrevMonthButton.Text = "<- Previous Month";
            this.PrevMonthButton.UseVisualStyleBackColor = true;
            this.PrevMonthButton.Click += new System.EventHandler(this.PrevMonthButtonClick);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Location = new System.Drawing.Point(1142, 159);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(107, 23);
            this.NextMonthButton.TabIndex = 8;
            this.NextMonthButton.Text = "Next Month ->";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButtonClick);
            // 
            // ShowEndButton
            // 
            this.ShowEndButton.Location = new System.Drawing.Point(799, 159);
            this.ShowEndButton.Name = "ShowEndButton";
            this.ShowEndButton.Size = new System.Drawing.Size(75, 23);
            this.ShowEndButton.TabIndex = 9;
            this.ShowEndButton.TabStop = false;
            this.ShowEndButton.Text = "Show End";
            this.ShowEndButton.UseVisualStyleBackColor = true;
            this.ShowEndButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // HolidayToggleButton
            // 
            this.HolidayToggleButton.Location = new System.Drawing.Point(662, 159);
            this.HolidayToggleButton.Name = "HolidayToggleButton";
            this.HolidayToggleButton.Size = new System.Drawing.Size(110, 23);
            this.HolidayToggleButton.TabIndex = 9;
            this.HolidayToggleButton.TabStop = false;
            this.HolidayToggleButton.Text = "Hide Holidays";
            this.HolidayToggleButton.UseVisualStyleBackColor = true;
            this.HolidayToggleButton.Click += new System.EventHandler(this.HolidayToggleButtonClick);
            // 
            // LegendGroupBox
            // 
            this.LegendGroupBox.Controls.Add(this.label14);
            this.LegendGroupBox.Controls.Add(this.label13);
            this.LegendGroupBox.Controls.Add(this.label12);
            this.LegendGroupBox.Controls.Add(this.HolidayLegendLabel);
            this.LegendGroupBox.Controls.Add(this.StartDateLegendLabel);
            this.LegendGroupBox.Controls.Add(this.label9);
            this.LegendGroupBox.Controls.Add(this.label6);
            this.LegendGroupBox.Controls.Add(this.label7);
            this.LegendGroupBox.Controls.Add(this.label4);
            this.LegendGroupBox.Controls.Add(this.label5);
            this.LegendGroupBox.Controls.Add(this.label3);
            this.LegendGroupBox.Controls.Add(this.label8);
            this.LegendGroupBox.Location = new System.Drawing.Point(813, 190);
            this.LegendGroupBox.Name = "LegendGroupBox";
            this.LegendGroupBox.Size = new System.Drawing.Size(396, 54);
            this.LegendGroupBox.TabIndex = 10;
            this.LegendGroupBox.TabStop = false;
            this.LegendGroupBox.Text = "Legend";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Location = new System.Drawing.Point(254, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "    ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(254, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "    ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(136, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "    ";
            // 
            // HolidayLegendLabel
            // 
            this.HolidayLegendLabel.AutoSize = true;
            this.HolidayLegendLabel.BackColor = System.Drawing.Color.Transparent;
            this.HolidayLegendLabel.Location = new System.Drawing.Point(136, 17);
            this.HolidayLegendLabel.Name = "HolidayLegendLabel";
            this.HolidayLegendLabel.Size = new System.Drawing.Size(19, 15);
            this.HolidayLegendLabel.TabIndex = 12;
            this.HolidayLegendLabel.Text = "    ";
            this.HolidayLegendLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.HolidayLegendLabelPaint);
            // 
            // StartDateLegendLabel
            // 
            this.StartDateLegendLabel.AutoSize = true;
            this.StartDateLegendLabel.Location = new System.Drawing.Point(17, 34);
            this.StartDateLegendLabel.Name = "StartDateLegendLabel";
            this.StartDateLegendLabel.Size = new System.Drawing.Size(19, 15);
            this.StartDateLegendLabel.TabIndex = 13;
            this.StartDateLegendLabel.Text = "    ";
            this.StartDateLegendLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartDateLegendLabelPaint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(17, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "    ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(279, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Completion Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(42, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Holiday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(161, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(279, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Project Duration";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(1040, 159);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 12;
            this.AboutButton.TabStop = false;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButtonClick);
            // 
            // Form1
            // 
            this.AcceptButton = this.UpdateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 262);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.LegendGroupBox);
            this.Controls.Add(this.HolidayToggleButton);
            this.Controls.Add(this.ShowEndButton);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.PrevMonthButton);
            this.Controls.Add(this.ClipboardButton);
            this.Controls.Add(this.ProjectEndCalendar);
            this.Controls.Add(this.ProjectLengthBox);
            this.Controls.Add(this.ETTCGroupBox);
            this.Controls.Add(this.StartDateBox);
            this.Controls.Add(this.CurrentCalendar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " ETTC Calendar 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartDateBox.ResumeLayout(false);
            this.ETTCGroupBox.ResumeLayout(false);
            this.ProjectLengthBox.ResumeLayout(false);
            this.ProjectLengthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthEndPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthStartPicker)).EndInit();
            this.LegendGroupBox.ResumeLayout(false);
            this.LegendGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomMonthCalendar CurrentCalendar;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.GroupBox StartDateBox;
        private System.Windows.Forms.GroupBox ETTCGroupBox;
        private System.Windows.Forms.GroupBox ProjectLengthBox;
        private System.Windows.Forms.RadioButton WeeksRadioButton;
        private System.Windows.Forms.RadioButton DaysRadioButton;
        private System.Windows.Forms.NumericUpDown LengthStartPicker;
        private CustomMonthCalendar ProjectEndCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LengthEndPicker;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Timer AnimationWaitTimer;
        private System.Windows.Forms.Button ClipboardButton;
        private System.Windows.Forms.Button PrevMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button ShowEndButton;
        private System.Windows.Forms.CheckBox SingleCheckbox;
        private System.Windows.Forms.Button HolidayToggleButton;
        private System.Windows.Forms.RichTextBox ETTCResultBox;
        private System.Windows.Forms.GroupBox LegendGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label StartDateLegendLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label HolidayLegendLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

