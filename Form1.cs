using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_handling_with_table
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            table.Columns.Add("name");
            table.Columns.Add("rollno");
            table.Columns.Add("clss");
            dataGridView1.DataSource = table;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
           int a= dataGridView1.RowCount;
           // MessageBox.Show(a.ToString());
            int b = 0;
            while (b<a)
            {
                DataRow row1 = table.NewRow();
               string roll = dataGridView1.Rows[b].Cells[0].Value.ToString();
               string name = dataGridView1.Rows[b].Cells[1].Value.ToString();
               string clss = dataGridView1.Rows[b].Cells[2].Value.ToString();
                

                b++;

                row1["name"] = name;
                row1["rollno"] = roll;
                row1["clss"] = clss;
                table.Rows.Add(row1);
                dataGridView1.Refresh();
             
                break;
            }*/
            /*foreach (DataRow row in dataGridView1.Rows)
            {
                DataRow row1 = table.NewRow();

                row1["name"] = row["name"];
                row1["rollno"] = row["rollno"];
                row1["clss"] = row["clss"];
                table.Rows.Add(row1);
                dataGridView1.Refresh();

            }*/

            Form2 form2 = new Form2(table);
            form2.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
