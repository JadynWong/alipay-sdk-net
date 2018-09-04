using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDeliverAddress Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDeliverAddress : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_code")]
        public string AddressCode { get; set; }

        /// <summary>
        /// 是否默认收货地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_deliver_address")]
        public string DefaultDeliverAddress { get; set; }

        /// <summary>
        /// 区/县
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_area")]
        public string DeliverArea { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_city")]
        public string DeliverCity { get; set; }

        /// <summary>
        /// 收货人全名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_fullname")]
        public string DeliverFullname { get; set; }

        /// <summary>
        /// 收货地址的联系人移动电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_mobile")]
        public string DeliverMobile { get; set; }

        /// <summary>
        /// 收货地址的联系人固定电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_phone")]
        public string DeliverPhone { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_province")]
        public string DeliverProvince { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
