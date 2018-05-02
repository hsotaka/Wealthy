using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WealthManagement
{
    public partial class FrmWealthManagement : Form
    {
        public FrmWealthManagement()
        {
            InitializeComponent();
        }

        private void pcbIncome_MouseLeave(object sender, EventArgs e)
        {
            pcbIncome.BackgroundImage = Properties.Resources._49250_house_with_dollar_sign_for_real_estate_business;
        }

        private void pcbIncome_MouseEnter(object sender, EventArgs e)
        {
            pcbIncome.BackgroundImage = Properties.Resources._49250_house_with_dollar_sign_for_real_estate_business1;
        }

        private void pcbLifeSaving_MouseEnter(object sender, EventArgs e)
        {
            pcbLifeSaving.BackgroundImage = Properties.Resources._45171_money_bills1;
        }

        private void pcbLifeSaving_MouseLeave(object sender, EventArgs e)
        {
            pcbLifeSaving.BackgroundImage = Properties.Resources._45171_money_bills;
        }

        private void pcbPreciousMetal_Click(object sender, EventArgs e)
        {

        }

        private void pcbPreciousMetal_MouseEnter(object sender, EventArgs e)
        {
            pcbPreciousMetal.BackgroundImage = Properties.Resources._80985_six_gold_bars;
        }

        private void pcbPreciousMetal_MouseLeave(object sender, EventArgs e)
        {
            pcbPreciousMetal.BackgroundImage = Properties.Resources._80985_six_gold_bars1;
        }

        private void pcbCrypto_MouseEnter(object sender, EventArgs e)
        {
            pcbCrypto.BackgroundImage = Properties.Resources._37011_bitcoin_coin1;
        }

        private void pcbCrypto_MouseLeave(object sender, EventArgs e)
        {
            pcbCrypto.BackgroundImage = Properties.Resources._37011_bitcoin_coin;
        }

        private void pcbSettings_MouseEnter(object sender, EventArgs e)
        {
            pcbSettings.BackgroundImage = Properties.Resources.settings1;
        }

        private void pcbSettings_MouseLeave(object sender, EventArgs e)
        {
            pcbSettings.BackgroundImage = Properties.Resources.settings;
        }
    }
}
