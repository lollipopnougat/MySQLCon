using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLCon
{
    public partial class Form3 : Form
    {
        private DataTable dt = new DataTable();
        public Form3(DataTable dtt)
        {
            InitializeComponent();
            dt = dtt;
            dataGridView1.DataSource = dt;
        }
    }
}
