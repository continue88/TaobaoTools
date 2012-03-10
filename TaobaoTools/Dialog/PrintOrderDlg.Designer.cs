namespace TaobaoTools.Dialog
{
    partial class PrintOrderDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOrderDlg));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton3,
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.页面设置ToolStripMenuItem,
            this.打印预览ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(88, 21);
            this.toolStripSplitButton1.Text = "立即打印";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.页面设置ToolStripMenuItem.Text = "页面设置";
            this.页面设置ToolStripMenuItem.Click += new System.EventHandler(this.OnPrintPageSetupClicked);
            // 
            // 打印预览ToolStripMenuItem
            // 
            this.打印预览ToolStripMenuItem.Name = "打印预览ToolStripMenuItem";
            this.打印预览ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打印预览ToolStripMenuItem.Text = "打印预览";
            this.打印预览ToolStripMenuItem.Click += new System.EventHandler(this.OnPrintPreviewClicked);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.Image = global::TaobaoTools.Properties.Resources.Print;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(88, 21);
            this.toolStripSplitButton3.Text = "打印预览";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.OnPrintPreviewClicked);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = global::TaobaoTools.Properties.Resources.Save;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(64, 21);
            this.toolStripSplitButton2.Text = "保存";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.OnSaveClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(784, 300);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // PrintOrderDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 323);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PrintOrderDlg";
            this.Text = "PrintPreviewDlg";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览ToolStripMenuItem;

    }
}