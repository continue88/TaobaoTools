namespace TaobaoTools.Dialog
{
    partial class TradeListDlg
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabelTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改物流方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.韵达快递默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.其它快递请备注ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印忽略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印忽略此订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消忽略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.修改买家留言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到订单详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.发货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自己联系物流ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.无需物流ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线下单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripStatusLabelTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = global::TaobaoTools.Properties.Resources.Print;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(100, 21);
            this.toolStripSplitButton1.Text = "打印出货单";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.OnPrintPreviewClicked);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = global::TaobaoTools.Properties.Resources.Print;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(100, 21);
            this.toolStripSplitButton2.Text = "打印快递单";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.OnExpressSettingClicked);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.Image = global::TaobaoTools.Properties.Resources.CenterAcross;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(103, 21);
            this.toolStripSplitButton3.Text = "起始单号{0}";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.OnSetStartIndexClicked);
            // 
            // toolStripStatusLabelTotal
            // 
            this.toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            this.toolStripStatusLabelTotal.Size = new System.Drawing.Size(166, 18);
            this.toolStripStatusLabelTotal.Text = "总共{0}待发货订单，{1}/{2}页";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(795, 272);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "买家姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "联系方式";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "收货地址";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "订单价格";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "买家留言";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "卖家备注";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "支付时间";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "创建时间";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "运送方式";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "订单打印";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改物流方式ToolStripMenuItem,
            this.打印忽略ToolStripMenuItem,
            this.toolStripSeparator2,
            this.修改买家留言ToolStripMenuItem,
            this.转到订单详情ToolStripMenuItem,
            this.toolStripSeparator3,
            this.发货ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 126);
            // 
            // 修改物流方式ToolStripMenuItem
            // 
            this.修改物流方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.韵达快递默认ToolStripMenuItem,
            this.toolStripSeparator1,
            this.其它快递请备注ToolStripMenuItem});
            this.修改物流方式ToolStripMenuItem.Name = "修改物流方式ToolStripMenuItem";
            this.修改物流方式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改物流方式ToolStripMenuItem.Text = "修改物流方式";
            // 
            // 韵达快递默认ToolStripMenuItem
            // 
            this.韵达快递默认ToolStripMenuItem.Name = "韵达快递默认ToolStripMenuItem";
            this.韵达快递默认ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.韵达快递默认ToolStripMenuItem.Text = "韵达快递(默认)";
            this.韵达快递默认ToolStripMenuItem.Click += new System.EventHandler(this.OnDeliverDefaultClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // 其它快递请备注ToolStripMenuItem
            // 
            this.其它快递请备注ToolStripMenuItem.Name = "其它快递请备注ToolStripMenuItem";
            this.其它快递请备注ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.其它快递请备注ToolStripMenuItem.Text = "其它方式(请备注)";
            this.其它快递请备注ToolStripMenuItem.Click += new System.EventHandler(this.OnDeliverCustomClicked);
            // 
            // 打印忽略ToolStripMenuItem
            // 
            this.打印忽略ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印忽略此订单ToolStripMenuItem,
            this.取消忽略ToolStripMenuItem});
            this.打印忽略ToolStripMenuItem.Name = "打印忽略ToolStripMenuItem";
            this.打印忽略ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打印忽略ToolStripMenuItem.Text = "订单打印";
            // 
            // 打印忽略此订单ToolStripMenuItem
            // 
            this.打印忽略此订单ToolStripMenuItem.Name = "打印忽略此订单ToolStripMenuItem";
            this.打印忽略此订单ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打印忽略此订单ToolStripMenuItem.Text = "已打印";
            this.打印忽略此订单ToolStripMenuItem.Click += new System.EventHandler(this.OnIgnoreClicked);
            // 
            // 取消忽略ToolStripMenuItem
            // 
            this.取消忽略ToolStripMenuItem.Name = "取消忽略ToolStripMenuItem";
            this.取消忽略ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.取消忽略ToolStripMenuItem.Text = "未打印";
            this.取消忽略ToolStripMenuItem.Click += new System.EventHandler(this.OnCancelIngoreCliecked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 修改买家留言ToolStripMenuItem
            // 
            this.修改买家留言ToolStripMenuItem.Name = "修改买家留言ToolStripMenuItem";
            this.修改买家留言ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改买家留言ToolStripMenuItem.Text = "修改买家留言";
            this.修改买家留言ToolStripMenuItem.Click += new System.EventHandler(this.OnChangeBuyerMessage);
            // 
            // 转到订单详情ToolStripMenuItem
            // 
            this.转到订单详情ToolStripMenuItem.Name = "转到订单详情ToolStripMenuItem";
            this.转到订单详情ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.转到订单详情ToolStripMenuItem.Text = "转到订单详情";
            this.转到订单详情ToolStripMenuItem.Click += new System.EventHandler(this.OnTradeDetailClicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // 发货ToolStripMenuItem
            // 
            this.发货ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自己联系物流ToolStripMenuItem,
            this.toolStripSeparator4,
            this.无需物流ToolStripMenuItem,
            this.在线下单ToolStripMenuItem});
            this.发货ToolStripMenuItem.Name = "发货ToolStripMenuItem";
            this.发货ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.发货ToolStripMenuItem.Text = "发货";
            this.发货ToolStripMenuItem.Click += new System.EventHandler(this.OnLogisticsSend);
            // 
            // 自己联系物流ToolStripMenuItem
            // 
            this.自己联系物流ToolStripMenuItem.Name = "自己联系物流ToolStripMenuItem";
            this.自己联系物流ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.自己联系物流ToolStripMenuItem.Text = "自己联系物流";
            this.自己联系物流ToolStripMenuItem.Click += new System.EventHandler(this.OnLogisticsSend);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // 无需物流ToolStripMenuItem
            // 
            this.无需物流ToolStripMenuItem.Name = "无需物流ToolStripMenuItem";
            this.无需物流ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.无需物流ToolStripMenuItem.Text = "无需物流";
            this.无需物流ToolStripMenuItem.Click += new System.EventHandler(this.OnDummySend);
            // 
            // 在线下单ToolStripMenuItem
            // 
            this.在线下单ToolStripMenuItem.Enabled = false;
            this.在线下单ToolStripMenuItem.Name = "在线下单ToolStripMenuItem";
            this.在线下单ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.在线下单ToolStripMenuItem.Text = "在线下单(不支持)";
            // 
            // TradeListDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "TradeListDlg";
            this.Size = new System.Drawing.Size(795, 295);
            this.Load += new System.EventHandler(this.OrderListDlg_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem 修改物流方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 韵达快递默认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 其它快递请备注ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印忽略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印忽略此订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消忽略ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 修改买家留言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到订单详情ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 发货ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自己联系物流ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 无需物流ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在线下单ToolStripMenuItem;
    }
}
