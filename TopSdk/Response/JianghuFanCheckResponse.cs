using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JianghuFanCheckResponse.
    /// </summary>
    public class JianghuFanCheckResponse : TopResponse
    {
        /// <summary>
        /// true or false
        /// </summary>
        [XmlElement("result")]
        public Check Result { get; set; }
    }
}
