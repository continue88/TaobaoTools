using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace TaobaoTools.Data
{
    [Serializable]
    public class TradeData
    {
        long mID = 0;
        [XmlAttribute("ID")]
        public long ID { get { return mID; } set { mID = value; } }

        string mBuyerMessage = "";
        [XmlAttribute("BuyerMessage"), DefaultValue("")]
        public String BuyerMessage { get { return mBuyerMessage; } set { mBuyerMessage = value; } }
    }
}
