using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterPosterdetailGetResponse.
    /// </summary>
    public class PosterPosterdetailGetResponse : TopResponse
    {
        /// <summary>
        /// 根据ID获取画报
        /// </summary>
        [XmlElement("poster")]
        public Huabao Poster { get; set; }

        /// <summary>
        /// 根据画报ID获取画报图片
        /// </summary>
        [XmlArray("poster_pics")]
        [XmlArrayItem("huabao_picture")]
        public List<HuabaoPicture> PosterPics { get; set; }
    }
}
