using System;
using System.Collections.Generic;
using System.Text;
using TaobaoTools.Properties;
using System.ComponentModel;
using System.Drawing;

namespace TaobaoTools.Data
{
    public class DefaultSettings
    {
        [DefaultValue(0), DisplayName("偏移X"), Description("快递单打印的横向偏移值，单位为毫米，正数右偏，负数左偏"), Category("快递单设置")]
        public int ExpressOffsetX { get { return Settings.Default.ExpressOffsetX; } set { Settings.Default.ExpressOffsetX = value; } }

        [DefaultValue(0), DisplayName("偏移Y"), Description("快递单打印的纵向偏移值，单位为毫米，正数上偏，负数下偏"), Category("快递单设置")]
        public int ExpressOffsetY { get { return Settings.Default.ExpressOffsetY; } set { Settings.Default.ExpressOffsetY = value; } }

        [DefaultValue(""), DisplayName("发货人姓名"), Category("发货信息")]
        public String SenderName { get { return Settings.Default.SenderName; } set { Settings.Default.SenderName = value; } }

        [DefaultValue(""), DisplayName("发货人城市"), Category("发货信息")]
        public String SenderCity { get { return Settings.Default.SenderCity; } set { Settings.Default.SenderCity = value; } }

        [DefaultValue(""), DisplayName("发货人地址"), Category("发货信息")]
        public String SenderAdress { get { return Settings.Default.SenderAdress; } set { Settings.Default.SenderAdress = value; } }

        [DefaultValue(""), DisplayName("发货人电话"), Category("发货信息")]
        public String SenderMobile { get { return Settings.Default.SenderMobile; } set { Settings.Default.SenderMobile = value; } }

        [DefaultValue(""), DisplayName("发货人邮编"), Category("发货信息")]
        public String SenderZip { get { return Settings.Default.SenderZip; } set { Settings.Default.SenderZip = value; } }

        [DefaultValue(15), DisplayName("订单字体大小"), Description("设置生成订单页面的文字大小"), Category("订单打印")]
        public int OrderFontSize { get { return Settings.Default.OrderFontSize; } set { Settings.Default.OrderFontSize = value; } }

        [DefaultValue(typeof(Size), "550, 975"), DisplayName("订单页面大小"), Description("设置生成订单页面的页面大小"), Category("订单打印")]
        public Size OrderPageSize { get { return Settings.Default.OrderPageSize; } set { Settings.Default.OrderPageSize = value; } }

        [DefaultValue(10), DisplayName("订单页面数"), Description("设置生成订单页面的页面数"), Category("订单打印")]
        public int OrderMaxPageNum { get { return Settings.Default.OrderMaxPageNum; } set { Settings.Default.OrderMaxPageNum = value; } }
    }
}
