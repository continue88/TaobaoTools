using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterPostersGetResponse.
    /// </summary>
    public class PosterPostersGetResponse : TopResponse
    {
        /// <summary>
        /// 画报列表
        /// </summary>
        [XmlArray("posters")]
        [XmlArrayItem("huabao")]
        public List<Huabao> Posters { get; set; }
    }
}
