namespace MySQLCon
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改数据库连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出当前结果到EXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于此程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(869, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(567, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "连接数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(723, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "断开连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(715, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(508, 59);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "数据库未连接";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(246, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "数据库未连接";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改数据库连接ToolStripMenuItem,
            this.导出当前结果到EXCELToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "选项";
            // 
            // 修改数据库连接ToolStripMenuItem
            // 
            this.修改数据库连接ToolStripMenuItem.Image = global::MySQLCon.Properties.Resources.disconnected;
            this.修改数据库连接ToolStripMenuItem.Name = "修改数据库连接ToolStripMenuItem";
            this.修改数据库连接ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.修改数据库连接ToolStripMenuItem.Text = "修改数据库连接";
            this.修改数据库连接ToolStripMenuItem.Click += new System.EventHandler(this.修改数据库连接ToolStripMenuItem_Click);
            // 
            // 导出当前结果到EXCELToolStripMenuItem
            // 
            this.导出当前结果到EXCELToolStripMenuItem.Image = global::MySQLCon.Properties.Resources.excel;
            this.导出当前结果到EXCELToolStripMenuItem.Name = "导出当前结果到EXCELToolStripMenuItem";
            this.导出当前结果到EXCELToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.导出当前结果到EXCELToolStripMenuItem.Text = "导出当前结果到EXCEL";
            this.导出当前结果到EXCELToolStripMenuItem.Click += new System.EventHandler(this.导出当前结果到EXCELToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::MySQLCon.Properties.Resources.exit;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.联系作者ToolStripMenuItem,
            this.关于此程序ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 联系作者ToolStripMenuItem
            // 
            this.联系作者ToolStripMenuItem.Image = global::MySQLCon.Properties.Resources.email;
            this.联系作者ToolStripMenuItem.Name = "联系作者ToolStripMenuItem";
            this.联系作者ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.联系作者ToolStripMenuItem.Text = "联系作者";
            this.联系作者ToolStripMenuItem.Click += new System.EventHandler(this.联系作者ToolStripMenuItem_Click);
            // 
            // 关于此程序ToolStripMenuItem
            // 
            this.关于此程序ToolStripMenuItem.Image = global::MySQLCon.Properties.Resources.information;
            this.关于此程序ToolStripMenuItem.Name = "关于此程序ToolStripMenuItem";
            this.关于此程序ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关于此程序ToolStripMenuItem.Text = "关于此程序";
            this.关于此程序ToolStripMenuItem.Click += new System.EventHandler(this.关于此程序ToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(416, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "清除结果";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.83133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.16867F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 636);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(873, 45);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "状态";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.06065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.93935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 65);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel3.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButton3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButton4, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(517, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 59);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(15, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "查询";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(106, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "修改";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(15, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "插入";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.Location = new System.Drawing.Point(106, 34);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 22);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "删除";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(890, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(908, 733);
            this.MinimumSize = new System.Drawing.Size(908, 733);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL C#客户端";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改数据库连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于此程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系作者ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolStripMenuItem 导出当前结果到EXCELToolStripMenuItem;
    }
}

