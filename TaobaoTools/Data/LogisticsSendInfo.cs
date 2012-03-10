using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Top.Api.Domain;

namespace TaobaoTools.Data
{
    class LogisticsSendInfo
    {
        public LogisticsSendInfo(Trade trade)
        {
            mID = trade.Tid;
            mReceiverName = trade.ReceiverName;

            if (trade.ReceiverAddress.StartsWith(trade.ReceiverState))
                mReceiverAddress = trade.ReceiverAddress;
            else
                mReceiverAddress = trade.ReceiverState + trade.ReceiverCity + trade.ReceiverDistrict + trade.ReceiverAddress;
        }

        long mID = 0;
        [DisplayName("交易ID"), Category("交易信息")]
        public long ID { get { return mID; } }

        string mReceiverName = "";
        [DisplayName("收货人"), Category("交易信息")]
        public string ReceiverName { get { return mReceiverName; } }

        string mReceiverAddress = "";
        [DisplayName("收货地址"), Category("交易信息")]
        public string ReceiverAddress { get { return mReceiverAddress; } }

        string mOutSid = "";
        [DisplayName("运单号"), Category("发货信息"), Description("具体一个物流公司的真实运单号码。淘宝官方物流会校验，请谨慎传入!")]
        public string OutSid { get { return mOutSid; } set { mOutSid = value; } }

        string mCompany = "韵达快运";
        [DisplayName("物流公司"), Category("发货信息"), DefaultValue("韵达快运"), Description("非淘宝官方物流合作公司，填写“其他”"), TypeConverter(typeof(LogisticsCopanyConverter))]
        public string Company { get { return mCompany; } set { mCompany = value; } }
    }
}
