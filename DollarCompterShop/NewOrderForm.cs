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
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productinfoStore.productID =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[0].Value.ToString();
            Program.productinfoStore.condition =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[14].Value.ToString();
            Program.productinfoStore.Cost =
                Convert.ToDouble(DollarComputerDataGridNewOrderForm.CurrentRow.Cells[1].Value.ToString());
            Program.productinfoStore.platform =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[16].Value.ToString();
            Program.productinfoStore.OS =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[15].Value.ToString();
            Program.productinfoStore.Manufacturer =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[2].Value.ToString();
            Program.productinfoStore.Model =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[3].Value.ToString();
            Program.productinfoStore.RAM_size =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[5].Value.ToString();
            Program.productinfoStore.screensize =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[7].Value.ToString();
                Program.productinfoStore.HDD_size =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[17].Value.ToString();
            Program.productinfoStore.CPU_number =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[13].Value.ToString();
            Program.productinfoStore.GPU_Type =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[19].Value.ToString();
            Program.productinfoStore.CPU_type =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[12].Value.ToString();
            Program.productinfoStore.CPU_speed =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[13].Value.ToString();
            Program.productinfoStore.webcam =
                DollarComputerDataGridNewOrderForm.CurrentRow.Cells[30].Value.ToString();

            Program.formDictionary[FormEnumClass.DISPLAY_PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.formDictionary[FormEnumClass.START_FORM].Show();
            this.Hide();
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputerDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputerDataSet.products);

        }

        private void DollarComputerDataGridNewOrderForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectionChanged_Event(object sender, EventArgs e)
        {
            this.SelecteditemDisplayTextField.Text = ToString();

        }


        public override string ToString()
        {
            string initString = "";
            try
            {
                initString += DollarComputerDataGridNewOrderForm.CurrentRow.Cells[2].Value.ToString() + ", ";
                
                initString += DollarComputerDataGridNewOrderForm.CurrentRow.Cells[3].Value.ToString() + ", Priced at: ";
                initString += DollarComputerDataGridNewOrderForm.CurrentRow.Cells[1].Value.ToString() + " , ";
            }
            catch
            {
                initString += "Product can't be retrieved. Please try back later";
            }


            return initString;
        }
    }
}


