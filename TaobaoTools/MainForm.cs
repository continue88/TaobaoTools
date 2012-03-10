using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using TaobaoTools.Dialog;
using TaobaoTools.Properties;

namespace TaobaoTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Global.MainForm = this;
            
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            SwitchPanel(new LoginDlg());

            Global.ItemDataContainer.Load(
                Application.StartupPath + "\\" + Global.ITEM_FILE);
            Global.TradeDataContainer.Load(
                Application.StartupPath + "\\" + Global.TRADE_FILE);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.ItemDataContainer.Save(
                Application.StartupPath + "\\" + Global.ITEM_FILE);
            Global.TradeDataContainer.Save(
                Application.StartupPath + "\\" + Global.TRADE_FILE);

            Settings.Default.Save();
        }

        private void SwitchPanel(Control control)
        {
            control.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(control);
        }

        public void OnLogginSucess()
        {
            SwitchPanel(new CoreCenterDlg());
        }
    }
}
