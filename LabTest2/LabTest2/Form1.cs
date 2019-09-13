using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = CustomerName.Text;
            string number = ContactNumber.Text;
             string address = Address.Text;
            string order = Order.Text;
            string quantity = Quantity.Text;
            int unitPrice = 0;

            if (order == "Black-120")
            {
                unitPrice = 120;
            }
            else if (order == "Cold-100")
            {
                unitPrice = 100;
            }
            else if (order == "Hot-90")
            {
                unitPrice = 90;
            }
            else if (order == "Regular-80")
            {
                unitPrice = 80;
            }
            else
            {
                unitPrice = 0;
            }

            int quantity1 = Convert.ToInt32(quantity);
            int totalPrice = quantity1 * unitPrice;

            int a = dataGridView1.Rows.Add();
            dataGridView1.Rows[a].Cells[0].Value = name;
            dataGridView1.Rows[a].Cells[1].Value = number;
            dataGridView1.Rows[a].Cells[2].Value = address;
            dataGridView1.Rows[a].Cells[3].Value = order;
            dataGridView1.Rows[a].Cells[4].Value = quantity1;
            dataGridView1.Rows[a].Cells[5].Value = totalPrice;




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
