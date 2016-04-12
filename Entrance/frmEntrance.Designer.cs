namespace HerokoRimaEntrada
{
    partial class frmEntrance
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
            this.components = new System.ComponentModel.Container();
            this.txtUserMember = new System.Windows.Forms.TextBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMembershipInfo = new System.Windows.Forms.Label();
            this.tGreetings = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtUserMember
            // 
            this.txtUserMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserMember.Location = new System.Drawing.Point(12, 769);
            this.txtUserMember.Name = "txtUserMember";
            this.txtUserMember.Size = new System.Drawing.Size(1558, 53);
            this.txtUserMember.TabIndex = 0;
            this.txtUserMember.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserMember_KeyDown);
            this.txtUserMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserMember_KeyPress);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoEllipsis = true;
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(21, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 63);
            this.lblGreeting.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 63);
            this.lblName.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoEllipsis = true;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(21, 279);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 63);
            this.lblDate.TabIndex = 4;
            // 
            // lblMembershipInfo
            // 
            this.lblMembershipInfo.AutoEllipsis = true;
            this.lblMembershipInfo.AutoSize = true;
            this.lblMembershipInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipInfo.Location = new System.Drawing.Point(21, 189);
            this.lblMembershipInfo.Name = "lblMembershipInfo";
            this.lblMembershipInfo.Size = new System.Drawing.Size(0, 63);
            this.lblMembershipInfo.TabIndex = 3;
            // 
            // tGreetings
            // 
            this.tGreetings.Interval = 5000;
            this.tGreetings.Tick += new System.EventHandler(this.tGreetings_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 727);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 39);
            this.lblTime.TabIndex = 5;
            // 
            // tTimer
            // 
            this.tTimer.Interval = 1000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 834);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMembershipInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.txtUserMember);
            this.Name = "frmMain";
            this.Text = "Empresa - Entradas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserMember;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMembershipInfo;
        private System.Windows.Forms.Timer tGreetings;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tTimer;
    }
}

