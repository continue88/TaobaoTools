using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.get
    /// </summary>
    public class HotelGetRequest : ITopRequest<HotelGetResponse>
    {
        /// <summary>
        /// 要查询的酒店id。必须为数字
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 是否需要返回该酒店的房型列表。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedRoomType { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("hid", this.Hid);
            parameters.Add("need_room_type", this.NeedRoomType);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("hid", this.Hid);
        }

        #endregion
    }
}
