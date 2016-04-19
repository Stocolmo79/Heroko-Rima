namespace Cashier
{
    partial class frmEndDay
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
            this.lvEndDay = new System.Windows.Forms.ListView();
            this.btnSaveDay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEveningMonitor = new System.Windows.Forms.Label();
            this.lblDayMonitor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvEndDay
            // 
            this.lvEndDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEndDay.Location = new System.Drawing.Point(0, 0);
            this.lvEndDay.Name = "lvEndDay";
            this.lvEndDay.Size = new System.Drawing.Size(1470, 830);
            this.lvEndDay.TabIndex = 0;
            this.lvEndDay.UseCompatibleStateImageBehavior = false;
            // 
            // btnSaveDay
            // 
            this.btnSaveDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDay.Location = new System.Drawing.Point(1266, 920);
            this.btnSaveDay.Name = "btnSaveDay";
            this.btnSaveDay.Size = new System.Drawing.Size(192, 75);
            this.btnSaveDay.TabIndex = 1;
            this.btnSaveDay.Text = "Guardar dia";
            this.btnSaveDay.UseVisualStyleBackColor = true;
            this.btnSaveDay.Click += new System.EventHandler(this.btnSaveDay_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 848);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monitor Dia";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 882);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monitor Tarde";
            // 
            // lblEveningMonitor
            // 
            this.lblEveningMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEveningMonitor.AutoSize = true;
            this.lblEveningMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEveningMonitor.Location = new System.Drawing.Point(183, 882);
            this.lblEveningMonitor.Name = "lblEveningMonitor";
            this.lblEveningMonitor.Size = new System.Drawing.Size(0, 29);
            this.lblEveningMonitor.TabIndex = 5;
            // 
            // lblDayMonitor
            // 
            this.lblDayMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDayMonitor.AutoSize = true;
            this.lblDayMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayMonitor.Location = new System.Drawing.Point(183, 848);
            this.lblDayMonitor.Name = "lblDayMonitor";
            this.lblDayMonitor.Size = new System.Drawing.Size(0, 29);
            this.lblDayMonitor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 848);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total dia: ";
            // 
            // lblTotalDay
            // 
            this.lblTotalDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalDay.AutoSize = true;
            this.lblTotalDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDay.Location = new System.Drawing.Point(1098, 848);
            this.lblTotalDay.Name = "lblTotalDay";
            this.lblTotalDay.Size = new System.Drawing.Size(0, 29);
            this.lblTotalDay.TabIndex = 7;
            // 
            // frmEndDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 999);
            this.Controls.Add(this.lblTotalDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEveningMonitor);
            this.Controls.Add(this.lblDayMonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveDay);
            this.Controls.Add(this.lvEndDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEndDay";
            this.Text = "frmEndDay";
            this.Load += new System.EventHandler(this.frmEndDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEndDay;
        private System.Windows.Forms.Button btnSaveDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEveningMonitor;
        private System.Windows.Forms.Label lblDayMonitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDay;
    }
}