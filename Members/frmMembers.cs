using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;

namespace Members
{
    public partial class frmMembers : Form
    {
        public bool newMember;
        public tMember tMember;
        public tCardUsage tCardUsage;
        public tType tType;
        public Member members;


        public tPrice tPrice;


        public tCard tCard;
        public Cards cards;
        public CardUsage cardUsage;


        public frmMembers()
        {
            members = new Member();
            cards = new Cards();
            cardUsage = new CardUsage();
            InitializeComponent();
            loadComboBox();
            lvCardUsage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchClick();
        }

        private void SearchClick()
        {
            ClearScreen();
            SearchMember(txtInput.Text);
        }

        private void ClearScreen()
        {
            txtCellphone.Text = "";
            txtMemberId.Text = "";
            txtMemberName.Text = "";
            txtLastNames.Text = "";
            txtMemberType.Text = "";
            cmbCardType.SelectedIndex = 0;
            txtValidTo.Text = "";
            chkValid.Checked = false;
            lvCardUsage.Clear();
        }

        private void SetCardInfo(string text)
        {
            var cardrows = cardUsage.GetCardUsage(Convert.ToInt64(text));

            lvCardUsage.View = View.Details;

            lvCardUsage.Columns.Add("Descripción");

            lvCardUsage.Columns.Add("Uso");
            if (cardrows.Any())
            {
                foreach (var row in cardrows)
                {
                    var item = row.Description != null ? new ListViewItem { Text = row.Description } : new ListViewItem { Text = row.tCard.tPrice.PriceDescription };
            
                    item.SubItems.Add(Convert.ToDateTime(row.EntranceDate).ToShortDateString() + " " + Convert.ToDateTime(row.EntranceDate).ToShortTimeString()); // 2nd column text

                    lvCardUsage.Items.Add(item);
                }
            }
            //    btnRenewDate.Visible = ((bool)!tCard.Enabled);

            foreach (ColumnHeader column in lvCardUsage.Columns)
            {
                column.Width = -2;
            }
        }

        private void SearchMember(string input)
        {
            tMember = new tMember();
            tMember = members.GetMember(input);
            newMember = false;
            if (tMember == null) return;

            tCard = cards.GetCardInfo((long)tMember.CardId);
            SetCardInfo(tMember.CardId.ToString());

            txtCellphone.Text = tMember.Cellphone;
            txtMemberId.Text = tMember.MemberId.ToString();
            txtMemberName.Text = tMember.Firstname;
            txtLastNames.Text = tMember.Lastname;
            txtMemberType.Text = tMember.tMemberType.MemberTypeDescription;

            if (tCard != null)
            {
                txtValidTo.Text = tCard.EndDate.Value.ToShortDateString();
                if (tCard.EndDate < DateTime.Now)
                {
                    txtValidTo.ForeColor = Color.DarkRed;
                }
            }
            txtTickets.Text = tCard.Tickets.ToString();
            cmbCardType.SelectedIndex = tCard.TypeId;
            if (tCard.Enabled != null)
            {
                chkValid.Checked = (bool)tCard.Enabled;
            }
            SetgbMember();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            this.ResetInputFields();
            gbSearchMember.Enabled = !newMember;
            SetgbMember();
            if (!newMember)
            {
                return;
            }
            loadComboBox();
            txtValidTo.Text = DateTime.Now.AddMonths(1).ToShortDateString();
        }

        private void SetgbMember()
        {
            txtMemberId.Enabled = false;

            txtMemberId.BackColor = Color.White;
            txtMemberId.ForeColor = Color.Black;
            txtTickets.BackColor = Color.White;
            txtTickets.ForeColor = Color.Black;

        }

        private void loadComboBox()
        {
            cmbCardType.DataSource = Combobox.LoadComboBoxCardTypes();
            cmbCardType.DisplayMember = "PriceDescription";
            cmbCardType.ValueMember = "PriceId";
        }

        private void ResetInputFields()
        {

            txtCellphone.Text = "";
            txtInput.Text = "";
            txtLastNames.Text = "";
            txtMemberId.Text = "";
            txtMemberName.Text = "";
            txtValidTo.Text = "";
            chkValid.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.tPrice = (tPrice)this.cmbCardType.SelectedItem;
            if (this.tPrice.PriceId <= 0 || txtValidTo.Text.Length == 0 || txtMemberName.Text.Length == 0 || txtLastNames.Text.Length == 0 || txtCellphone.Text.Length == 0)
            {
                return;
            }
            if (this.newMember)
            {
                this.tMember = new tMember();
                this.tCard = new tCard();
                if (this.txtMemberName.Text != "" && this.txtCellphone.Text != "")

                    members.SaveMember(PopulateMember());

                cards.SaveCard(PopulateCard());
            }
            else
            {
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

        private void btnRenewDate_Click(object sender, EventArgs e)
        {
            txtValidTo.Text = DateTime.Now.AddMonths(1).ToShortDateString();
            txtValidTo.ForeColor = Color.Black;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchClick();
            }
        }

        private void lvCardUsage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCellphone_Leave(object sender, EventArgs e)
        {
            var pattern = new Regex("^[- +()]?[1-9]{1}[0-9]{3,14}$");
            if (pattern.IsMatch(txtCellphone.Text))
            {
               
            }
            else
            {
                txtCellphone.Text = "Numero no valido";
            }
        }
    }
}
