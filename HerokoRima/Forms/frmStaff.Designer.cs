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
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkAcroYoga = new System.Windows.Forms.CheckBox();
            this.chkBouldering = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblLastNames = new System.Windows.Forms.Label();
            this.lblFirstNames = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProfesores = new System.Windows.Forms.ComboBox();
            this.tStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCalendar = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCalendar = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesores";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(9, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(304, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // grEditStaff
            // 
            this.grEditStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grEditStaff.Controls.Add(this.chkYoga);
            this.grEditStaff.Controls.Add(this.chkAcroYoga);
            this.grEditStaff.Controls.Add(this.chkBouldering);
            this.grEditStaff.Controls.Add(this.chkActive);
            this.grEditStaff.Controls.Add(this.btnUpdate);
            this.grEditStaff.Controls.Add(this.lblRut);
            this.grEditStaff.Controls.Add(this.txtRUT);
            this.grEditStaff.Controls.Add(this.pictureBox1);
            this.grEditStaff.Controls.Add(this.lblArea);
            this.grEditStaff.Controls.Add(this.lblPhone);
            this.grEditStaff.Controls.Add(this.lblCity);
            this.grEditStaff.Controls.Add(this.lblAdress);
            this.grEditStaff.Controls.Add(this.lblLastNames);
            this.grEditStaff.Controls.Add(this.lblFirstNames);
            this.grEditStaff.Controls.Add(this.txtPhone);
            this.grEditStaff.Controls.Add(this.txtCity);
            this.grEditStaff.Controls.Add(this.txtAdress);
            this.grEditStaff.Controls.Add(this.txtLastName);
            this.grEditStaff.Controls.Add(this.txtFirstName);
            this.grEditStaff.Location = new System.Drawing.Point(13, 123);
            this.grEditStaff.Name = "grEditStaff";
            this.grEditStaff.Size = new System.Drawing.Size(480, 942);
            this.grEditStaff.TabIndex = 3;
            this.grEditStaff.TabStop = false;
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkYoga.Location = new System.Drawing.Point(211, 375);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(63, 21);
            this.chkYoga.TabIndex = 21;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkAcroYoga
            // 
            this.chkAcroYoga.AutoSize = true;
            this.chkAcroYoga.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAcroYoga.Location = new System.Drawing.Point(113, 375);
            this.chkAcroYoga.Name = "chkAcroYoga";
            this.chkAcroYoga.Size = new System.Drawing.Size(92, 21);
            this.chkAcroYoga.TabIndex = 20;
            this.chkAcroYoga.Text = "AcroYoga";
            this.chkAcroYoga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkAcroYoga.UseVisualStyleBackColor = true;
            // 
            // chkBouldering
            // 
            this.chkBouldering.AutoSize = true;
            this.chkBouldering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBouldering.Location = new System.Drawing.Point(9, 375);
            this.chkBouldering.Name = "chkBouldering";
            this.chkBouldering.Size = new System.Drawing.Size(98, 21);
            this.chkBouldering.TabIndex = 19;
            this.chkBouldering.Text = "Bouldering";
            this.chkBouldering.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkBouldering.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkActive.Location = new System.Drawing.Point(328, 38);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(68, 21);
            this.chkActive.TabIndex = 18;
            this.chkActive.Text = "Activo";
            this.chkActive.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(342, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Guardar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(6, 127);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(37, 17);
            this.lblRut.TabIndex = 16;
            this.lblRut.Text = "RUT";
            // 
            // txtRUT
            // 
            this.txtRUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRUT.Location = new System.Drawing.Point(9, 150);
            this.txtRUT.MaxLength = 10;
            this.txtRUT.Name = "txtRUT";
            this.txtRUT.Size = new System.Drawing.Size(465, 22);
            this.txtRUT.TabIndex = 15;
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
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(6, 351);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Area";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 295);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(40, 17);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Fono";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 239);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 17);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "Ciudad";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(6, 184);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(67, 17);
            this.lblAdress.TabIndex = 10;
            this.lblAdress.Text = "Dirección";
            // 
            // lblLastNames
            // 
            this.lblLastNames.AutoSize = true;
            this.lblLastNames.Location = new System.Drawing.Point(6, 72);
            this.lblLastNames.Name = "lblLastNames";
            this.lblLastNames.Size = new System.Drawing.Size(65, 17);
            this.lblLastNames.TabIndex = 9;
            this.lblLastNames.Text = "Apellidos";
            // 
            // lblFirstNames
            // 
            this.lblFirstNames.AutoSize = true;
            this.lblFirstNames.Location = new System.Drawing.Point(6, 18);
            this.lblFirstNames.Name = "lblFirstNames";
            this.lblFirstNames.Size = new System.Drawing.Size(65, 17);
            this.lblFirstNames.TabIndex = 8;
            this.lblFirstNames.Text = "Nombres";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(9, 318);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(465, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Location = new System.Drawing.Point(9, 262);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(465, 22);
            this.txtCity.TabIndex = 4;
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdress.Location = new System.Drawing.Point(9, 206);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(465, 22);
            this.txtAdress.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(9, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(465, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbProfesores);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(90, 21);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(384, 24);
            this.cmbProfesores.TabIndex = 1;
            this.cmbProfesores.SelectedIndexChanged += new System.EventHandler(this.cmbProfesores_SelectedIndexChanged);
            // 
            // gbCalendar
            // 
            this.gbCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCalendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCalendar.Controls.Add(this.btnCalendar);
           
            this.gbCalendar.Location = new System.Drawing.Point(499, 13);
            this.gbCalendar.Name = "gbCalendar";
            this.gbCalendar.Size = new System.Drawing.Size(1405, 1052);
            this.gbCalendar.TabIndex = 5;
            this.gbCalendar.TabStop = false;
          
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(1268, 1023);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(131, 23);
            this.btnCalendar.TabIndex = 18;
            this.btnCalendar.Text = "Guardar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // FrmProfesor
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
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblLastNames;
        private System.Windows.Forms.Label lblFirstNames;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCalendar;
        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.BindingSource tStaffBindingSource;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkAcroYoga;
        private System.Windows.Forms.CheckBox chkBouldering;
        private System.Windows.Forms.Button btnCalendar;

    }
}