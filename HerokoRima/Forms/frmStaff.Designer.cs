namespace HerokoRima.Forms
{
    partial class FrmStaff
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grEditStaff = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastNames = new System.Windows.Forms.Label();
            this.lblFirstNames = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMonitores = new System.Windows.Forms.ComboBox();
            this.tStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCalendar = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lvDays = new System.Windows.Forms.ListView();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDates = new System.Windows.Forms.Button();
            this.grEditStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tStaffBindingSource)).BeginInit();
            this.gbCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Monitores";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(9, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(304, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // grEditStaff
            // 
            this.grEditStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grEditStaff.Controls.Add(this.btnSearchDates);
            this.grEditStaff.Controls.Add(this.dtpStart);
            this.grEditStaff.Controls.Add(this.dtpEnd);
            this.grEditStaff.Controls.Add(this.lblStart);
            this.grEditStaff.Controls.Add(this.lblEnd);
            this.grEditStaff.Controls.Add(this.chkActive);
            this.grEditStaff.Controls.Add(this.btnUpdate);
            this.grEditStaff.Controls.Add(this.pictureBox1);
            this.grEditStaff.Controls.Add(this.lblPhone);
            this.grEditStaff.Controls.Add(this.lblLastNames);
            this.grEditStaff.Controls.Add(this.lblFirstNames);
            this.grEditStaff.Controls.Add(this.txtPhone);
            this.grEditStaff.Controls.Add(this.txtLastName);
            this.grEditStaff.Controls.Add(this.txtFirstName);
            this.grEditStaff.Location = new System.Drawing.Point(13, 123);
            this.grEditStaff.Name = "grEditStaff";
            this.grEditStaff.Size = new System.Drawing.Size(480, 942);
            this.grEditStaff.TabIndex = 3;
            this.grEditStaff.TabStop = false;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(328, 38);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(99, 33);
            this.chkActive.TabIndex = 18;
            this.chkActive.Text = "Activo";
            this.chkActive.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(343, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 39);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Guardar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(9, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 462);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 169);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 29);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Fono";
            // 
            // lblLastNames
            // 
            this.lblLastNames.AutoSize = true;
            this.lblLastNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNames.Location = new System.Drawing.Point(4, 91);
            this.lblLastNames.Name = "lblLastNames";
            this.lblLastNames.Size = new System.Drawing.Size(114, 29);
            this.lblLastNames.TabIndex = 9;
            this.lblLastNames.Text = "Apellidos";
            // 
            // lblFirstNames
            // 
            this.lblFirstNames.AutoSize = true;
            this.lblFirstNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNames.Location = new System.Drawing.Point(6, 18);
            this.lblFirstNames.Name = "lblFirstNames";
            this.lblFirstNames.Size = new System.Drawing.Size(113, 29);
            this.lblFirstNames.TabIndex = 8;
            this.lblFirstNames.Text = "Nombres";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(9, 201);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(465, 34);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(9, 123);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(465, 34);
            this.txtLastName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMonitores);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cmbMonitores
            // 
            this.cmbMonitores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonitores.FormattingEnabled = true;
            this.cmbMonitores.Location = new System.Drawing.Point(129, 21);
            this.cmbMonitores.Name = "cmbMonitores";
            this.cmbMonitores.Size = new System.Drawing.Size(345, 37);
            this.cmbMonitores.TabIndex = 1;
            this.cmbMonitores.SelectedIndexChanged += new System.EventHandler(this.cmbMonitores_SelectedIndexChanged);
            // 
            // gbCalendar
            // 
            this.gbCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCalendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCalendar.Controls.Add(this.lvDays);
            this.gbCalendar.Location = new System.Drawing.Point(499, 13);
            this.gbCalendar.Name = "gbCalendar";
            this.gbCalendar.Size = new System.Drawing.Size(1423, 1052);
            this.gbCalendar.TabIndex = 5;
            this.gbCalendar.TabStop = false;
            // 
            // lvDays
            // 
            this.lvDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDays.Location = new System.Drawing.Point(6, 21);
            this.lvDays.Name = "lvDays";
            this.lvDays.Size = new System.Drawing.Size(1411, 1025);
            this.lvDays.TabIndex = 19;
            this.lvDays.UseCompatibleStateImageBehavior = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(8, 353);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(47, 29);
            this.lblEnd.TabIndex = 22;
            this.lblEnd.Text = "Fin";
            this.lblEnd.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(8, 312);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(70, 29);
            this.lblStart.TabIndex = 23;
            this.lblStart.Text = "Inicio";
            this.lblStart.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(84, 353);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(390, 34);
            this.dtpEnd.TabIndex = 24;
            this.dtpEnd.Visible = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(84, 312);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(390, 34);
            this.dtpStart.TabIndex = 25;
            this.dtpStart.Visible = false;
            // 
            // btnSearchDates
            // 
            this.btnSearchDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDates.Location = new System.Drawing.Point(343, 393);
            this.btnSearchDates.Name = "btnSearchDates";
            this.btnSearchDates.Size = new System.Drawing.Size(131, 39);
            this.btnSearchDates.TabIndex = 26;
            this.btnSearchDates.Text = "Ver";
            this.btnSearchDates.UseVisualStyleBackColor = true;
            this.btnSearchDates.Visible = false;
            this.btnSearchDates.Click += new System.EventHandler(this.btnSearchDates_Click);
            // 
            // FrmStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1934, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.gbCalendar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grEditStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "profesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            this.grEditStaff.ResumeLayout(false);
            this.grEditStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tStaffBindingSource)).EndInit();
            this.gbCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grEditStaff;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastNames;
        private System.Windows.Forms.Label lblFirstNames;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMonitores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCalendar;
        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.BindingSource tStaffBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ListView lvDays;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnSearchDates;

    }
}