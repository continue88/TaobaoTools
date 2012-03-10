using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Top.Api.Domain;

namespace TaobaoTools.Data
{
    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public class TradeListInfo
    {
        int mCount = 0;
        [DefaultValue(0), DisplayName("交易笔数")]
        public int Count { get { return mCount; } }

        float mPayment = 0.0f;
        [DefaultValue(0.0f), DisplayName("交易金额")]
        public float Payment { get { return mPayment; } }

        int mBuyerNum = 0;
        [DefaultValue(0), DisplayName("交易人数")]
        public int BuyerNum { get { return mBuyerNum; } }

        public override string ToString() { return String.Empty; }

        public void Reset()
        {
            mCount = 0;
            mPayment = 0.0f;
            mBuyerNum = 0;
        }

        public void Include(TradeListInfo info)
        {
            mCount += info.Count;
            mPayment += info.Payment;
            mBuyerNum += info.BuyerNum;
        }

        public void FillData(List<Trade> trades)
        {
            Reset();

            List<String> buyerList = new List<string>();
            foreach (Trade trade in trades)
            {
                float amout = 0.0f;
                if (float.TryParse(trade.Payment, out amout))
                    mPayment += amout;

                if (!buyerList.Contains(trade.BuyerNick))
                    buyerList.Add(trade.BuyerNick);
            }

            mCount += trades.Count;
            mBuyerNum += buyerList.Count;
        }
    }
}
