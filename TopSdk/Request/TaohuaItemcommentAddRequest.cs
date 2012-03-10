using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.itemcomment.add
    /// </summary>
    public class TaohuaItemcommentAddRequest : ITopRequest<TaohuaItemcommentAddResponse>
    {
        /// <summary>
        /// 对商品的评论内容
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.itemcomment.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("comment", this.Comment);
            parameters.Add("item_id", this.ItemId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("comment", this.Comment);
            RequestValidator.ValidateMaxLength("comment", this.Comment, 4000);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
        }

        #endregion
    }
}
