using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Top.Api.Domain;

namespace TaobaoTools.Data
{
    public class LogisticsCopanyConverter : TypeConverter
    {
        public LogisticsCopanyConverter()
        {
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<String> companyNames = new List<string>();
            List<LogisticsCompany> cogisticsCompanies = TopClientHelper.GetLogisticsCompanies();
            foreach (LogisticsCompany company in cogisticsCompanies)
                companyNames.Add(company.Name);
            companyNames.Add("其它");

            return new StandardValuesCollection(companyNames);
        }
    }
}
