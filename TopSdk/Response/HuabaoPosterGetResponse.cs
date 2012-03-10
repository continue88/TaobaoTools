using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HuabaoPosterGetResponse.
    /// </summary>
    public class HuabaoPosterGetResponse : TopResponse
    {
        /// <summary>
        /// 画报图片
        /// </summary>
        [XmlArray("pics")]
        [XmlArrayItem("poster_picture")]
        public List<PosterPicture> Pics { get; set; }

        /// <summary>
        /// 画报信息
        /// </summary>
        [XmlElement("poster")]
        public Poster Poster { get; set; }
    }
}
