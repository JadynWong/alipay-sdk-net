using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleProduct Data Structure.
    /// </summary>
    [Serializable]
    public class SaleProduct : AopObject
    {
        /// <summary>
        /// 宝贝来源 例如：TAOBAO ALIPAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 销售产品DB ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("market_price")]
        public string MarketPrice { get; set; }

        /// <summary>
        /// 充值产品提供商
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_provider")]
        public ProductProvider ProductProvider { get; set; }

        /// <summary>
        /// 销售价格
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 产品状态, 0为不可用，1为可用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
