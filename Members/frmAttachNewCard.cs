using System;

using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;

namespace Members
{
    public partial class frmAttachNewCard : Form
    {
        public Int32 ReturnValue { get; set; }

        public tCard oldCard;

        public tCard newCard = new tCard();
        public Member member =new Member();
        public tCardUsage tCardUsage = new tCardUsage();

        public CardUsage cardUsage =new CardUsage();
        public Cards cards = new Cards();
        public int tag;

        public frmAttachNewCard()
        {

            InitializeComponent();
            this.btnAccept.DialogResult = DialogResult.OK;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text.Length <= 0)
            {
                return;
            }
            oldCard = cards.GetCard(tag);
           
            newCard.CardId = Convert.ToInt64(txtMemberId.Text);
            newCard.Changed = DateTime.Today;
            newCard.Enabled = true;
            newCard.EndDate = oldCard.EndDate;
            newCard.StartDate = oldCard.StartDate;
            newCard.Tickets = oldCard.Tickets;
            newCard.TypeId = oldCard.TypeId;
            
            tCardUsage.CardId = newCard.CardId;
            tCardUsage.EntranceDate = DateTime.Now;
            tCardUsage.Description = "Nueva tarjeta de vieja tarjeta " + oldCard.CardId;
            
            cards.SaveNewCard(newCard);
            cardUsage.MoveCardUsage(oldCard.CardId,newCard.CardId);
            member.MoveMember(oldCard.CardId, newCard.CardId);
            cardUsage.InsertCardUsage(tCardUsage);
            oldCard.Enabled = false;
            cards.SaveCard(oldCard);
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
