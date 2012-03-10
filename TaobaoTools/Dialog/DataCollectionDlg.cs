using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Top.Api.Domain;
using TaobaoTools.Data;

namespace TaobaoTools.Dialog
{
    public partial class DataCollectionDlg : UserControl
    {
        public DataCollectionDlg()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = Global.TradeGroupInfo;
            propertyGrid1.ExpandAllGridItems();

            dateTimePickerBegin.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Now;

            dateTimePicker1.Value = DateTime.Now;
        }
        
        private void OnTodayChecked(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void OnYestodayChecked(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today - new TimeSpan(1, 0, 0, 0);
            dateTimePickerEnd.Value = DateTime.Today - new TimeSpan(0, 0, 0, 1);
        }

        private void OnBeforeYestodayChecked(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today - new TimeSpan(2, 0, 0, 0);
            dateTimePickerEnd.Value = DateTime.Today - new TimeSpan(1, 0, 0, 1);
        }

        private void OnLastThreeDayChecked(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today - new TimeSpan(3, 0, 0, 0);
            dateTimePickerEnd.Value = DateTime.Today - new TimeSpan(0, 0, 0, 1);
        }

        private void OnLastWeekChecked(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today - new TimeSpan(7, 0, 0, 0);
            dateTimePickerEnd.Value = DateTime.Today - new TimeSpan(0, 0, 0, 1);
        }

        private void OnLastMonthChecked(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today - new TimeSpan(30, 0, 0, 0);
            dateTimePickerEnd.Value = DateTime.Today - new TimeSpan(0, 0, 0, 1);
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            Global.TradeGroupInfo.FillData(dateTimePickerBegin.Value, dateTimePickerEnd.Value);

            propertyGrid1.Refresh();
        }

        private void OnTodayDataClicked(object sender, EventArgs e)
        {
            int checkDayNum = (int)numericUpDown1.Value;

            DateTime select = dateTimePicker1.Value.Date;
            DateTime end = select + new TimeSpan(1, 0, 0, 0);
            DateTime begin = end - new TimeSpan(checkDayNum, 0, 0, 0);

            List<Trade> searchTrades = TopClientHelper.GetTradeList("WAIT_BUYER_CONFIRM_GOODS", begin, end, "consign_time");
            searchTrades.AddRange(TopClientHelper.GetTradeList("TRADE_FINISHED", begin, end, "consign_time"));

            List<Trade> todayTrades = new List<Trade>();
            foreach (Trade trade in searchTrades)
            {
                if (String.IsNullOrEmpty(trade.ConsignTime))
                    continue;

                DateTime consignTime = DateTime.Parse(trade.ConsignTime);
                if (consignTime > select && consignTime < end)
                    todayTrades.Add(trade);
            }

            TradeListInfo todayInfo = new TradeListInfo();
            todayInfo.FillData(todayTrades);

            propertyGrid2.SelectedObject = todayInfo;
        }
    }
}
