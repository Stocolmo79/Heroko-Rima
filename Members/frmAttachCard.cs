using System;

using System.Windows.Forms;


namespace Members
{
    public partial class frmAttachCard : Form
    {
        public Int32 ReturnValue { get; set; }
     
        public int tag;
    
        public frmAttachCard()
       {
         
            InitializeComponent();
            this.btnAccept.DialogResult = DialogResult.OK;
       }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.ReturnValue = Convert.ToInt32(txtMemberId.Text);
        }

        private void txtMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

 
}
