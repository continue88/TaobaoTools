using System;
using System.Collections.Generic;
using System.Text;
using Top.Api;
using Top.Api.Request;
using Top.Api.Domain;
using Top.Api.Response;
using System.Windows.Forms;

namespace TaobaoTools
{
    public class TopClientHelper
    {
        public static bool UpdatePostage(long tid, float postage)
        {
            ITopClient client = Global.DefulatClient();
            TradePostageUpdateRequest req = new TradePostageUpdateRequest();
            req.Tid = tid;
            req.PostFee = postage.ToString();
            TradePostageUpdateResponse response = client.Execute(req, Global.SessionKey);
            if (response.Trade == null || String.IsNullOrEmpty(response.Trade.PostFee))
                return false;

            float retFee = 0.0f;
            float.TryParse(response.Trade.PostFee, out retFee);
            return postage == retFee; 
        }

        public static bool LogisticsDummySend(long tid)
        {
            try
            {
                ITopClient client = Global.DefulatClient();
                LogisticsDummySendRequest req = new LogisticsDummySendRequest();
                req.Tid = tid;

                LogisticsDummySendResponse response = client.Execute(req, Global.SessionKey);
                if (response.IsError)
                    MessageBox.Show(response.SubErrMsg, "对不起，发货失败！");
                return response.Shipping != null ? response.Shipping.IsSuccess : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "对不起，发货失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool LogisticsOfflineSend(long tid, String outSid, String companyCode)
        {
            try
            {
                ITopClient client = Global.DefulatClient();
                LogisticsOfflineSendRequest req = new LogisticsOfflineSendRequest();
                req.Tid = tid;
                req.OutSid = outSid;
                req.CompanyCode = companyCode;
                LogisticsOfflineSendResponse response = client.Execute(req, Global.SessionKey);

                if (response.IsError)
                    MessageBox.Show(response.SubErrMsg, "发货失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response.Shipping != null ? response.Shipping.IsSuccess : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "对不起，发货失败！");
                return false;
            }
        }

        public static List<LogisticsCompany> GetLogisticsCompanies()
        {
            try
            {
                if (Global.LogisticsCompanys.Count == 0)
                {
                    ITopClient client = Global.DefulatClient();

                    LogisticsCompaniesGetRequest req = new LogisticsCompaniesGetRequest();
                    req.Fields = "id,code,name,reg_mail_no";
                    req.IsRecommended = true;
                    req.OrderMode = "offline";

                    LogisticsCompaniesGetResponse response = client.Execute(req, Global.SessionKey);
                    if (response.LogisticsCompanies != null)
                        Global.LogisticsCompanys.AddRange(response.LogisticsCompanies);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Global.LogisticsCompanys;
        }

        public static List<Item> GetProductList(long page, long num, out long total)
        {
            List<Item> ret = new List<Item>();
            total = 0;
            try
            {
                ITopClient client = Global.DefulatClient();

                ItemsOnsaleGetRequest req = new ItemsOnsaleGetRequest();
                req.Fields = "num_iid,title,price";
                req.PageNo = page;
                req.PageSize = num;

                ItemsOnsaleGetResponse response = client.Execute(req, Global.SessionKey);
                total = response.TotalResults;

                ret.AddRange(response.Items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ret;
        }

        public static List<Trade> GetTradeList(String status, DateTime begin, DateTime end)
        {
            return GetTradeList(status, begin, end, null);
        }

        public static List<Trade> GetTradeList(String status, DateTime begin, DateTime end, String appedFileds)
        {
            List<Trade> ret = new List<Trade>();

            try
            {
                ITopClient client = Global.DefulatClient();
                for (long page = 1, num = 100; ; page++)
                {
                    TradesSoldGetRequest req = new TradesSoldGetRequest();
                    req.Fields = "buyer_nick,payment";
                    if (!String.IsNullOrEmpty(appedFileds))
                        req.Fields += "," + appedFileds;

                    req.Status = status;
                    req.StartCreated = begin;
                    req.EndCreated = end;
                    req.PageNo = page;
                    req.PageSize = num;

                    TradesSoldGetResponse response = client.Execute(req, Global.SessionKey);
                    if (response.Trades == null)
                        break;

                    ret.AddRange(response.Trades);
                    if ((long)response.Trades.Count < num || ret.Count >= response.TotalResults)
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        public static List<Trade> GetTradeList()
        {
            List<Trade> ret = new List<Trade>();
            try
            {
                ITopClient client = Global.DefulatClient();
                for (long page = 1, num = 100; ; page++)
                {
                    TradesSoldGetRequest req = new TradesSoldGetRequest();
                    req.Fields = "tid,created,pay_time,payment";
                    req.Fields += ",buyer_nick,buyer_message";
                    req.Fields += ",receiver_name,receiver_mobile,receiver_phone,receiver_state,receiver_city,receiver_district,receiver_address,receiver_zip";
                    req.Fields += ",seller_memo,seller_flag";
                    req.Fields += ",orders.title,orders.num,orders.num_iid,orders.status,orders.sku_properties_name";
                    req.Status = "WAIT_SELLER_SEND_GOODS";
                    req.PageNo = page;
                    req.PageSize = num;

                    TradesSoldGetResponse response = client.Execute(req, Global.SessionKey);
                    if (response.Trades == null)
                        break;

                    foreach (Trade trade in response.Trades)
                        GetSellerMemo(client, trade);

                    ret.AddRange(response.Trades);

                    if ((long)response.Trades.Count < num || ret.Count >= response.TotalResults)
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        static void GetSellerMemo(ITopClient client, Trade trade)
        {
            if (!String.IsNullOrEmpty(trade.SellerMemo))
                return;

            TradeGetRequest req = new TradeGetRequest();
            req.Fields = "seller_memo";
            req.Tid = trade.Tid;

            TradeGetResponse response = client.Execute(req, Global.SessionKey);
            if (response.Trade != null && !String.IsNullOrEmpty(response.Trade.SellerMemo))
                trade.SellerMemo = response.Trade.SellerMemo;
        }

        public static bool TradeOtherDeliver(Trade trade)
        {
            return (trade.SellerFlag & (long)Global.FlagBits.FB_OtherDeliver) != 0;
        }

        public static void TradeOtherDeliver(Trade trade, bool deliver)
        {
            if (deliver)
                ModifyTradeFlag(trade, trade.SellerFlag | (long)Global.FlagBits.FB_OtherDeliver);
            else
                ModifyTradeFlag(trade, trade.SellerFlag & ~(long)Global.FlagBits.FB_OtherDeliver);
        }

        public static bool TradeIgnore(Trade trade)
        {
            return (trade.SellerFlag & (long)Global.FlagBits.FB_PrintIgnore) != 0;
        }

        public static void TradeIgnore(Trade trade, bool ignore)
        {
            if (ignore)
                ModifyTradeFlag(trade, trade.SellerFlag | (long)Global.FlagBits.FB_PrintIgnore);
            else
                ModifyTradeFlag(trade, trade.SellerFlag & ~(long)Global.FlagBits.FB_PrintIgnore);
        }

        public static void ModifyTradeFlag(Trade trade, long flag)
        {
            try
            {
                ITopClient client = Global.DefulatClient();
                TradeMemoUpdateRequest req = new TradeMemoUpdateRequest();
                req.Tid = trade.Tid;
                req.Flag = flag;
                TradeMemoUpdateResponse response = client.Execute(req, Global.SessionKey);

                if (response.Trade != null && response.Trade.Tid == trade.Tid)
                    trade.SellerFlag = flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
