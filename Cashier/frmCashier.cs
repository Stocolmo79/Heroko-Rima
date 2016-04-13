using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;

using Members;
namespace HerokoRima
{
    public partial class frmCashier : Form
    {
        public int startPh;
        public int startPv;

        public tOrder tOrder;
        public Order order;

        public tMember tMember;

        public Member members;
        public tCard tCard;
        public Cards cards;
        public tCardUsage tCardUsage;
        public CardUsage cardUsage;
        public tOrderItem tOrderItem;

        public OrderItem orderItem;

        public tPrice tPrice;
        public List<tPrice> tPrices;
        public Price price;

        public long totalSum;

        private enum Types
        {
            MonthStudent = 1,
            MonthAdult = 2,
            SixTicketsStudent = 3,
            SixTicketsAdult = 4,
            DayTicketStudent = 5,
            DayTicketAdult = 6,
            EveningTicketStudent = 7,
            EveningTicketAdult = 8
        }

        public frmCashier()
        {

            InitializeComponent();
            startPh = 1300;
            startPv = 900;
            price = new Price();
            tPrices = price.GetPrices();
            cards = new Cards();
            members = new Member();
            cardUsage = new CardUsage();
            tCardUsage = new tCardUsage();
            InitListView(true);
        }

        private void btnTicketAdult_Click(object sender, EventArgs e)
        {
            AddPurchaseText(GetTime() > 0 ? tPrices.FirstOrDefault(s => s.PriceId == (int)Types.EveningTicketAdult) : tPrices.FirstOrDefault(s => s.PriceId == (int)Types.DayTicketAdult));
        }
        private void btnTicketStudent_Click(object sender, EventArgs e)
        {
            AddPurchaseText(GetTime() > 0 ? tPrices.FirstOrDefault(s => s.PriceId == (int)Types.EveningTicketStudent) : tPrices.FirstOrDefault(s => s.PriceId == (int)Types.DayTicketStudent));
        }
        private void btnMonthlyStudent_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == (int)Types.MonthStudent));

            SetButtons(true, false, false, false); AttachToCard(Types.MonthStudent);
        }



        private void btnMonthlyAdult_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == (int)Types.MonthAdult));

            SetButtons(false, true, false, false); AttachToCard(Types.MonthAdult);
        }

        private void btnTicketsStudent_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == (int)Types.SixTicketsStudent));

            SetButtons(false, false, true, false); AttachToCard(Types.SixTicketsStudent);
        }

        private void btnTicketsAdult_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == (int)Types.SixTicketsAdult));

            SetButtons(false, false, false, true); AttachToCard(Types.SixTicketsAdult);
        }
        private void AttachToCard(Types types)
        {
            using (var attachCardForm = new frmAttachCard { TopLevel = true, AutoScroll = true, Dock = DockStyle.Fill, tag = (int)types })
            {
                switch (attachCardForm.ShowDialog())
                {
                    case DialogResult.Cancel:
                        RemoveRow((int)types);
                        SetButtons(true, true, true, true);
                        ShowLabels(false);
                        break;
                    case DialogResult.OK:
                        var value = attachCardForm.ReturnValue;
                        if (value == 0)
                        {
                            RemoveRow((int)types);
                            SetButtons(true, true, true, true);

                            return;
                        }
                        tCard = cards.GetCard(value);
                        tMember = members.GetMember(tCard.CardId.ToString());
                        lblName.Text = tMember.Firstname + " " + tMember.Lastname;
                        lblCardId.Text = tCard.CardId.ToString();
                        ShowLabels(true);

                        cards.SaveCard(UpdateCard(tCard, tPrices.Find(p => p.PriceId == (int)types)));
                        tCardUsage.CardId = tCard.CardId;
                        tCardUsage.EntranceDate = DateTime.Now;
                        tCardUsage.Description = "Compra de: " + tCard.tPrice.PriceDescription;
                        cardUsage.InsertCardUsage(tCardUsage);
                        break;
                    default:
                        SetButtons(true, true, true, true);
                        int i = 4;
                        break;

                }
            }

        }

        private void ShowLabels(bool show)
        {
            lblName.Visible = show;
            lblNameLabel.Visible = show;
            lblCardId.Visible = show;
            lblCardIdLabel.Visible = show;
        }

        private tCard UpdateCard(tCard c, tPrice p)
        {
            c.StartDate = DateTime.Now;
            c.EndDate = DateTime.Now.AddMonths(1);
            c.Changed = DateTime.Now;
            c.Enabled = true;
            c.Tickets = p.Count;

            c.TypeId = p.PriceId;
            return c;
        }

        private void SetButtons(bool b1, bool b2, bool b3, bool b4)
        {
            btnMonthlyStudent.Enabled = b1;
            btnMonthlyAdult.Enabled = b2;

            btnTicketsStudent.Enabled = b3;
            btnTicketsAdult.Enabled = b4;
        }

        private static int GetTime()
        {
            var dt = DateTime.Now;
            var t2 = Convert.ToDateTime("16:00:00");
            var i = DateTime.Compare(dt, t2);
            return i;
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {
            tOrder = new tOrder { tOrderItems = new List<tOrderItem>() };
        }

        private void AddPurchaseText(tPrice p)
        {
            tOrderItem = new tOrderItem();
            var tempOIs = new List<tOrderItem>();
            order = new Order();
            if (tOrder.tOrderItems.Any())
            {
                if (tOrder.tOrderItems.Any(toi => toi.PriceId == p.PriceId))
                {
                    foreach (var item in tOrder.tOrderItems.Where(w => w.PriceId == p.PriceId))
                    {

                        item.Quantity += 1;
                        item.TotalAmount = item.Quantity * p.PriceValue;
                    }
                }
                else
                {
                    if (p.PriceValue != null)
                    {
                        totalSum += p.PriceValue.Value;
                    }
                    tOrderItem.PriceId = p.PriceId;
                    tOrderItem.Quantity = 1;
                    tOrderItem.TotalAmount = tOrderItem.Quantity * p.PriceValue;

                    tOrderItem.OrderItemId = 0;


                    tOrderItem.OrderDate = DateTime.Now;

                    tempOIs.Add(tOrderItem);
                }

                foreach (var tempOi in tempOIs)
                {
                    tOrder.tOrderItems.Add(tempOi);
                }

            }
            else
            {
                if (p.PriceValue != null)
                {
                    totalSum += p.PriceValue.Value;
                }
                tOrderItem.PriceId = p.PriceId;
                tOrderItem.Quantity = 1;
                tOrderItem.TotalAmount = tOrderItem.Quantity * p.PriceValue;
                tOrderItem.OrderDate = DateTime.Now;

                tOrderItem.OrderItemId = 0;

                tOrder.tOrderItems.Add(tOrderItem);

            }


            ShowInListView(tOrder.tOrderItems);
        }

        private void ShowInListView(ICollection<tOrderItem> orderItems)
        {

            InitListView(false);

            if (orderItems.Any())
            {
                foreach (var row in orderItems)
                {
                    var item = new ListViewItem { Text = row.Quantity.ToString(), Tag = row.PriceId };
                    item.SubItems.Add(tPrices.First(p => p.PriceId == row.PriceId).PriceDescription); // 2nd column text
                    item.SubItems.Add(tPrices.First(p => p.PriceId == row.PriceId).PriceValue.ToString());
                    item.SubItems.Add((row.Quantity * tPrices.First(p => p.PriceId == row.PriceId).PriceValue).ToString());
                    item.SubItems.Add("u");
                    lvViewPurchase.Items.Add(item);
                }
            }



            var sum = tOrder.tOrderItems.Aggregate<tOrderItem, long?>(0, (current, item) => current + item.TotalAmount);
            lblTotalSum.Text = sum.ToString();
        }

        private void InitListView(bool b)
        {
            lvViewPurchase.Clear();
            lvViewPurchase.View = View.Details;
            lvViewPurchase.FullRowSelect = true;
            var header = new ColumnHeader { Text = "Cantidad", Width = 200, TextAlign = HorizontalAlignment.Center };
            lvViewPurchase.Columns.Add(header);
            header = new ColumnHeader { Text = "Descripción", Width = 200, TextAlign = HorizontalAlignment.Center };
            lvViewPurchase.Columns.Add(header);
            header = new ColumnHeader { Text = "Precio", Width = 200, TextAlign = HorizontalAlignment.Center };
            lvViewPurchase.Columns.Add(header);
            header = new ColumnHeader { Text = "Total", Width = 200, TextAlign = HorizontalAlignment.Center };
            lvViewPurchase.Columns.Add(header);
            header = new ColumnHeader { Text = "Quitar", Width = 100, TextAlign = HorizontalAlignment.Center };
            lvViewPurchase.Columns.Add(header);
            if (!b)
            {
                return;
            }
            var item = new ListViewItem();
            lvViewPurchase.Items.Add(item);
        }

        private void lblTotalDescription_Click(object sender, EventArgs e)
        {

        }

        private void lvViewPurchase_DoubleClick(object sender, EventArgs e)
        {
            RemoveRow(Convert.ToInt32(lvViewPurchase.SelectedItems[0].Tag));
        }

        public void RemoveRow(int tag)
        {
            var toi = tOrder.tOrderItems.FirstOrDefault(w => w.PriceId == tag);
            if (toi == null) return;

            if (toi.Quantity > 1)
            {
                toi.Quantity -= 1;
                toi.TotalAmount = toi.Quantity * tPrices.First(p => p.PriceId == toi.PriceId).PriceValue;
            }
            else
            {
                foreach (var item in tOrder.tOrderItems.Where(item => item.PriceId == tag))
                {
                    tOrder.tOrderItems.Remove(item);
                    break;
                }

            }
            ShowInListView(tOrder.tOrderItems);
        }



        private void lvViewPurchase_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var s = e.Header;
            var colH = new ColumnHeader { Name = "Quitar", Text = "Quitar" };

            if (s.Text != colH.Text)
            {
                e.DrawDefault = true;
                return;
            }

            e.DrawBackground();
            var imageRect = new Rectangle(e.Bounds.X, e.Bounds.Y, 14, 14);
            e.Graphics.DrawImage(SystemIcons.Hand.ToBitmap(), imageRect);
        }

        private void lvViewPurchase_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (tCard != null)
            {
                tCard.Enabled = false;
                cards.SaveCard(tCard);
            }

            ResetWindow();
        }

        private void ResetWindow()
        {
            SetButtons(true, true, true, true);
            lvViewPurchase.Clear();
            lblTotalSum.Text = "";
            ShowLabels(false);
            InitListView(true);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            order = new Order();
            orderItem = new OrderItem();
            tOrder.TotalAmount = Convert.ToInt64(lblTotalSum.Text);
            if (tCard != null)
            {
                tOrder.MemberId = tCard.CardId;
            }

            order.SaveOrder(tOrder);

            ResetWindow();
        }



    }
}

