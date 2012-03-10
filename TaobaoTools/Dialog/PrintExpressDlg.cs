using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaobaoTools.Data;
using Top.Api.Domain;
using System.Drawing.Printing;
using TaobaoTools.Properties;

namespace TaobaoTools.Dialog
{
    public partial class PrintExpressDlg : Form
    {
        int mPrintPageIndex = 0;

        public PrintExpressDlg(List<TradeInfo> indexTrades)
        {
            InitializeComponent();

            LoadTrades(indexTrades);
        }

        private void PrintExpressDlg_Load(object sender, EventArgs e)
        {
            if (BackgroundImage != null)
                ClientSize = BackgroundImage.Size;

            labelSenderName.Text = Settings.Default.SenderName;
            labelSenderCity.Text = Settings.Default.SenderCity;
            labelSenderAdress.Text = Settings.Default.SenderAdress;
            labelSenderMobile.Text = Settings.Default.SenderMobile;
            labelSenderZip.Text = Settings.Default.SenderZip;
        }

        void LoadTrades(List<TradeInfo> indexTrades)
        {
            listView1.Items.Clear();
            foreach (TradeInfo tradeInfo in indexTrades)
            {
                int index = listView1.Items.Count + 1 + Global.StartUpTradeIndex;
                ListViewItem lvItem = listView1.Items.Add(index.ToString());
                lvItem.Checked = true;
                lvItem.SubItems.Add(tradeInfo.MainTrade.ReceiverName);
                lvItem.SubItems.Add(tradeInfo.MainTrade.ReceiverAddress);
                lvItem.Tag = tradeInfo;
            }
        }

        void ShowTrade(TradeInfo tradeInfo, String info)
        {
            Trade trade = tradeInfo.MainTrade;
            labelReceiverAddress.Text = String.Format("{0}{1}{2}\n{3}",
                trade.ReceiverState,
                trade.ReceiverCity,
                trade.ReceiverDistrict,
                trade.ReceiverAddress);
            labelReceiverCity.Text = trade.ReceiverCity;
            labelReceiverName.Text = trade.ReceiverName;
            labelNo.Text = info;

            if (!String.IsNullOrEmpty(trade.ReceiverMobile))
                labelReceiverPhone.Text = trade.ReceiverMobile + "\n";
            if (!String.IsNullOrEmpty(trade.ReceiverPhone))
                labelReceiverPhone.Text += trade.ReceiverPhone;
            labelReceiverZip.Text = trade.ReceiverZip;
        }

        private void OnTradeSelected(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;

            ListViewItem lvItem = listView1.SelectedItems[0];
            TradeInfo tradeInfo = lvItem.Tag as TradeInfo;
            if (tradeInfo == null)
                return;

            ShowTrade(tradeInfo, lvItem.Text);
        }

        private void OnSelectAll(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in listView1.Items)
                lvItem.Checked = true;
        }

        private void OnSelectInverse(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in listView1.Items)
                lvItem.Checked = !lvItem.Checked;
        }

        private void OnSelectClear(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in listView1.Items)
                lvItem.Checked = false;
        }

        private void OnPrintStart(object sender, EventArgs e)
        {
            Print(false);
        }

        private void OnPrintPreviewClicked(object sender, EventArgs e)
        {
            Print(true);
        }

        void Print(bool preview)
        {
            // begin printing.
            mPrintPageIndex = 0;

            int tradeNum = 0;
            foreach (ListViewItem lvItem in listView1.Items)
            {
                if (!lvItem.Checked)
                    continue;

                if (tradeNum == 0)
                    mPrintPageIndex = listView1.Items.IndexOf(lvItem);
                tradeNum++;
            }

            if (tradeNum == 0)
            {
                MessageBox.Show("没有可以打印的订单");
                return;
            }

            if (MessageBox.Show(String.Format("总共打印{0}/{1}张快递单", tradeNum, listView1.Items.Count),
                "点击确定继续",
                MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(On_PrintPage);
            doc.DefaultPageSettings.PaperSize = new PaperSize("快递单", 905, 500);

            if (preview)
            {
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = doc;
                dlg.ShowDialog();
            }
            else
            {
                PrintDialog dlg = new PrintDialog();
                dlg.Document = doc;
                if (dlg.ShowDialog() == DialogResult.OK)
                    doc.Print();
            }
        }

        RectangleF ConvertRect(Rectangle labelBounds, Size expressSize, Rectangle pageBounds)
        {
            return new RectangleF(
                pageBounds.X + (float)labelBounds.X * pageBounds.Width / expressSize.Width,
                pageBounds.Y + (float)labelBounds.Y * pageBounds.Height / expressSize.Height,
                (float)labelBounds.Width * pageBounds.Width / expressSize.Width,
                (float)labelBounds.Height * pageBounds.Height / expressSize.Height);
        }

        void On_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (mPrintPageIndex >= listView1.Items.Count)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                ListViewItem lvItem = listView1.Items[mPrintPageIndex];
                ShowTrade(lvItem.Tag as TradeInfo, lvItem.Text);
            }
            
            Panel expressPanel = splitContainer1.Panel2;
            Image expressImage = expressPanel.BackgroundImage;
            Rectangle pageBounds = e.PageBounds;
            SolidBrush fontBrush = new SolidBrush(Color.Black);

            foreach (Control control in expressPanel.Controls)
            {
                Label label = control as Label;
                if (label == null)
                    continue;

                RectangleF rect = ConvertRect(
                    label.Bounds,
                    expressImage.Size,
                    pageBounds);

                rect.X += Settings.Default.ExpressOffsetX * Global.MM_2_INCH;
                rect.Y -= Settings.Default.ExpressOffsetY * Global.MM_2_INCH;

                e.Graphics.DrawString(
                    label.Text,
                    label.Font,
                    fontBrush,
                    rect);
            }

            // switch to the next.
            e.HasMorePages = false;
            for (mPrintPageIndex++; mPrintPageIndex < listView1.Items.Count; mPrintPageIndex++)
            {
                ListViewItem nextItem = listView1.Items[mPrintPageIndex];
                if (nextItem.Checked)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void OnExpressSettingClicked(object sender, EventArgs e)
        {
            DefaultSettings setting = new DefaultSettings();
            SettingsDlg dlg = new SettingsDlg("快递单设置", setting);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.Save();
            }
        }
    }
}
