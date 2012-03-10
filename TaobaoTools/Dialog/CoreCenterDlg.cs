using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TaobaoTools.Dialog
{
    public partial class CoreCenterDlg : UserControl
    {
        public CoreCenterDlg()
        {
            InitializeComponent();
        }

        private void SwitchControl(Control control)
        {
            control.Size = splitContainer1.Panel2.ClientSize;
            control.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void OnOrderListClicked(object sender, EventArgs e)
        {
            SwitchControl(new TradeListDlg());
        }

        private void OnItemListClicked(object sender, EventArgs e)
        {
            SwitchControl(new ItemListDlg());
        }

        private void OnDataCollectionClicked(object sender, EventArgs e)
        {
            SwitchControl(new DataCollectionDlg());
        }
    }
}
