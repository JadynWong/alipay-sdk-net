using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainOrderstatusUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainOrderstatusUpdateModel : AopObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_param")]
        public MaintainOrderStatusExtParams ExtParam { get; set; }

        /// <summary>
        /// 洗车-015；保养-016；4S-020
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 55-已核销；7-已出库；8-已收货
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
