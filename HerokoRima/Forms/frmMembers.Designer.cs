namespace HerokoRima.Forms
{
    partial class frmMembers
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
            this.gbSearchMember = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.btnRenewDate = new System.Windows.Forms.Button();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvCardUsage = new System.Windows.Forms.ListView();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.gbSearchMember.SuspendLayout();
            this.gbMember.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre o número de membresia";
            // 
            // gbSearchMember
            // 
            this.gbSearchMember.Controls.Add(this.btnSearch);
            this.gbSearchMember.Controls.Add(this.txtInput);
            this.gbSearchMember.Controls.Add(this.label1);
            this.gbSearchMember.Location = new System.Drawing.Point(12, 12);
            this.gbSearchMember.Name = "gbSearchMember";
            this.gbSearchMember.Size = new System.Drawing.Size(535, 148);
            this.gbSearchMember.TabIndex = 1;
            this.gbSearchMember.TabStop = false;
            this.gbSearchMember.Text = "Buscar Miembro";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(315, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(214, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(11, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(518, 34);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // gbMember
            // 
            this.gbMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMember.Controls.Add(this.txtTickets);
            this.gbMember.Controls.Add(this.lblTickets);
            this.gbMember.Controls.Add(this.btnRenewDate);
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
            this.gbMember.Location = new System.Drawing.Point(12, 166);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(535, 892);
            this.gbMember.TabIndex = 2;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Miembro";
            // 
            // btnRenewDate
            // 
            this.btnRenewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewDate.Location = new System.Drawing.Point(315, 561);
            this.btnRenewDate.Name = "btnRenewDate";
            this.btnRenewDate.Size = new System.Drawing.Size(214, 39);
            this.btnRenewDate.TabIndex = 17;
            this.btnRenewDate.Text = "Renovar fecha";
            this.btnRenewDate.UseVisualStyleBackColor = true;
            this.btnRenewDate.Visible = false;
            this.btnRenewDate.Click += new System.EventHandler(this.btnRenewDate_Click);
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
            this.txtLastNames.Location = new System.Drawing.Point(11, 128);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(518, 34);
            this.txtLastNames.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 96);
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
            this.txtMemberId.Location = new System.Drawing.Point(11, 207);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(518, 34);
            this.txtMemberId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de membresia";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(11, 50);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(518, 34);
            this.txtMemberName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvCardUsage);
            this.groupBox1.Location = new System.Drawing.Point(553, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1355, 1046);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lvCardUsage
            // 
            this.lvCardUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCardUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCardUsage.GridLines = true;
            this.lvCardUsage.Location = new System.Drawing.Point(7, 22);
            this.lvCardUsage.Name = "lvCardUsage";
            this.lvCardUsage.Size = new System.Drawing.Size(1342, 1018);
            this.lvCardUsage.TabIndex = 0;
            this.lvCardUsage.UseCompatibleStateImageBehavior = false;
            // 
            // txtTickets
            // 
            this.txtTickets.Enabled = false;
            this.txtTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(11, 521);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(518, 34);
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
            // frmMembers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1920, 1070);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.gbSearchMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Miembros";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.gbSearchMember.ResumeLayout(false);
            this.gbSearchMember.PerformLayout();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearchMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValidTo;
        private System.Windows.Forms.Label lblValidTo;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvCardUsage;
        private System.Windows.Forms.Button btnRenewDate;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblTickets;
    }
}