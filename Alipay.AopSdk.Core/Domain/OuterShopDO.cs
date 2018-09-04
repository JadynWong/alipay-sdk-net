using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OuterShopDO Data Structure.
    /// </summary>
    [Serializable]
    public class OuterShopDO : AopObject
    {
        /// <summary>
        /// 合作商户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 支付宝店铺ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 合作商户类型 （mike、_2dFire）  iSV自己定义自己的类型，推荐使用自己的域名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
