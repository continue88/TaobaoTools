using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Top.Api.Domain;

namespace TaobaoTools.Data
{
    public class TradeGroupInfo
    {
        TradeListInfo mWAIT_BUYER_PAY = new TradeListInfo();
        [DisplayName("等待买家付款")]
        public TradeListInfo WAIT_BUYER_PAY { get { return mWAIT_BUYER_PAY; } }

        TradeListInfo mWAIT_SELLER_SEND_GOODS = new TradeListInfo();
        [DisplayName("等待卖家发货")]
        public TradeListInfo WAIT_SELLER_SEND_GOODS { get { return mWAIT_SELLER_SEND_GOODS; } }

        TradeListInfo mWAIT_BUYER_CONFIRM_GOODS = new TradeListInfo();
        [DisplayName("卖家已发货")]
        public TradeListInfo WAIT_BUYER_CONFIRM_GOODS { get { return mWAIT_BUYER_CONFIRM_GOODS; } }

        TradeListInfo mTRADE_FINISHED = new TradeListInfo();
        [DisplayName("交易成功")]
        public TradeListInfo TRADE_FINISHED { get { return mTRADE_FINISHED; } }

        TradeListInfo mAllSucced = new TradeListInfo();
        [DisplayName("达成的交易")]
        public TradeListInfo AllSucced { get { return mAllSucced; } }

        public void FillData(DateTime begin, DateTime end)
        {
            /// * TRADE_NO_CREATE_PAY(没有创建支付宝交易)      
            /// * WAIT_BUYER_PAY(等待买家付款)      
            /// * WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)      
            /// * WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)      
            /// * TRADE_BUYER_SIGNED(买家已签收,货到付款专用)      
            /// * TRADE_FINISHED(交易成功)      
            /// * TRADE_CLOSED(付款以后用户退款成功，交易自动关闭)      
            /// * TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易)

            WAIT_BUYER_PAY.FillData(TopClientHelper.GetTradeList("WAIT_BUYER_PAY", begin, end));
            WAIT_SELLER_SEND_GOODS.FillData(TopClientHelper.GetTradeList("WAIT_SELLER_SEND_GOODS", begin, end));
            WAIT_BUYER_CONFIRM_GOODS.FillData(TopClientHelper.GetTradeList("WAIT_BUYER_CONFIRM_GOODS", begin, end));
            TRADE_FINISHED.FillData(TopClientHelper.GetTradeList("TRADE_FINISHED", begin, end));

            AllSucced.Reset();
            AllSucced.Include(WAIT_SELLER_SEND_GOODS);
            AllSucced.Include(WAIT_BUYER_CONFIRM_GOODS);
            AllSucced.Include(TRADE_FINISHED);
        }
    }
}
