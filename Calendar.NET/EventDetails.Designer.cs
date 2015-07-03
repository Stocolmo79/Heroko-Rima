namespace Calendar.NET
{
    partial class EventDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableTooltip = new System.Windows.Forms.CheckBox();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEventColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBasics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clase:";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "yyyy/MM/dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(95, 76);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(286, 22);
            this.dtDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.label7);
            this.gbBasics.Controls.Add(this.txtEndTime);
            this.gbBasics.Controls.Add(this.label8);
            this.gbBasics.Controls.Add(this.txtStartTime);
            this.gbBasics.Controls.Add(this.label3);
            this.gbBasics.Controls.Add(this.txtStaff);
            this.gbBasics.Controls.Add(this.chkEnabled);
            this.gbBasics.Controls.Add(this.label2);
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Controls.Add(this.dtDate);
            this.gbBasics.Controls.Add(this.txtEventName);
            this.gbBasics.Location = new System.Drawing.Point(16, 15);
            this.gbBasics.Margin = new System.Windows.Forms.Padding(4);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Padding = new System.Windows.Forms.Padding(4);
            this.gbBasics.Size = new System.Drawing.Size(435, 267);
            this.gbBasics.TabIndex = 4;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Basics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hora termino";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(291, 105);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(90, 22);
            this.txtEndTime.TabIndex = 10;
            this.txtEndTime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hora inicio:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(95, 105);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(90, 22);
            this.txtStartTime.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profesor:";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(95, 46);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(286, 22);
            this.txtStaff.TabIndex = 6;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(279, 218);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(82, 21);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(95, 16);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(286, 22);
            this.txtEventName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnableTooltip);
            this.groupBox1.Controls.Add(this.pnlTextColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pnlEventColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.lblFont);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(438, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appearance Settings";
            // 
            // chkEnableTooltip
            // 
            this.chkEnableTooltip.AutoSize = true;
            this.chkEnableTooltip.Location = new System.Drawing.Point(175, 86);
            this.chkEnableTooltip.Margin = new System.Windows.Forms.Padding(4);
            this.chkEnableTooltip.Name = "chkEnableTooltip";
            this.chkEnableTooltip.Size = new System.Drawing.Size(121, 21);
            this.chkEnableTooltip.TabIndex = 7;
            this.chkEnableTooltip.Text = "Enable Tooltip";
            this.chkEnableTooltip.UseVisualStyleBackColor = true;
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextColor.Location = new System.Drawing.Point(359, 52);
            this.pnlTextColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(39, 18);
            this.pnlTextColor.TabIndex = 6;
            this.pnlTextColor.DoubleClick += new System.EventHandler(this.PnlTextColorDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event Text Color:";
            // 
            // pnlEventColor
            // 
            this.pnlEventColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventColor.Location = new System.Drawing.Point(128, 49);
            this.pnlEventColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEventColor.Name = "pnlEventColor";
            this.pnlEventColor.Size = new System.Drawing.Size(39, 18);
            this.pnlEventColor.TabIndex = 4;
            this.pnlEventColor.DoubleClick += new System.EventHandler(this.PnlEventColorDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Event Color:";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(367, 22);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(32, 25);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "...";
            this.btnFont.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFontClick);
            // 
            // lblFont
            // 
            this.lblFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFont.Location = new System.Drawing.Point(129, 25);
            this.lblFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(235, 20);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "label5";
            this.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Font:";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ScriptsOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(22, 420);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 420);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 462);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBasics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetails";
            this.Load += new System.EventHandler(this.EventDetailsLoad);
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlEventColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkEnableTooltip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtEventName;
    }
}