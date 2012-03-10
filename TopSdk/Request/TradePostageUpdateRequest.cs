using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.postage.update
    /// </summary>
    public class TradePostageUpdateRequest : ITopRequest<TradePostageUpdateResponse>
    {
        /// <summary>
        /// 邮费价格(邮费单位是元）
        /// </summary>
        public string PostFee { get; set; }

        /// <summary>
        /// 主订单编号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.postage.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("post_fee", this.PostFee);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("post_fee", this.PostFee);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
