using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.delivery.template.delete
    /// </summary>
    public class DeliveryTemplateDeleteRequest : ITopRequest<DeliveryTemplateDeleteResponse>
    {
        /// <summary>
        /// 运费模板ID
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.delivery.template.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("template_id", this.TemplateId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
        }

        #endregion
    }
}
