using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.orders.get
    /// </summary>
    public class FenxiaoOrdersGetRequest : ITopRequest<FenxiaoOrdersGetResponse>
    {
        /// <summary>
        /// 结束时间 格式 yyyy-MM-dd HH:mm:ss.支持到秒的查询。若不传时分秒，默认为0时0分0秒。若purchase_order_id没传，则此参数必传。
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 页码。（大于0的整数。默认为1）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。（每页条数不超过50条）
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 采购单编号或分销流水号，若其它参数没传，则此参数必传。
        /// </summary>
        public Nullable<long> PurchaseOrderId { get; set; }

        /// <summary>
        /// 起始时间 格式 yyyy-MM-dd HH:mm:ss.支持到秒的查询。若不传时分秒，默认为0时0分0秒。若purchase_order_id没传，则此参数必传。
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 交易状态，不传默认查询所有采购单。根据身份选择自身状态。可选值:<br>   *供应商：<br> WAIT_SELLER_SEND_GOODS(等待发货)<br> WAIT_SELLER_CONFIRM_PAY(待确认收款)<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_BUYER_CONFIRM_GOODS(已发货)<br> TRADE_REFUNDING(退款中)<br> TRADE_FINISHED(采购成功)<br> TRADE_CLOSED(已关闭)。<br>        *分销商：<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_BUYER_CONFIRM_GOODS(待收货确认)<br> TRADE_FOR_PAY(已付款)<br> TRADE_REFUNDING(退款中)<br> TRADE_FINISHED(采购成功)<br> TRADE_CLOSED(已关闭)。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 可选值：trade_time_type(采购单按照成交时间范围查询),update_time_type(采购单按照更新时间范围查询)
        /// </summary>
        public string TimeType { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.orders.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("purchase_order_id", this.PurchaseOrderId);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.Add("time_type", this.TimeType);
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion
    }
}
