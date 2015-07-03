namespace HerokoRima.Forms
{
    partial class FrmClasses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange8 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange9 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange10 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.grNewClass = new System.Windows.Forms.GroupBox();
            this.cmbMaxAttendance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.cmbEnd = new System.Windows.Forms.ComboBox();
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calClasses = new System.Windows.Forms.Calendar.Calendar();
            this.mvClasses = new System.Windows.Forms.Calendar.MonthView();
            this.grNewClass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grNewClass
            // 
            this.grNewClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grNewClass.Controls.Add(this.cmbMaxAttendance);
            this.grNewClass.Controls.Add(this.label4);
            this.grNewClass.Controls.Add(this.btnSaveClass);
            this.grNewClass.Controls.Add(this.cmbEnd);
            this.grNewClass.Controls.Add(this.cmbStart);
            this.grNewClass.Controls.Add(this.label1);
            this.grNewClass.Controls.Add(this.dtpClassDate);
            this.grNewClass.Controls.Add(this.cmbProfessor);
            this.grNewClass.Controls.Add(this.cmbArea);
            this.grNewClass.Controls.Add(this.label3);
            this.grNewClass.Controls.Add(this.label2);
            this.grNewClass.Controls.Add(this.lblProfessor);
            this.grNewClass.Controls.Add(this.lblArea);
            this.grNewClass.Location = new System.Drawing.Point(12, 12);
            this.grNewClass.Name = "grNewClass";
            this.grNewClass.Size = new System.Drawing.Size(428, 747);
            this.grNewClass.TabIndex = 0;
            this.grNewClass.TabStop = false;
            // 
            // cmbMaxAttendance
            // 
            this.cmbMaxAttendance.FormattingEnabled = true;
            this.cmbMaxAttendance.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbMaxAttendance.Location = new System.Drawing.Point(10, 242);
            this.cmbMaxAttendance.Name = "cmbMaxAttendance";
            this.cmbMaxAttendance.Size = new System.Drawing.Size(200, 24);
            this.cmbMaxAttendance.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad maxima alumnos";
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Location = new System.Drawing.Point(341, 282);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClass.TabIndex = 17;
            this.btnSaveClass.Text = "Guardar";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // cmbEnd
            // 
            this.cmbEnd.FormattingEnabled = true;
            this.cmbEnd.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "22:00"});
            this.cmbEnd.Location = new System.Drawing.Point(216, 192);
            this.cmbEnd.Name = "cmbEnd";
            this.cmbEnd.Size = new System.Drawing.Size(200, 24);
            this.cmbEnd.TabIndex = 16;
            // 
            // cmbStart
            // 
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "22:00"});
            this.cmbStart.Location = new System.Drawing.Point(10, 192);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(200, 24);
            this.cmbStart.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hora Fin";
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Location = new System.Drawing.Point(10, 143);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(406, 22);
            this.dtpClassDate.TabIndex = 12;
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(10, 92);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(406, 24);
            this.cmbProfessor.TabIndex = 11;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(10, 40);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(406, 24);
            this.cmbArea.TabIndex = 10;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(7, 72);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(62, 17);
            this.lblProfessor.TabIndex = 2;
            this.lblProfessor.Text = "Profesor";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 22);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.calClasses);
            this.groupBox1.Controls.Add(this.mvClasses);
            this.groupBox1.Location = new System.Drawing.Point(446, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 747);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // calClasses
            // 
            this.calClasses.Font = new System.Drawing.Font("Segoe UI", 11.4F);
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calClasses.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange6,
        calendarHighlightRange7,
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10};
            this.calClasses.Location = new System.Drawing.Point(6, 242);
            this.calClasses.Name = "calClasses";
            this.calClasses.Size = new System.Drawing.Size(75, 23);
            this.calClasses.TabIndex = 2;
            this.calClasses.Text = "calendar1";
            this.calClasses.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calClasses_LoadItems);
            // 
            // mvClasses
            // 
            this.mvClasses.ArrowsColor = System.Drawing.SystemColors.Window;
            this.mvClasses.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.mvClasses.DayBackgroundColor = System.Drawing.Color.Empty;
            this.mvClasses.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.mvClasses.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.mvClasses.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.mvClasses.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.mvClasses.ItemPadding = new System.Windows.Forms.Padding(2);
            this.mvClasses.Location = new System.Drawing.Point(6, 21);
            this.mvClasses.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.mvClasses.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.mvClasses.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mvClasses.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.mvClasses.Name = "mvClasses";
            this.mvClasses.Size = new System.Drawing.Size(1442, 217);
            this.mvClasses.TabIndex = 1;
            this.mvClasses.TodayBorderColor = System.Drawing.Color.Maroon;
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1912, 771);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grNewClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClasses";
            this.grNewClass.ResumeLayout(false);
            this.grNewClass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grNewClass;
        private System.Windows.Forms.ComboBox cmbEnd;
        private System.Windows.Forms.ComboBox cmbStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.ComboBox cmbMaxAttendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Calendar.Calendar calClasses;
        private System.Windows.Forms.Calendar.MonthView mvClasses;
    }
}