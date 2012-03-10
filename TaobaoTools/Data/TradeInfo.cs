using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using Top.Api.Domain;

namespace TaobaoTools.Data
{
    public class TradeInfo
    {
        Trade mMainTrade;
        String mSellerMemo = "";
        String mBuyerMessage = "";
        List<Trade> mSubTrades = new List<Trade>();
        List<Order> mOrders = new List<Order>();

        public TradeInfo(Trade mainTrade)
        {
            mMainTrade = mainTrade;
            AddTradeInternal(mMainTrade);
        }

        public Trade MainTrade { get { return mMainTrade; } }
        public List<Order> Orders { get { return mOrders; } }
        public String SellerMemo { get { return mSellerMemo; } }
        public String BuyerMessage { get { return mBuyerMessage; } }

        public void AddSubTrade(Trade subTrade)
        {
            mSubTrades.Add(subTrade);

            AddTradeInternal(subTrade);
        }

        public bool IsSubTrade(Trade trade)
        {
            return mMainTrade.BuyerNick == trade.BuyerNick &&
                mMainTrade.ReceiverName == trade.ReceiverName &&
                mMainTrade.ReceiverState == trade.ReceiverState &&
                mMainTrade.ReceiverCity == trade.ReceiverCity &&
                mMainTrade.ReceiverDistrict == trade.ReceiverDistrict &&
                mMainTrade.ReceiverAddress == trade.ReceiverAddress &&
                mMainTrade.ReceiverZip == trade.ReceiverZip;
        }

        String GetBuyerMessage(Trade trade)
        {
            TradeData tradeData = Global.TradeDataContainer.GetItem(trade.Tid);
            if (tradeData != null && !String.IsNullOrEmpty(tradeData.BuyerMessage))
                return tradeData.BuyerMessage;

            return trade.BuyerMessage;
        }

        void AddTradeInternal(Trade trade)
        {
            if (!String.IsNullOrEmpty(trade.SellerMemo))
            {
                if (!String.IsNullOrEmpty(mSellerMemo))
                    mSellerMemo += ";";
                mSellerMemo += trade.SellerMemo;
            }

            String buyerMessage = GetBuyerMessage(trade);
            if (!String.IsNullOrEmpty(buyerMessage))
            {
                if (!String.IsNullOrEmpty(mBuyerMessage))
                    mBuyerMessage += ";";
                mBuyerMessage += buyerMessage;
            }

            mOrders.AddRange(trade.Orders);
        }
    }
}
