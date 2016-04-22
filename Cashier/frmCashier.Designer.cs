using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HerokoRima
{
    partial class frmCashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnTicketStudent = new System.Windows.Forms.Button();
            this.btnTicketAdult = new System.Windows.Forms.Button();
            this.btnMonthlyAdult = new System.Windows.Forms.Button();
            this.btnMonthlyStudent = new System.Windows.Forms.Button();
            this.btnTicketsAdult = new System.Windows.Forms.Button();
            this.btnTicketsStudent = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.lblCardId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCardIdLabel = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotalDescription = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lvViewPurchase = new System.Windows.Forms.ListView();
            this.gbButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTicketStudent
            // 
            this.btnTicketStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketStudent.Location = new System.Drawing.Point(6, 18);
            this.btnTicketStudent.Name = "btnTicketStudent";
            this.btnTicketStudent.Size = new System.Drawing.Size(192, 75);
            this.btnTicketStudent.TabIndex = 0;
            this.btnTicketStudent.Text = "Estudiante";
            this.btnTicketStudent.UseVisualStyleBackColor = true;
            this.btnTicketStudent.Click += new System.EventHandler(this.btnTicketStudent_Click);
            // 
            // btnTicketAdult
            // 
            this.btnTicketAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketAdult.Location = new System.Drawing.Point(204, 18);
            this.btnTicketAdult.Name = "btnTicketAdult";
            this.btnTicketAdult.Size = new System.Drawing.Size(192, 75);
            this.btnTicketAdult.TabIndex = 1;
            this.btnTicketAdult.Text = "Adulto";
            this.btnTicketAdult.UseVisualStyleBackColor = true;
            this.btnTicketAdult.Click += new System.EventHandler(this.btnTicketAdult_Click);
            // 
            // btnMonthlyAdult
            // 
            this.btnMonthlyAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyAdult.Location = new System.Drawing.Point(204, 120);
            this.btnMonthlyAdult.Name = "btnMonthlyAdult";
            this.btnMonthlyAdult.Size = new System.Drawing.Size(192, 75);
            this.btnMonthlyAdult.TabIndex = 3;
            this.btnMonthlyAdult.Text = "Mensualidad Adulto";
            this.btnMonthlyAdult.UseVisualStyleBackColor = true;
            this.btnMonthlyAdult.Click += new System.EventHandler(this.btnMonthlyAdult_Click);
            // 
            // btnMonthlyStudent
            // 
            this.btnMonthlyStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyStudent.Location = new System.Drawing.Point(6, 120);
            this.btnMonthlyStudent.Name = "btnMonthlyStudent";
            this.btnMonthlyStudent.Size = new System.Drawing.Size(192, 75);
            this.btnMonthlyStudent.TabIndex = 2;
            this.btnMonthlyStudent.Text = "Mensualidad Estudiante";
            this.btnMonthlyStudent.UseVisualStyleBackColor = true;
            this.btnMonthlyStudent.Click += new System.EventHandler(this.btnMonthlyStudent_Click);
            // 
            // btnTicketsAdult
            // 
            this.btnTicketsAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsAdult.Location = new System.Drawing.Point(204, 221);
            this.btnTicketsAdult.Name = "btnTicketsAdult";
            this.btnTicketsAdult.Size = new System.Drawing.Size(192, 75);
            this.btnTicketsAdult.TabIndex = 5;
            this.btnTicketsAdult.Text = "6-Tickets Adulto";
            this.btnTicketsAdult.UseVisualStyleBackColor = true;
            this.btnTicketsAdult.Click += new System.EventHandler(this.btnTicketsAdult_Click);
            // 
            // btnTicketsStudent
            // 
            this.btnTicketsStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsStudent.Location = new System.Drawing.Point(6, 221);
            this.btnTicketsStudent.Name = "btnTicketsStudent";
            this.btnTicketsStudent.Size = new System.Drawing.Size(192, 75);
            this.btnTicketsStudent.TabIndex = 4;
            this.btnTicketsStudent.Text = "6-Tickets Estudiante";
            this.btnTicketsStudent.UseVisualStyleBackColor = true;
            this.btnTicketsStudent.Click += new System.EventHandler(this.btnTicketsStudent_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbButtons.Controls.Add(this.lblCardId);
            this.gbButtons.Controls.Add(this.lblName);
            this.gbButtons.Controls.Add(this.lblCardIdLabel);
            this.gbButtons.Controls.Add(this.lblNameLabel);
            this.gbButtons.Controls.Add(this.txtDiscount);
            this.gbButtons.Controls.Add(this.lblDiscount);
            this.gbButtons.Controls.Add(this.lblTicketType);
            this.gbButtons.Controls.Add(this.btnTicketStudent);
            this.gbButtons.Controls.Add(this.btnTicketsAdult);
            this.gbButtons.Controls.Add(this.btnTicketAdult);
            this.gbButtons.Controls.Add(this.btnTicketsStudent);
            this.gbButtons.Controls.Add(this.btnMonthlyStudent);
            this.gbButtons.Controls.Add(this.btnMonthlyAdult);
            this.gbButtons.Location = new System.Drawing.Point(12, 12);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(402, 999);
            this.gbButtons.TabIndex = 6;
            this.gbButtons.TabStop = false;
            // 
            // lblCardId
            // 
            this.lblCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardId.AutoSize = true;
            this.lblCardId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardId.Location = new System.Drawing.Point(143, 386);
            this.lblCardId.Name = "lblCardId";
            this.lblCardId.Size = new System.Drawing.Size(131, 29);
            this.lblCardId.TabIndex = 12;
            this.lblCardId.Text = "Nro tarjeta:";
            this.lblCardId.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(143, 357);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 29);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Nombre:";
            this.lblName.Visible = false;
            // 
            // lblCardIdLabel
            // 
            this.lblCardIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardIdLabel.AutoSize = true;
            this.lblCardIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardIdLabel.Location = new System.Drawing.Point(6, 386);
            this.lblCardIdLabel.Name = "lblCardIdLabel";
            this.lblCardIdLabel.Size = new System.Drawing.Size(131, 29);
            this.lblCardIdLabel.TabIndex = 10;
            this.lblCardIdLabel.Text = "Nro tarjeta:";
            this.lblCardIdLabel.Visible = false;
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.Location = new System.Drawing.Point(6, 357);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(107, 29);
            this.lblNameLabel.TabIndex = 9;
            this.lblNameLabel.Text = "Nombre:";
            this.lblNameLabel.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(197, 533);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 34);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(6, 536);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(128, 29);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Descuento";
            this.lblDiscount.Visible = false;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketType.Location = new System.Drawing.Point(3, 18);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(0, 29);
            this.lblTicketType.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1065, 918);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 75);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotalDescription
            // 
            this.lblTotalDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDescription.AutoSize = true;
            this.lblTotalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescription.Location = new System.Drawing.Point(1059, 850);
            this.lblTotalDescription.Name = "lblTotalDescription";
            this.lblTotalDescription.Size = new System.Drawing.Size(187, 36);
            this.lblTotalDescription.TabIndex = 0;
            this.lblTotalDescription.Text = "Total compra";
            this.lblTotalDescription.Click += new System.EventHandler(this.lblTotalDescription_Click);
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSum.Location = new System.Drawing.Point(1255, 850);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(0, 46);
            this.lblTotalSum.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.lvViewPurchase);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblTotalSum);
            this.groupBox1.Controls.Add(this.lblTotalDescription);
            this.groupBox1.Location = new System.Drawing.Point(420, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1470, 999);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(1263, 918);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(192, 75);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lvViewPurchase
            // 
            this.lvViewPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvViewPurchase.BackColor = System.Drawing.SystemColors.Control;
            this.lvViewPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvViewPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvViewPurchase.Location = new System.Drawing.Point(0, 9);
            this.lvViewPurchase.Name = "lvViewPurchase";
            this.lvViewPurchase.OwnerDraw = true;
            this.lvViewPurchase.Size = new System.Drawing.Size(1470, 823);
            this.lvViewPurchase.TabIndex = 9;
            this.lvViewPurchase.UseCompatibleStateImageBehavior = false;
            this.lvViewPurchase.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvViewPurchase_DrawColumnHeader);
            this.lvViewPurchase.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvViewPurchase_DrawSubItem);
            this.lvViewPurchase.DoubleClick += new System.EventHandler(this.lvViewPurchase_DoubleClick);
            // 
            // frmCashier
            // 
            this.ClientSize = new System.Drawing.Size(1902, 1023);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCashier_Load);
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTicketStudent;
        private Button btnTicketAdult;
        private Button btnMonthlyAdult;
        private Button btnMonthlyStudent;
        private Button btnTicketsAdult;
        private Button btnTicketsStudent;
        private GroupBox gbButtons;
        private Button btnCancel;
        private Label lblTicketType;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Label lblTotalDescription;
        private Label lblTotalSum;
        private GroupBox groupBox1;
        private ListView lvViewPurchase;
        private Button btnAccept;
        private Label lblCardId;
        private Label lblName;
        private Label lblCardIdLabel;
        private Label lblNameLabel;
    }
}

