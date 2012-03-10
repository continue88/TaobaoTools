using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.delete
    /// </summary>
    public class ItemPropimgDeleteRequest : ITopRequest<ItemPropimgDeleteResponse>
    {
        /// <summary>
        /// 商品属性图片ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 商品数字ID，必选
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.propimg.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("num_iid", this.NumIid);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateMinValue("num_iid", this.NumIid, 0);
        }

        #endregion
    }
}
