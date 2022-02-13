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
    public partial class Form2 : Form
    {
        DataTable table = new DataTable();

        public Form2(DataTable table1)
        {
            InitializeComponent();
            table.Columns.Add("name");
            table.Columns.Add("rollno");
            table.Columns.Add("clss");
            table = table1;
            dataGridView1.DataSource = table;
           
            dataGridView1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
