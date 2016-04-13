namespace Members
{
    partial class frmNewMember
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
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkValid = new System.Windows.Forms.CheckBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValidTo = new System.Windows.Forms.TextBox();
            this.lblValidTo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.gbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMember
            // 
            this.gbMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMember.Controls.Add(this.label7);
            this.gbMember.Controls.Add(this.chkValid);
            this.gbMember.Controls.Add(this.txtTickets);
            this.gbMember.Controls.Add(this.lblTickets);
            this.gbMember.Controls.Add(this.cmbCardType);
            this.gbMember.Controls.Add(this.btnSave);
            this.gbMember.Controls.Add(this.txtLastNames);
            this.gbMember.Controls.Add(this.label6);
            this.gbMember.Controls.Add(this.txtValidTo);
            this.gbMember.Controls.Add(this.lblValidTo);
            this.gbMember.Controls.Add(this.label5);
            this.gbMember.Controls.Add(this.txtCellphone);
            this.gbMember.Controls.Add(this.label4);
            this.gbMember.Controls.Add(this.txtMemberId);
            this.gbMember.Controls.Add(this.label3);
            this.gbMember.Controls.Add(this.txtMemberName);
            this.gbMember.Controls.Add(this.label2);
            this.gbMember.Location = new System.Drawing.Point(12, 12);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(547, 909);
            this.gbMember.TabIndex = 3;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Miembro";
            this.gbMember.Enter += new System.EventHandler(this.gbMember_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cantidad de tickets que quedan";
            // 
            // chkValid
            // 
            this.chkValid.AutoSize = true;
            this.chkValid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkValid.Checked = true;
            this.chkValid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValid.Location = new System.Drawing.Point(11, 572);
            this.chkValid.Name = "chkValid";
            this.chkValid.Size = new System.Drawing.Size(103, 33);
            this.chkValid.TabIndex = 20;
            this.chkValid.Text = "Valido";
            this.chkValid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkValid.UseVisualStyleBackColor = true;
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(377, 518);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(151, 34);
            this.txtTickets.TabIndex = 18;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(6, 489);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(91, 29);
            this.lblTickets.TabIndex = 19;
            this.lblTickets.Text = "Tickets";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(315, 847);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 39);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLastNames
            // 
            this.txtLastNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNames.Location = new System.Drawing.Point(10, 207);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(518, 34);
            this.txtLastNames.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Apellidos";
            // 
            // txtValidTo
            // 
            this.txtValidTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidTo.Location = new System.Drawing.Point(11, 443);
            this.txtValidTo.Name = "txtValidTo";
            this.txtValidTo.Size = new System.Drawing.Size(518, 34);
            this.txtValidTo.TabIndex = 6;
            // 
            // lblValidTo
            // 
            this.lblValidTo.AutoSize = true;
            this.lblValidTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidTo.Location = new System.Drawing.Point(6, 411);
            this.lblValidTo.Name = "lblValidTo";
            this.lblValidTo.Size = new System.Drawing.Size(144, 29);
            this.lblValidTo.TabIndex = 11;
            this.lblValidTo.Text = "Valido hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de tarjeta";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellphone.Location = new System.Drawing.Point(11, 286);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(518, 34);
            this.txtCellphone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Celular";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMemberId.Location = new System.Drawing.Point(11, 50);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(518, 34);
            this.txtMemberId.TabIndex = 1;
            this.txtMemberId.Text = "Ingrese numero de tarjeta";
            this.txtMemberId.Enter += new System.EventHandler(this.txtMemberId_Enter);
            this.txtMemberId.Leave += new System.EventHandler(this.txtMemberId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de membresia";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(10, 129);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(518, 34);
            this.txtMemberName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // cmbCardType
            // 
            this.cmbCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.ItemHeight = 29;
            this.cmbCardType.Location = new System.Drawing.Point(11, 364);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(518, 37);
            this.cmbCardType.TabIndex = 16;
            // 
            // frmNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 933);
            this.Controls.Add(this.gbMember);
            this.Name = "frmNewMember";
            this.Text = "Nuevo ";
            this.Load += new System.EventHandler(this.frmNewMember_Load);
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkValid;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValidTo;
        private System.Windows.Forms.Label lblValidTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCardType;
    }
}