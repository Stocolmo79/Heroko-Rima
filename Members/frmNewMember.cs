using System;
using System.Drawing;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;

namespace Members
{
    public partial class frmNewMember : Form
    {
        public tMember tMember;
        public tCardUsage tCardUsage;
        public tType tType;
        public Member members;

        public int nro;    

        public tPrice tPrice;
        public Price price;

        public tCard tCard;
        public Cards cards;
        public CardUsage cardUsage;
      
        public frmNewMember()
        {
            InitializeComponent();
            price = new Price();
            members = new Member();
            cards = new Cards();
            cardUsage = new CardUsage();
          }

        private void txtMemberId_Leave(object sender, EventArgs e)
        {
            if (txtMemberId.Text.Length != 0)
            {
                return;
            }
            txtMemberId.Text = "Ingrese numero de tarjeta";
            txtMemberId.ForeColor = SystemColors.GrayText;
            txtMemberId.Tag = 0;
        }

        private void txtMemberId_Enter(object sender, EventArgs e)
        {
            if (!txtMemberId.Text.Equals("Ingrese numero de tarjeta"))
            {
                return;
            }
            txtMemberId.Text = "";
            txtMemberId.ForeColor = SystemColors.WindowText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text.Equals("Ingrese numero de tarjeta") || txtMemberName.Text.Length == 0 || txtLastNames.Text.Length == 0 || txtCellphone.Text.Length == 0)
            {          
            }
            else
            {
                this.tPrice = (tPrice)this.cmbCardType.SelectedItem;
                this.tMember = new tMember();
                this.tCard = new tCard();
                
                members.SaveMember(PopulateMember());

                cards.SaveCard(PopulateCard());
                }
        }
        private tCard PopulateCard()
        {
            tCard.CardId = tMember.MemberId;
            tCard.Changed = DateTime.Today;
            tCard.EndDate = Convert.ToDateTime(txtValidTo.Text);
            tCard.StartDate = DateTime.Today;

            tCard.tPrice.PriceId = this.tPrice.PriceId;
            tCard.Tickets = Convert.ToInt32(txtTickets.Text);
            tCard.Enabled = chkValid.Checked;
            return tCard;
        }

        private tMember PopulateMember()
        {
            tMember.Firstname = this.txtMemberName.Text;
            tMember.Lastname = this.txtLastNames.Text;
            tMember.Cellphone = this.txtCellphone.Text;
            return tMember;
        }
        private void LoadComboBox()
        {
            cmbCardType.DataSource = Combobox.LoadComboBoxCardTypes();
            cmbCardType.DisplayMember = "PriceDescription";
            cmbCardType.ValueMember = "PriceId";

            cmbCardType.SelectedIndex = (int)this.Tag;
            txtTickets.Text = price.GetPrice((int)this.Tag).Count.ToString();

        }

        private void gbMember_Enter(object sender, EventArgs e)
        {

        }

        private void frmNewMember_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            txtValidTo.Text = DateTime.Now.ToShortDateString();
        }

    }
}
