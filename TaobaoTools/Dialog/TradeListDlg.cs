using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Top.Api.Domain;
using TaobaoTools.Data;
using System.Diagnostics;
using TaobaoTools.Properties;

namespace TaobaoTools.Dialog
{
    public partial class TradeListDlg : UserControl
    {
        List<Trade> mTradeList = null;
        List<TradeInfo> mNoIndexTrades = new List<TradeInfo>();
        List<TradeInfo> mIndexTrades = new List<TradeInfo>();

        public TradeListDlg()
        {
            InitializeComponent();
        }

        private void OrderListDlg_Load(object sender, EventArgs e)
        {
            GetTradeList();
        }

        
        class TradeCreatedCompare : Comparer<Trade>
        {
            public override int Compare(Trade x, Trade y)
            {
                return x.PayTime.CompareTo(y.PayTime);
            }
        }

        void GetTradeList()
        {
            float totalPayment = 0.0f;

            // request data.
            mTradeList = TopClientHelper.GetTradeList();
            mTradeList.Sort(new TradeCreatedCompare());

            UpdateTradeInfoList();

            // parse data.
            listView1.Items.Clear();
            foreach (Trade trade in mTradeList)
            {
                float payment;
                if (float.TryParse(trade.Payment, out payment))
                    totalPayment += payment;

                long tradeIdx = listView1.Items.Count + 1;
                ListViewItem lvItem = listView1.Items.Add(tradeIdx.ToString());
                lvItem.Tag = trade;

                UpdateTradeData(lvItem);
            }

            UpdateTradeInfoList();

            // show info.
            toolStripStatusLabelTotal.Text =
                String.Format("[{0}待发货，{1}+{2}待打印，总金额{3}元]",
                mTradeList.Count, 
                mIndexTrades.Count,
                mNoIndexTrades.Count,
                totalPayment);
        }

        void UpdateTradeInfoList()
        {
            mNoIndexTrades.Clear();
            mIndexTrades.Clear();

            foreach (Trade trade in mTradeList)
            {
                if (TopClientHelper.TradeIgnore(trade))
                    continue;

                if (TopClientHelper.TradeOtherDeliver(trade))
                    AddTrade(mNoIndexTrades, trade);
                else
                    AddTrade(mIndexTrades, trade);
            }
        }

        void AddTrade(List<TradeInfo> tradeInfos, Trade trade)
        {
            foreach (TradeInfo tradeInfo in tradeInfos)
            {
                if (tradeInfo.IsSubTrade(trade))
                {
                    tradeInfo.AddSubTrade(trade);
                    return;
                }
            }

            tradeInfos.Add(new TradeInfo(trade));
        }

        void UpdateTradeData(ListViewItem lvItem)
        {
            Trade trade = lvItem.Tag as Trade;
            if (trade == null)
                return;

            String deliverType = (trade.SellerFlag & (long)Global.FlagBits.FB_OtherDeliver) != 0 ?
                "其它" : "";
            String ignoreText = (trade.SellerFlag & (long)Global.FlagBits.FB_PrintIgnore) != 0 ?
                "已打印" : "";

            TradeData tradeData = Global.TradeDataContainer.GetItem(trade.Tid);
            String buyerMessage = (tradeData != null && !String.IsNullOrEmpty(tradeData.BuyerMessage)) ?
                tradeData.BuyerMessage : trade.BuyerMessage;
            String receiverAddress = trade.ReceiverAddress;
            if (!trade.ReceiverAddress.StartsWith(trade.ReceiverState))
                receiverAddress = trade.ReceiverState + trade.ReceiverCity + trade.ReceiverDistrict + trade.ReceiverAddress;

            String itemText = lvItem.Text;

            lvItem.SubItems.Clear();
            lvItem.SubItems.Add(trade.ReceiverName);
            lvItem.SubItems.Add(trade.ReceiverMobile + " " + trade.ReceiverPhone);
            lvItem.SubItems.Add(receiverAddress);
            lvItem.SubItems.Add(trade.Payment);
            lvItem.SubItems.Add(buyerMessage);
            lvItem.SubItems.Add(trade.SellerMemo);
            lvItem.SubItems.Add(trade.PayTime);
            lvItem.SubItems.Add(trade.Created);
            lvItem.SubItems.Add(deliverType);
            lvItem.SubItems.Add(ignoreText);

            lvItem.Text = itemText;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            contextMenuStrip1.Show(listView1, e.Location);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnChangeBuyerMessage(sender, e);
        }

        private void OnPrintPreviewClicked(object sender, EventArgs e)
        {
            PrintOrderDlg dlg = new PrintOrderDlg(mNoIndexTrades, mIndexTrades);
            dlg.ShowDialog();
        }

        private void OnExpressSettingClicked(object sender, EventArgs e)
        {
            PrintExpressDlg dlg = new PrintExpressDlg(mIndexTrades);
            dlg.ShowDialog();
        }

        private void OnDeliverDefaultClicked(object sender, EventArgs e)
        {
            bool changed = false;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                Trade trade = lvItem.Tag as Trade;
                if (trade == null)
                    continue;

                if (TopClientHelper.TradeOtherDeliver(trade))
                {
                    TopClientHelper.TradeOtherDeliver(trade, false);
                    UpdateTradeData(lvItem);

                    changed = true;
                }
            }

            if (changed)
                UpdateTradeInfoList();
        }
        
        private void OnDeliverCustomClicked(object sender, EventArgs e)
        {
            bool changed = false;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                Trade trade = lvItem.Tag as Trade;
                if (trade == null)
                    continue;

                if (!TopClientHelper.TradeOtherDeliver(trade))
                {
                    TopClientHelper.TradeOtherDeliver(trade, true);
                    UpdateTradeData(lvItem);

                    changed = true;
                }
            }

            if (changed)
                UpdateTradeInfoList();
        }

        private void OnCancelIngoreCliecked(object sender, EventArgs e)
        {
            bool changed = false;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                Trade trade = lvItem.Tag as Trade;
                if (trade == null)
                    continue;

                if (TopClientHelper.TradeIgnore(trade))
                {
                    TopClientHelper.TradeIgnore(trade, false);
                    UpdateTradeData(lvItem);
                    changed = true;
                }
            }

            if (changed)
                UpdateTradeInfoList();
        }

        private void OnIgnoreClicked(object sender, EventArgs e)
        {
            bool changed = false;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                Trade trade = lvItem.Tag as Trade;
                if (trade == null)
                    continue;

                if (!TopClientHelper.TradeIgnore(trade))
                {
                    TopClientHelper.TradeIgnore(trade, true);
                    UpdateTradeData(lvItem);
                    changed = true;
                }
            }

            if (changed)
                UpdateTradeInfoList();
        }

        private void OnSetStartIndexClicked(object sender, EventArgs e)
        {
            SettingsDlg.IntValue value = new SettingsDlg.IntValue(Global.StartUpTradeIndex);
            SettingsDlg dlg = new SettingsDlg("设置交易的起始编号", value);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Global.StartUpTradeIndex = value.Value;
                toolStripSplitButton3.Text = String.Format("起始编号{0}", Global.StartUpTradeIndex);
            }
        }

        private void OnChangeBuyerMessage(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("每次只能修改一个买家留言");
                return;
            }

            ListViewItem lvItem = listView1.SelectedItems[0];
            Trade trade = lvItem.Tag as Trade;
            if (trade == null)
                return;

            TradeDataInfo tradeDataInfo = new TradeDataInfo(trade);
            SettingsDlg dlg = new SettingsDlg("修改买家留言", tradeDataInfo);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (tradeDataInfo.ModifyAccept)
                {
                    TradeData tradeData = new TradeData();
                    tradeData.ID = tradeDataInfo.ID;
                    tradeData.BuyerMessage = tradeDataInfo.NewBuyerMessage;
                    Global.TradeDataContainer.AddOrUpdate(tradeData);

                    lvItem.SubItems[lvItem.SubItems.Count - 5].Text = tradeData.BuyerMessage;
                }
                else
                {
                    Global.TradeDataContainer.RemoveItem(tradeDataInfo.ID);
                    lvItem.SubItems[lvItem.SubItems.Count - 5].Text = trade.BuyerMessage;
                }

                UpdateTradeInfoList();
            }
        }

        private void OnTradeDetailClicked(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;

            ListViewItem lvItem = listView1.SelectedItems[0];
            Trade trade = lvItem.Tag as Trade;
            if (trade == null)
                return;

            Process.Start(
                String.Format("http://trade.taobao.com/trade/detail/trade_item_detail.htm?bizOrderId={0}", trade.Tid));
        }

        String GetNextOutSid(String outSid)
        {
            char[] numberStr = outSid.ToCharArray();
            for (int i = outSid.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(outSid[i]))
                    break;

                if (outSid[i] < '9')
                {
                    numberStr[i]++;
                    break;
                }
                
                numberStr[i] = '0';
            }
            return new String(numberStr);
        }

        private void OnLogisticsSend(object sender, EventArgs e)
        {
            bool needReloadTradeList = false;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                Trade trade = lvItem.Tag as Trade;
                if (trade == null)
                    continue;

                LogisticsSendInfo info = new LogisticsSendInfo(trade);
                if (!String.IsNullOrEmpty(Settings.Default.LastCompany))
                    info.Company = Settings.Default.LastCompany;
                if (!String.IsNullOrEmpty(Settings.Default.LastOutSid))
                    info.OutSid = GetNextOutSid(Settings.Default.LastOutSid);

                SettingsDlg dlg = new SettingsDlg("填写发货信息", info);
                if (dlg.ShowDialog() != DialogResult.OK || String.IsNullOrEmpty(info.OutSid))
                    continue;

                String companyCode = "其他";
                List<LogisticsCompany> cogisticsCompanies = TopClientHelper.GetLogisticsCompanies();
                foreach (LogisticsCompany companey in cogisticsCompanies)
                {
                    if (companey.Name == info.Company)
                    {
                        companyCode = companey.Code;
                        break;
                    }
                }

                if (TopClientHelper.LogisticsOfflineSend(trade.Tid, info.OutSid, companyCode))
                {
                    // save the sucessed company and sid.
                    Settings.Default.LastCompany = info.Company;
                    Settings.Default.LastOutSid = info.OutSid;

                    MessageBox.Show("恭喜，发货成功！");
                    needReloadTradeList = true;
                }
                else
                    break;
            }

            if (needReloadTradeList)
                GetTradeList();
        }

        private void OnDummySend(object sender, EventArgs e)
        {
            
            bool needReloadTradeList = false;
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                Trade trade = lvItem.Tag as Trade;
                if (trade == null)
                    continue;
                
                string receiverAddress = "";
                if (trade.ReceiverAddress.StartsWith(trade.ReceiverState))
                    receiverAddress = trade.ReceiverAddress;
                else
                    receiverAddress = trade.ReceiverState + trade.ReceiverCity + trade.ReceiverDistrict + trade.ReceiverAddress;

                String info = String.Format("交易ID：{0}\n收货人：{1}\n收货地址：{2}",
                    trade.Tid,
                    trade.ReceiverName,
                    receiverAddress);

                if (MessageBox.Show(info, "确定按[无需物流]形式发货？", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    break;

                if (TopClientHelper.LogisticsDummySend(trade.Tid))
                {
                    MessageBox.Show("恭喜，发货成功！");
                    needReloadTradeList = true;
                }
                else
                    break;
            }

            if (needReloadTradeList)
                GetTradeList();
        }
    }
}
