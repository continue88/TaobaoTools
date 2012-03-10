using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.orders.get
    /// </summary>
    public class TaohuaOrdersGetRequest : ITopRequest<TaohuaOrdersGetResponse>
    {
        /// <summary>
        /// 默认为当前时间， 日期格式精确到天数
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 分页获取订单列表信息，page_no代表的是第几页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页获取订单列表信息，page_size代表每页显示多少条。  注意：每页显示条数。最小5条，最多30条，凡是超出范围的条数，都会被默认为10条。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 系统默认为：当前时间-90天。  日期精确到日
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 查询的交易状态：  1. 全部 all  2. 等待买家付款 wait_pay  3. 交易成功 trade_suc  4. 交易关闭 trade_close
        /// </summary>
        public string TradeStatus { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.orders.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("trade_status", this.TradeStatus);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 30);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 5);
        }

        #endregion
    }
}
