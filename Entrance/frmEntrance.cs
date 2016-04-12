using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;

using HerokoRimaEntrada.Properties;

namespace HerokoRimaEntrada
{
    public partial class frmEntrance : Form
    {
        public tMember tMember;

        public Member members;

        public tCard tCard;

        public Cards cards;

        public tCardUsage tCardUsage;

        public CardUsage cardUsage;

        public frmEntrance()
        {

            InitializeComponent();
            tTimer.Start();
            members = new Member();
            cards = new Cards();
            cardUsage = new CardUsage();
        }

        private void txtUserMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtUserMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchMember();
            }
        }

        private void SearchMember()
        {
            var m = members.GetMember(txtUserMember.Text);
            if (m == null)
            {
                lblGreeting.Text = Resources.frmMain_SearchMember_Este_usario_no_existe_;
            }
            else
            {
                var c = cards.GetCardInfo(m.MemberId);

                if (c == null) return;
                switch (c.tPrice.PriceId)
                {
                    case 1:
                        if (c.EndDate > DateTime.Now)
                        {
                            SaveMonthly(c);
                            SetColor(Color.Green);
                            SetGreeting(m, c);
                        }
                        else
                        {
                            SetColor(Color.Red);
                            lblGreeting.Text = "Fecha ya ha caducado";
                        }

                        break;
                    case 2:
                        if (c.EndDate > DateTime.Now)
                        {
                            SaveMonthly(c);
                            SetColor(Color.Green);
                            SetGreeting(m, c);
                        }
                        else
                        {
                            SetColor(Color.Red);
                            lblGreeting.Text = "Fecha ya ha caducado";
                        }

                  //TODO: Save 6-tickets

                        break;

                    default:
                        if (c.Tickets == 0)
                        {
                            SetColor(Color.Red);
                            lblGreeting.Text = "No le queda tickets.";
                        }
                        else
                        {
                            SaveTickets(c);
                            SetColor(Color.Green);
                            SetGreeting(m, c);
                        }

                        break;
                }
            }
            tGreetings.Start();
        }

        private void SetGreeting(tMember m, tCard c)
        {
            lblGreeting.Text = "Hola";
            lblName.Text = m.Firstname + " " + m.Lastname;
            lblMembershipInfo.Text = c.tPrice.PriceDescription;
        }

        private void SaveMonthly(tCard card)
        {
            SaveCardUsage(card);
        }

        private void SaveCardUsage(tCard card)
        {
            tCardUsage = new tCardUsage { CardId = card.CardId, EntranceDate = DateTime.Now };
            cardUsage.InsertCardUsage(tCardUsage);
        }

        private void SaveTickets(tCard card)
        {
            card.Tickets = card.Tickets - 1;
            SaveCardUsage(card);
            cards.SaveCard(card);
        }

        private void SetColor(Color color)
        {
            lblGreeting.ForeColor = color;
            lblName.ForeColor = color;
            lblMembershipInfo.ForeColor = color;
        }

        private void tGreetings_Tick(object sender, EventArgs e)
        {
            lblGreeting.Text = "";
            lblName.Text = "";
            lblMembershipInfo.Text = "";
            txtUserMember.Text = "";
            tGreetings.Stop();
        }

        private void tTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss", new CultureInfo("es-CL"));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
