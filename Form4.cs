using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecom
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void picb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_iphone_Click(object sender, EventArgs e)
        {

        }

        private void btt_aud_Click(object sender, EventArgs e)
        {

        }

        private void btt_ipad_Click(object sender, EventArgs e)
        {

        }

        private void btt_watch_Click(object sender, EventArgs e)
        {

        }

        private void btt_mac_Click(object sender, EventArgs e)
        {

        }

        private void btt_acs_Click(object sender, EventArgs e)
        {

        }

        private void btt_acs_MouseEnter(object sender, EventArgs e)
        {
            btt_acs.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void btt_acs_MouseLeave(object sender, EventArgs e)
        {
            btt_acs.BackColor = Color.FromArgb(16, 16, 16);
        }

        private void btt_iphone_MouseEnter(object sender, EventArgs e)
        {
            btt_iphone.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void btt_iphone_MouseLeave(object sender, EventArgs e)
        {
            //btt_acs.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void btt_mac_MouseEnter(object sender, EventArgs e)
        {
            btt_mac.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void btt_iphone_MouseLeave_1(object sender, EventArgs e)
        {
            btt_iphone.BackColor = Color.FromArgb(16, 16, 16);
        }

        private void btt_mac_MouseLeave(object sender, EventArgs e)
        {
            btt_mac.BackColor = Color.FromArgb(16, 16, 16);

        }

        private void btt_ipad_MouseEnter(object sender, EventArgs e)
        {
            btt_ipad.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void btt_ipad_MouseLeave(object sender, EventArgs e)
        {
            btt_ipad.BackColor = Color.FromArgb(16, 16, 16);
        }

        private void btt_watch_MouseEnter(object sender, EventArgs e)
        {
            btt_watch.BackColor = Color.FromArgb(45, 45, 45);

        }

        private void btt_watch_MouseLeave(object sender, EventArgs e)
        {
            btt_watch.BackColor = Color.FromArgb(16, 16, 16);

        }

        private void btt_aud_MouseEnter(object sender, EventArgs e)
        {
            btt_aud.BackColor = Color.FromArgb(45, 45, 45);

        }

        private void btt_aud_MouseLeave(object sender, EventArgs e)
        {
            btt_aud.BackColor = Color.FromArgb(16, 16, 16);

        }
    }
}
