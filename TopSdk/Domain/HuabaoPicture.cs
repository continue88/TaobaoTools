using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// HuabaoPicture Data Structure.
    /// </summary>
    [Serializable]
    public class HuabaoPicture : TopObject
    {
        /// <summary>
        /// 图片创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 图片修改时间
        /// </summary>
        [XmlElement("modified_date")]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 图片ID
        /// </summary>
        [XmlElement("pic_id")]
        public string PicId { get; set; }

        /// <summary>
        /// 图片说明
        /// </summary>
        [XmlElement("pic_note")]
        public string PicNote { get; set; }

        /// <summary>
        /// 图片URL
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 画报ID
        /// </summary>
        [XmlElement("poster_id")]
        public long PosterId { get; set; }
    }
}
