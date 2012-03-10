using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaLatestupdateinfoGetResponse.
    /// </summary>
    public class TaohuaLatestupdateinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 更新信息版本号
        /// </summary>
        [XmlElement("taohua_update_info")]
        public TaohuaUpdateInfo TaohuaUpdateInfo { get; set; }
    }
}
