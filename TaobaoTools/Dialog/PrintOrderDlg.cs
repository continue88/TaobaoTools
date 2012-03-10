using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Top.Api.Domain;
using TaobaoTools.Data;
using TaobaoTools.Properties;

namespace TaobaoTools.Dialog
{
    public partial class PrintOrderDlg : Form
    {
        const string PAGE_LINE_TAG = "#PAGE_LINE_TAG";
        public PrintOrderDlg(List<TradeInfo> noIndexTrades, List<TradeInfo> indexTrades)
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            BuildHtml(sb, noIndexTrades, indexTrades);

            webBrowser1.DocumentText = sb.ToString();
        }

        void BuildHtml(StringBuilder sb, List<TradeInfo> noIndexTrades, List<TradeInfo> indexTrades)
        {
            sb.AppendLine("<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.0 Transitional//EN'>");
            sb.AppendLine("<html xmlns:v='http://www.taobao.com/'>");
            sb.AppendFormat("<style type='text/css'><--body{{FONT-SIZE:{0}pt}} td{{FONT-SIZE:{1}pt}}--></style>\n", Settings.Default.OrderFontSize, Settings.Default.OrderFontSize);
            sb.AppendLine("<head><style type='text/css'>v\\:* {behavior:url(#default#VML);}</style> </head><body>");
            sb.Append(PAGE_LINE_TAG);
            sb.AppendFormat("<center style='font-size:25px;'><strong>{0}日 {1}+{2}个快递</strong></center>\n",
                DateTime.Now.ToShortDateString(),
                Global.StartUpTradeIndex + indexTrades.Count,
                noIndexTrades.Count);

            foreach (TradeInfo trade in noIndexTrades)
                ToHtml(0, trade, sb);

            int tradeIndex = 1;
            foreach (TradeInfo trade in indexTrades)
                ToHtml(Global.StartUpTradeIndex + tradeIndex++, trade, sb);

            sb.AppendLine("</body></html>");
        }

        void ToHtml(int index, TradeInfo trade, StringBuilder sb)
        {
            sb.AppendLine("<table width='550px' align='center'>");
            sb.AppendLine("<tr><textarea style='border:0;OVERFLOW:visible;'></textarea></tr>");
            sb.AppendLine("<tr>");
            if (index > 0)
                sb.AppendFormat("<td width='6%' style='font-size:30px'><strong>{0}</strong></td>\n", index);
            sb.AppendFormat("<td>{0},{1},{2},{3} {4} {5} {6},{7}</td>\n", 
                trade.MainTrade.ReceiverName,
                trade.MainTrade.ReceiverMobile,
                trade.MainTrade.ReceiverPhone,
                trade.MainTrade.ReceiverState,
                trade.MainTrade.ReceiverCity,
                trade.MainTrade.ReceiverDistrict,
                trade.MainTrade.ReceiverAddress,
                trade.MainTrade.ReceiverZip);
            sb.AppendLine("</tr>");
            sb.AppendLine("</table>");

            sb.AppendLine("<table width='550px' align='center' border='1px' bordercolor='#000000' cellspacing='0px' style='border-collapse:collapse'>");
            int orderIndex = 1;
            foreach (Order order in trade.Orders)
            {
                if (order.Status != "WAIT_SELLER_SEND_GOODS")
                    continue;

                ItemData itemData = Global.ItemDataContainer.GetItem(order.NumIid);
                String orderTitle = itemData != null ? itemData.UserName : order.Title;
                if (!String.IsNullOrEmpty(order.SkuPropertiesName))
                {
                    String key = "买的多，便宜多（请填写*n件的总价）";
                    orderTitle += "[" + order.SkuPropertiesName.Replace(key, "件数") + "]";
                }

                sb.AppendLine("<tr>");
                sb.AppendFormat("<td width='16%'>({0})</td>\n", orderIndex++);
                sb.AppendFormat("<td width='65%'>{0}</td>\n", orderTitle);
                sb.AppendFormat("<td width='10%'><strong>{0}</strong></td>\n", order.Num);
                sb.AppendFormat("<td>{0}</td>\n", itemData != null ? itemData.ItemType : "");
                sb.AppendLine("</tr>");
            }
            if (!String.IsNullOrEmpty(trade.SellerMemo))
                sb.AppendFormat("<tr><td>卖家备注</td><td><strong>{0}</strong></td><td></td><td></td></tr>\n", trade.SellerMemo);
            if (!String.IsNullOrEmpty(trade.BuyerMessage))
                sb.AppendFormat("<tr><td>买家留言</td><td><strong>{0}</strong></td><td></td><td></td></tr>\n", trade.BuyerMessage);
            sb.AppendLine("</table>");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void OnPrintPreviewClicked(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }
        
        private void OnPrintPageSetupClicked(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentText.IndexOf(PAGE_LINE_TAG) < 0)
                return;

            String pageLinesHtml = "";

            int totalHeight = webBrowser1.Document.Body.ScrollRectangle.Height;
            int pageHeight = Settings.Default.OrderPageSize.Height;
            for (int i = 1; i * pageHeight < totalHeight; i++)
                pageLinesHtml += String.Format("<v:line style='position:absolute' from='0,{0}' to='100,{0}' ></v:line>\n", i * pageHeight);

            webBrowser1.DocumentText = webBrowser1.DocumentText.Replace(PAGE_LINE_TAG, pageLinesHtml);
        }
    }
}
