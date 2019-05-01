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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string sqlcon = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            //server = 127.0.0.1; port = 3306; database = tpch; user = root; password = 1024
            sqlcon += "server=" + textBox1.Text + ";";
            sqlcon += "port=" + textBox2.Text + ";";
            sqlcon += "database=" + textBox5.Text + ";";
            sqlcon += "user=" + textBox3.Text + ";";
            sqlcon += "password=" + textBox4.Text;
            this.Hide();
        }
        public string GetSQLCon()
        {
            return sqlcon;
        }
    }
}
