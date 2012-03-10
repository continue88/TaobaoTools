using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterAppointedpostersGetResponse.
    /// </summary>
    public class PosterAppointedpostersGetResponse : TopResponse
    {
        /// <summary>
        /// 画报列表
        /// </summary>
        [XmlArray("appointedposters")]
        [XmlArrayItem("huabao")]
        public List<Huabao> Appointedposters { get; set; }
    }
}
