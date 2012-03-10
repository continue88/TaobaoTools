using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shopcats.list.get
    /// </summary>
    public class ShopcatsListGetRequest : ITopRequest<ShopcatsListGetResponse>
    {
        /// <summary>
        /// 需要返回的字段列表，见ShopCat，默认返回：cid,parent_cid,name,is_parent
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shopcats.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion
    }
}
