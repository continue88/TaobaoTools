using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PosterPicture Data Structure.
    /// </summary>
    [Serializable]
    public class PosterPicture : TopObject
    {
        /// <summary>
        /// 创建时间。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 相关说明。
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片ID。
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 画报ID。
        /// </summary>
        [XmlElement("poster_id")]
        public string PosterId { get; set; }

        /// <summary>
        /// 图片地址。
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
