using System;
using System.Collections.Generic;
using System.Text;
using Top.Api.Domain;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using TaobaoTools.Data;
using System.Windows.Forms;

namespace TaobaoTools
{
    class Global
    {
        public const String URL = "http://gw.api.taobao.com/router/rest";
        public const String ITEM_URL = "http://item.taobao.com/item.htm";
        public const String APP_KEY = "12520793";
        public const String APP_SECRET = "55550b25aa51ea2424944086f13e1be6";
        public const String RESPONSE_FORMAT = "json";   // "xml"
        public const String ITEM_FILE = "ItemData.xml";
        public const String TRADE_FILE = "TradeData.xml";
        public const float MM_2_INCH = 3.93700787f;     // 1 millimeters = 3.93700787f 100 inches
        public const float INCH_2_MM = 0.254f;          // 100 inches = 0.254 millimeters

        [Flags]
        public enum FlagBits
        {
            FB_OtherDeliver = 1,
            FB_PrintIgnore = 2,
            FB_Reserved = 4,
        }

        static MainForm mMainForm = null;
        public static MainForm MainForm { get { return mMainForm; } set { mMainForm = value; } }

        static String mSesssionKey = "";
        public static String SessionKey { get { return mSesssionKey; } set { mSesssionKey = value; } }

        static ItemDataContainer mItemDataContainer = new ItemDataContainer();
        public static ItemDataContainer ItemDataContainer { get { return mItemDataContainer; } }

        static TradeDataContainer mTradeDataContainer = new TradeDataContainer();
        public static TradeDataContainer TradeDataContainer { get { return mTradeDataContainer; } }

        static TradeGroupInfo mTradeGroupInfo = new TradeGroupInfo();
        public static TradeGroupInfo TradeGroupInfo { get { return mTradeGroupInfo; } }

        static int mStartUpTradeIndex = 0;
        public static int StartUpTradeIndex { get { return mStartUpTradeIndex; } set { mStartUpTradeIndex = value; } }

        public static ITopClient DefulatClient() { return new DefaultTopClient(URL, APP_KEY, APP_SECRET, RESPONSE_FORMAT); }

        static List<LogisticsCompany> mLogisticsCompanys = new List<LogisticsCompany>();
        public static List<LogisticsCompany> LogisticsCompanys { get { return mLogisticsCompanys; } }
    }
}
