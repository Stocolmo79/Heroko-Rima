using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerokoRima;
using HerokoRima.Forms;

using HerokoRimaEntrada;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
