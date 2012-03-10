using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HuabaoPostersGetResponse.
    /// </summary>
    public class HuabaoPostersGetResponse : TopResponse
    {
        /// <summary>
        /// 画报信息
        /// </summary>
        [XmlArray("posters")]
        [XmlArrayItem("poster")]
        public List<Poster> Posters { get; set; }
    }
}
