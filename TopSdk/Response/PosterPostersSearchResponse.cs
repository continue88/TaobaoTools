using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterPostersSearchResponse.
    /// </summary>
    public class PosterPostersSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回画报列表
        /// </summary>
        [XmlArray("posters")]
        [XmlArrayItem("huabao")]
        public List<Huabao> Posters { get; set; }
    }
}
