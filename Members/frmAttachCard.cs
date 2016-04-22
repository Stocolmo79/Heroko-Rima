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
            this.btnNew.DialogResult = DialogResult.Yes;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text.Length > 0)
            {
                this.ReturnValue = Convert.ToInt32(txtMemberId.Text);
            }

        }

        private void txtMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var newMember = new frmNewMember
                                {
                                    TopLevel = true,
                                    AutoScroll = true,
                                    Dock = DockStyle.Fill,
                                    Tag = tag,
                                    nro = tag
                                };
            newMember.ShowDialog();

            txtMemberId.Text = newMember.ReturnValue.ToString();
            this.ReturnValue = newMember.ReturnValue;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }


}
