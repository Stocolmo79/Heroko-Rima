using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Classes;
using Classes.Classes;
using HerokoRima.Forms;
using HerokoRimaEntrada;

namespace Main
{
    public partial class Main : Form
    {
        public tCard tCard;

        public Cards cards;
        public Main()
        {
            cards = new Cards();
            InitializeComponent();
            SetCardsToDisabled();
        }

        private void SetCardsToDisabled()
        {
            cards.SetCardsToDisabled();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminMain = new FrmMain();
            adminMain.ShowDialog();


        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            var entranceMain = new frmMain();
            entranceMain.ShowDialog();
        }
    }
}
