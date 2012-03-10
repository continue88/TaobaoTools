namespace TaobaoTools.Dialog
{
    partial class PrintExpressDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.打印预览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.全部选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反向选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelReceiverCity = new System.Windows.Forms.Label();
            this.labelReceiverZip = new System.Windows.Forms.Label();
            this.labelReceiverName = new System.Windows.Forms.Label();
            this.labelReceiverAddress = new System.Windows.Forms.Label();
            this.labelReceiverPhone = new System.Windows.Forms.Label();
            this.labelSenderZip = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelSenderAdress = new System.Windows.Forms.Label();
            this.labelSenderMobile = new System.Windows.Forms.Label();
            this.labelSenderName = new System.Windows.Forms.Label();
            this.labelSenderCity = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1044, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印预览ToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::TaobaoTools.Properties.Resources.Print;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(88, 21);
            this.toolStripSplitButton1.Text = "开始打印";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.OnPrintStart);
            // 
            // 打印预览ToolStripMenuItem
            // 
            this.打印预览ToolStripMenuItem.Name = "打印预览ToolStripMenuItem";
            this.打印预览ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打印预览ToolStripMenuItem.Text = "打印预览";
            this.打印预览ToolStripMenuItem.Click += new System.EventHandler(this.OnPrintPreviewClicked);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = global::TaobaoTools.Properties.Resources.Properties;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(88, 21);
            this.toolStripSplitButton2.Text = "打印设置";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.OnExpressSettingClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::TaobaoTools.Properties.Resources.Express;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.labelReceiverCity);
            this.splitContainer1.Panel2.Controls.Add(this.labelReceiverZip);
            this.splitContainer1.Panel2.Controls.Add(this.labelReceiverName);
            this.splitContainer1.Panel2.Controls.Add(this.labelReceiverAddress);
            this.splitContainer1.Panel2.Controls.Add(this.labelReceiverPhone);
            this.splitContainer1.Panel2.Controls.Add(this.labelSenderZip);
            this.splitContainer1.Panel2.Controls.Add(this.labelNo);
            this.splitContainer1.Panel2.Controls.Add(this.labelSenderAdress);
            this.splitContainer1.Panel2.Controls.Add(this.labelSenderMobile);
            this.splitContainer1.Panel2.Controls.Add(this.labelSenderName);
            this.splitContainer1.Panel2.Controls.Add(this.labelSenderCity);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 480);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(178, 453);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.OnTradeSelected);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "收件人";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "地址";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "备注";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(178, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部选择ToolStripMenuItem,
            this.反向选择ToolStripMenuItem,
            this.清除选择ToolStripMenuItem});
            this.toolStripSplitButton3.Image = global::TaobaoTools.Properties.Resources.Checkbox;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(64, 22);
            this.toolStripSplitButton3.Text = "选择";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.OnSelectAll);
            // 
            // 全部选择ToolStripMenuItem
            // 
            this.全部选择ToolStripMenuItem.Name = "全部选择ToolStripMenuItem";
            this.全部选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部选择ToolStripMenuItem.Text = "全部选择";
            this.全部选择ToolStripMenuItem.Click += new System.EventHandler(this.OnSelectAll);
            // 
            // 反向选择ToolStripMenuItem
            // 
            this.反向选择ToolStripMenuItem.Name = "反向选择ToolStripMenuItem";
            this.反向选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.反向选择ToolStripMenuItem.Text = "反向选择";
            this.反向选择ToolStripMenuItem.Click += new System.EventHandler(this.OnSelectInverse);
            // 
            // 清除选择ToolStripMenuItem
            // 
            this.清除选择ToolStripMenuItem.Name = "清除选择ToolStripMenuItem";
            this.清除选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清除选择ToolStripMenuItem.Text = "清除选择";
            this.清除选择ToolStripMenuItem.Click += new System.EventHandler(this.OnSelectClear);
            // 
            // labelReceiverCity
            // 
            this.labelReceiverCity.BackColor = System.Drawing.Color.Transparent;
            this.labelReceiverCity.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.labelReceiverCity.Location = new System.Drawing.Point(446, 89);
            this.labelReceiverCity.Name = "labelReceiverCity";
            this.labelReceiverCity.Size = new System.Drawing.Size(191, 38);
            this.labelReceiverCity.TabIndex = 1;
            this.labelReceiverCity.Text = "收件人城市";
            // 
            // labelReceiverZip
            // 
            this.labelReceiverZip.BackColor = System.Drawing.Color.Transparent;
            this.labelReceiverZip.Font = new System.Drawing.Font("宋体", 14F);
            this.labelReceiverZip.Location = new System.Drawing.Point(631, 219);
            this.labelReceiverZip.Name = "labelReceiverZip";
            this.labelReceiverZip.Size = new System.Drawing.Size(140, 34);
            this.labelReceiverZip.TabIndex = 1;
            this.labelReceiverZip.Text = "{收件人邮编}";
            // 
            // labelReceiverName
            // 
            this.labelReceiverName.BackColor = System.Drawing.Color.Transparent;
            this.labelReceiverName.Font = new System.Drawing.Font("宋体", 14F);
            this.labelReceiverName.Location = new System.Drawing.Point(450, 219);
            this.labelReceiverName.Name = "labelReceiverName";
            this.labelReceiverName.Size = new System.Drawing.Size(139, 34);
            this.labelReceiverName.TabIndex = 1;
            this.labelReceiverName.Text = "{收件人姓名}";
            // 
            // labelReceiverAddress
            // 
            this.labelReceiverAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelReceiverAddress.Font = new System.Drawing.Font("宋体", 14F);
            this.labelReceiverAddress.Location = new System.Drawing.Point(446, 134);
            this.labelReceiverAddress.Name = "labelReceiverAddress";
            this.labelReceiverAddress.Size = new System.Drawing.Size(281, 69);
            this.labelReceiverAddress.TabIndex = 1;
            this.labelReceiverAddress.Text = "{收件人地址}";
            // 
            // labelReceiverPhone
            // 
            this.labelReceiverPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelReceiverPhone.Font = new System.Drawing.Font("宋体", 14F);
            this.labelReceiverPhone.Location = new System.Drawing.Point(628, 89);
            this.labelReceiverPhone.Name = "labelReceiverPhone";
            this.labelReceiverPhone.Size = new System.Drawing.Size(154, 76);
            this.labelReceiverPhone.TabIndex = 1;
            this.labelReceiverPhone.Text = "{收件人电话}";
            // 
            // labelSenderZip
            // 
            this.labelSenderZip.BackColor = System.Drawing.Color.Transparent;
            this.labelSenderZip.Font = new System.Drawing.Font("宋体", 14F);
            this.labelSenderZip.Location = new System.Drawing.Point(293, 219);
            this.labelSenderZip.Name = "labelSenderZip";
            this.labelSenderZip.Size = new System.Drawing.Size(122, 34);
            this.labelSenderZip.TabIndex = 0;
            this.labelSenderZip.Text = "发货人邮编";
            // 
            // labelNo
            // 
            this.labelNo.BackColor = System.Drawing.Color.Transparent;
            this.labelNo.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNo.Location = new System.Drawing.Point(137, 115);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(189, 50);
            this.labelNo.TabIndex = 0;
            this.labelNo.Text = "编号";
            // 
            // labelSenderAdress
            // 
            this.labelSenderAdress.BackColor = System.Drawing.Color.Transparent;
            this.labelSenderAdress.Font = new System.Drawing.Font("宋体", 14F);
            this.labelSenderAdress.Location = new System.Drawing.Point(123, 165);
            this.labelSenderAdress.Name = "labelSenderAdress";
            this.labelSenderAdress.Size = new System.Drawing.Size(252, 38);
            this.labelSenderAdress.TabIndex = 0;
            this.labelSenderAdress.Text = "发货人地址";
            // 
            // labelSenderMobile
            // 
            this.labelSenderMobile.BackColor = System.Drawing.Color.Transparent;
            this.labelSenderMobile.Font = new System.Drawing.Font("宋体", 14F);
            this.labelSenderMobile.Location = new System.Drawing.Point(137, 219);
            this.labelSenderMobile.Name = "labelSenderMobile";
            this.labelSenderMobile.Size = new System.Drawing.Size(122, 34);
            this.labelSenderMobile.TabIndex = 0;
            this.labelSenderMobile.Text = "发货人电话";
            // 
            // labelSenderName
            // 
            this.labelSenderName.BackColor = System.Drawing.Color.Transparent;
            this.labelSenderName.Font = new System.Drawing.Font("宋体", 14F);
            this.labelSenderName.Location = new System.Drawing.Point(123, 89);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(119, 26);
            this.labelSenderName.TabIndex = 0;
            this.labelSenderName.Text = "发货人姓名";
            // 
            // labelSenderCity
            // 
            this.labelSenderCity.BackColor = System.Drawing.Color.Transparent;
            this.labelSenderCity.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.labelSenderCity.Location = new System.Drawing.Point(263, 89);
            this.labelSenderCity.Name = "labelSenderCity";
            this.labelSenderCity.Size = new System.Drawing.Size(152, 38);
            this.labelSenderCity.TabIndex = 0;
            this.labelSenderCity.Text = "发货人城市";
            // 
            // PrintExpressDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1044, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PrintExpressDlg";
            this.Text = "PrintExpressDlg";
            this.Load += new System.EventHandler(this.PrintExpressDlg_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.Label labelSenderZip;
        private System.Windows.Forms.Label labelSenderAdress;
        private System.Windows.Forms.Label labelSenderMobile;
        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.Label labelSenderCity;
        private System.Windows.Forms.Label labelReceiverCity;
        private System.Windows.Forms.Label labelReceiverZip;
        private System.Windows.Forms.Label labelReceiverName;
        private System.Windows.Forms.Label labelReceiverAddress;
        private System.Windows.Forms.Label labelReceiverPhone;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem 全部选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反向选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览ToolStripMenuItem;
    }
}