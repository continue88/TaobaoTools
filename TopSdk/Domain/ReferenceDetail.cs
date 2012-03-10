using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ReferenceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ReferenceDetail : TopObject
    {
        /// <summary>
        /// 引用者的地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 引用者的名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 引用的类型:item,被宝贝引用；decorating，被装修引用；huabao，被画报引用；unreferenced，未被引用
        /// </summary>
        [XmlElement("reference_type")]
        public string ReferenceType { get; set; }
    }
}
