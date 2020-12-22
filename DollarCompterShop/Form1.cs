using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompterShop
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            SplashScreenTimer.Enabled = false;
            Program.startform.Show();
            
        }
    }
}
