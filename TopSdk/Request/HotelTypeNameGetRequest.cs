using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.type.name.get
    /// </summary>
    public class HotelTypeNameGetRequest : ITopRequest<HotelTypeNameGetResponse>
    {
        /// <summary>
        /// 要查询的酒店id。必须为数字
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 房型全部名称/别名。不能超过60字节
        /// </summary>
        public string Name { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.type.name.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("hid", this.Hid);
            parameters.Add("name", this.Name);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("hid", this.Hid);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 60);
        }

        #endregion
    }
}
