using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

namespace Cashier
{
    public partial class frmCashier : Form
    {
        public int startPh;
        public int startPv;

        public tOrder tOrder;
        public Order order;

        public tOrderItem tOrderItem;
        public List<tOrderItem> tOrderItems;
        public OrderItem orderItem;

        public tPrice tPrice;
        public List<tPrice> tPrices;
        public Price price;

        public long totalSum;

        public frmCashier()
        {

            InitializeComponent();
            startPh = 1300;
            startPv = 900;
            price = new Price();
            tPrices = price.GetPrices();
        }

        private void btnTicketAdult_Click(object sender, EventArgs e)
        {
            AddPurchaseText(GetTime() > 0 ? tPrices.FirstOrDefault(s => s.PriceId == 7) : tPrices.FirstOrDefault(s => s.PriceId == 5));
        }
        private void btnTicketStudent_Click(object sender, EventArgs e)
        {
            AddPurchaseText(GetTime() > 0 ? tPrices.FirstOrDefault(s => s.PriceId == 6) : tPrices.FirstOrDefault(s => s.PriceId == 4));
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

            tOrderItems = new List<tOrderItem>();
        }

        private void AddPurchaseText(tPrice p)
        {
            tOrderItem = new tOrderItem();
            var tempOIs = new List<tOrderItem>();
            order = new Order();
            if (tOrderItems.Any())
            {
                if (tOrderItems.Exists(toi => toi.PriceId == p.PriceId))
                {
                    foreach (var item in tOrderItems.Where(w => w.PriceId == p.PriceId))
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
                    tOrderItem.tPrice = price.GetPrice(p.PriceId);
                    tempOIs.Add(tOrderItem);
                }

                foreach (var tempOi in tempOIs)
                {
                    tOrderItems.Add(tempOi);
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
                tOrderItem.tPrice = price.GetPrice(p.PriceId);
                tOrderItems.Add(tOrderItem);

            }


            ShowInListView(tOrderItems);
        }

        private void ShowInListView(List<tOrderItem> orderItems)
        {
            lvViewPurchase.Clear();
            lvViewPurchase.View = View.Details;
            lvViewPurchase.FullRowSelect = true;

            lvViewPurchase.Columns.Add("Cantidad");
            lvViewPurchase.Columns.Add("Descripción");
            lvViewPurchase.Columns.Add("Precio");
            lvViewPurchase.Columns.Add("Total");
            lvViewPurchase.Columns.Add("Quitar");

            if (orderItems.Any())
            {
                foreach (var row in orderItems)
                {
                    var item = new ListViewItem { Text = row.Quantity.ToString(), Tag = row.tPrice.PriceId };
                    item.SubItems.Add(row.tPrice.PriceDescription); // 2nd column text
                    item.SubItems.Add(row.tPrice.PriceValue.ToString());
                    item.SubItems.Add((row.Quantity * row.tPrice.PriceValue).ToString());
                    item.SubItems.Add("u");
                    lvViewPurchase.Items.Add(item);
                }
            }

            foreach (ColumnHeader column in lvViewPurchase.Columns)
            {
                column.Width = -2;
            }
            var sum = tOrderItems.Aggregate<tOrderItem, long?>(0, (current, item) => current + item.TotalAmount);
            lblTotalSum.Text = sum.ToString();
        }

        private void lblTotalDescription_Click(object sender, EventArgs e)
        {

        }

        private void lvViewPurchase_DoubleClick(object sender, EventArgs e)
        {

            var toi = tOrderItems.FirstOrDefault(w => w.PriceId == Convert.ToInt32(lvViewPurchase.SelectedItems[0].Tag));
            if (toi == null) return;


            if (toi.Quantity > 1)
            {
                toi.Quantity -= 1;
                toi.TotalAmount = toi.Quantity * toi.tPrice.PriceValue;
            }
            else
            {
                tOrderItems.RemoveAll(x => x.PriceId == Convert.ToInt32(lvViewPurchase.SelectedItems[0].Tag));
            }
            ShowInListView(tOrderItems);
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

        private void btnMonthlyStudent_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == 1));
        }

        private void btnMonthlyAdult_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == 2));
        }

        private void btnTicketsStudent_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == 3));
        }

        private void btnTicketsAdult_Click(object sender, EventArgs e)
        {
            AddPurchaseText(tPrices.FirstOrDefault(s => s.PriceId == 4));
        }
    }
}

