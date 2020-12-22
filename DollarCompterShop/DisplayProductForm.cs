using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompterShop
{
    public partial class DisplayProductForm : Form
    {
        public DisplayProductForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formDictionary[FormEnumClass.CHECKOUT_FORM].Show();
        }


        private void DisplayProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formDictionary[FormEnumClass.NEW_ORDER_FORM].Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formDictionary[FormEnumClass.NEW_ORDER_FORM].Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formDictionary[FormEnumClass.START_FORM].Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.about.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing your order...!!", "Printing...", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void DisplayProductForm_Activated(object sender, EventArgs e)
        {
            this.productIdTextField.Text = Program.productinfoStore.productID;

            this.conditionTextField.Text = Program.productinfoStore.condition;

            this.costTextField.Text = Program.productinfoStore.Cost.ToString();

            this.platformTextField.Text = Program.productinfoStore.platform;

            this.OSTextField.Text = Program.productinfoStore.OS;

            this.ManufacturerTextField.Text = Program.productinfoStore.Manufacturer;

            this.modelTextField.Text = Program.productinfoStore.Model;
            this.memoryTextField.Text = Program.productinfoStore.RAM_size;
            this.lcdsizeTextField.Text = Program.productinfoStore.screensize;
            this.hddTextField.Text = Program.productinfoStore.HDD_size;
            this.CPUNumberTextField.Text = Program.productinfoStore.CPU_number;
            this.GPUTypeTextField.Text = Program.productinfoStore.GPU_Type;
            this.CPUTypeTextField.Text = Program.productinfoStore.CPU_type;


            this.CPUSpeedTextField.Text = Program.productinfoStore.CPU_speed;
            this.WebCamTextField.Text = Program.productinfoStore.webcam;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files(*.txt) | *.txt | All files(*.*) | *.*";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.FileName = "Untitled.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(path: "productinfo.txt"))
                    {
                        streamWriter.WriteLine(Program.productinfoStore.productID);


                        streamWriter.WriteLine(Program.productinfoStore.condition);

                        streamWriter.WriteLine(Program.productinfoStore.Cost.ToString());

                        streamWriter.WriteLine(Program.productinfoStore.platform);

                        streamWriter.WriteLine(Program.productinfoStore.OS);

                        streamWriter.WriteLine(Program.productinfoStore.Manufacturer);

                        streamWriter.WriteLine(Program.productinfoStore.Model);
                        streamWriter.WriteLine(Program.productinfoStore.RAM_size);
                        streamWriter.WriteLine(Program.productinfoStore.screensize);
                        streamWriter.WriteLine(Program.productinfoStore.HDD_size);
                        streamWriter.WriteLine(Program.productinfoStore.CPU_number);
                        streamWriter.WriteLine(Program.productinfoStore.GPU_Type);
                        streamWriter.WriteLine(Program.productinfoStore.CPU_type);


                        streamWriter.WriteLine(Program.productinfoStore.CPU_speed);
                        streamWriter.WriteLine(Program.productinfoStore.webcam);

                        streamWriter.Close();
                        streamWriter.Dispose();
                        MessageBox.Show("Product info saved successfully!", "Product saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error Saving data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
