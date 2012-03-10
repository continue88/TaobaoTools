using System;
using System.Collections.Generic;
using System.Text;
using Top.Api.Domain;
using System.ComponentModel;

namespace TaobaoTools.Data
{
    class TradeDataInfo
    {
        public TradeDataInfo(Trade trade)
        {
            mID = trade.Tid;
            mOldBuyerMessage = trade.BuyerMessage;
            mNewBuyerMessage = trade.BuyerMessage;

            TradeData tradeData = Global.TradeDataContainer.GetItem(mID);
            if (tradeData != null)
                mNewBuyerMessage = tradeData.BuyerMessage;
        }

        long mID = 0;
        [DisplayName("交易编号")]
        public long ID { get { return mID; } }

        string mOldBuyerMessage = "";
        [DisplayName("原买家留言")]
        public string OldBuyerMessage { get { return mOldBuyerMessage; } }

        string mNewBuyerMessage = "";
        [DisplayName("新买家留言")]
        public string NewBuyerMessage { get { return mNewBuyerMessage; } set { mNewBuyerMessage = value; } }

        [Browsable(false)]
        public bool ModifyAccept { get { return !String.IsNullOrEmpty(mNewBuyerMessage) && mNewBuyerMessage != OldBuyerMessage; } }
    }
}
