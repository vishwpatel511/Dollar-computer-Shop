using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompterShop
{
    public partial class CheckoutScreen : Form
    {
        public CheckoutScreen()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formDictionary[FormEnumClass.START_FORM].Show();
        }

        private void CheckoutScreen_Activated(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(path: "productinfo.txt");
            this.productIdTextField.Text = reader.ReadLine();

            this.conditionTextField.Text = reader.ReadLine();

            this.ProductTotalTextField.Text = reader.ReadLine();

            this.platformTextField.Text = reader.ReadLine();

            this.OSTextField.Text = reader.ReadLine();

            this.ManufacturerTextField.Text = reader.ReadLine();
            
            this.modelTextField.Text = reader.ReadLine();
            this.memoryTextField.Text = reader.ReadLine();
            this.lcdsizeTextField.Text = reader.ReadLine();
            this.hddTextField.Text = reader.ReadLine();
            this.CPUNumberTextField.Text = reader.ReadLine();
            this.GPUTypeTextField.Text = reader.ReadLine();
            this.CPUTypeTextField.Text = reader.ReadLine();


            this.CPUSpeedTextField.Text = reader.ReadLine();
            this.WebCamTextField.Text = reader.ReadLine();
            reader.Close();
            reader.Dispose();
            this.TaxTextField.Text = "13 %";
            const double tax = 1.13;
            double netTotal = Convert.ToDouble(this.ProductTotalTextField.Text);
            this.GrandTotalTextField.Text = (Convert.ToString(Math.Round((netTotal * tax), 2)));
        }
    }
}
