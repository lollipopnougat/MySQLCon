using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MySQLCon
{
    public partial class Form1 : Form
    {
        //private static string connectStr;
        private MySqlConnection conn;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.ShowDialog();
            //connectStr = sstr;
            conn = new MySqlConnection(form2.GetSQLCon());
        }

        private static bool isConnected = false;
        
        //private static string connectStr1 = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        //private static string connectStr = "server=127.0.0.1;port=3306;database=数据库;user=root;password=你的密码";
        //private MySqlConnection conn = new MySqlConnection(connectStr);
        private void Button1_Click(object sender, EventArgs e)
        {
            if(isConnected) MessageBox.Show("数据库已经连接", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    //MessageBox.Show(connectStr+"\n"+connectStr1, "测试");
                    // 打开连接
                    conn.Open();
                    isConnected = true;
                    label1.Text = "数据库已连接";
                    label1.ForeColor = Color.Green;
                    textBox1.ReadOnly = false;
                    button3.BackColor = Color.PaleGreen;
                    textBox1.Text = "键入SQL语句";
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;

                    //button1.Enabled = false;
                    //button2.Enabled = true;
                    MessageBox.Show("已经建立连接", "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    textBox1.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show($"{er.ToString()}");
                }
            }
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 关闭连接
            if(!isConnected) MessageBox.Show("数据库没有连接", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Close();
                isConnected = false;
                textBox1.Text = "数据库已关闭";
                label1.Text = "数据库已关闭";
                label1.ForeColor = Color.OrangeRed;
                textBox1.ReadOnly = true;
                button3.BackColor = Color.Salmon;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                //button2.Enabled = false;
                //button1.Enabled = true;
                MessageBox.Show("数据库已关闭", "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!isConnected) MessageBox.Show("数据库尚未连接", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (textBox1.Text == "") throw new Exception("输入不能为空!");
                    //if (Regex.IsMatch(textBox1.Text,"create")) throw new Exception("您没有权限创建表！");
                    //if (Regex.IsMatch(textBox1.Text, "drop")) throw new Exception("您没有权限删除表！");
                    string sql = textBox1.Text;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if(radioButton1.Checked)
                    {
                        cmd.CommandType = CommandType.Text; //设置
                        DataTable dt = new DataTable();    
                        MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                        msda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label2.Text = "查询完毕";
                    }
                    else
                    {
                        int result = cmd.ExecuteNonQuery();
                        label2.Text = $"修改了 {result} 行数据";
                    }
                    
                }
                catch (Exception er)
                {
                    MessageBox.Show($"捕获到异常 {er.ToString()}" , "错误!!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }

        }

        private void 关于此程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abf = new AboutBox1();
            abf.ShowDialog();
            //MessageBox.Show($"{constr}");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
        }

        private void 联系作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ab2defg145@126.com?subject=反馈");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 修改数据库连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("请修改同目录下的config文件中的连接参数以修改数据库连接", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            form2.ShowDialog();
            conn = new MySqlConnection(form2.GetSQLCon());
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "select";
            button3.Text = "查询";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "update";
            button3.Text = "修改";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "insert";
            button3.Text = "插入";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "delete";
            button3.Text = "删除";
            if(radioButton4.Checked) MessageBox.Show("千万别忘了加where条件哟", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void ExportExcels(string fileName, DataGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;
            //saveDialog.ShowDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //点了取消
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能您的PC未安装Excel");
                    return;
                }
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
                                                                                                                                      //写入标题
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
                }
                //写入数值
                for (int r = 0; r < myDGV.Rows.Count; r++)
                {
                    for (int i = 0; i < myDGV.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }
                }
                xlApp.Quit();
                GC.Collect();//强行销毁
                MessageBox.Show("数据已保存到文件： " + fileName , "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("已取消保存文件", "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            
        }
        private void 导出当前结果到EXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("啊呀导出失败了!", "没有数据哟！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = "数据.xlsx";
                ExportExcels(name, dataGridView1);
            }
            
        }
    }
}
