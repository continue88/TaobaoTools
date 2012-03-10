using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.type.add
    /// </summary>
    public class HotelTypeAddRequest : ITopRequest<HotelTypeAddResponse>
    {
        /// <summary>
        /// 酒店id。必须为数字
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 房型名称。长度不能超过30
        /// </summary>
        public string Name { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.type.add";
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
            RequestValidator.ValidateMinValue("hid", this.Hid, 0);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 30);
        }

        #endregion
    }
}
