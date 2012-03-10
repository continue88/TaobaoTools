using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.close
    /// </summary>
    public class TradeCloseRequest : ITopRequest<TradeCloseResponse>
    {
        /// <summary>
        /// 交易关闭原因。  可以选择的理由有：  1、我不想买了  2、信息填写错误，重新拍  3、卖家缺货  4、同城见面交易  5、其他原因  注：（请不要选择其他自定义的关闭理由）
        /// </summary>
        public string CloseReason { get; set; }

        /// <summary>
        /// 主订单或子订单编号。
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.close";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("close_reason", this.CloseReason);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("close_reason", this.CloseReason);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
