using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExratePricingNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExratePricingNotifyModel : AopObject
    {
        /// <summary>
        /// 标识该汇率提供给哪个客户使用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 源汇率机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 源汇率数据
        /// </summary>
        [XmlArray("pricing_list")]
        [XmlArrayItem("pricing_v_o")]
        public List<PricingVO> PricingList { get; set; }

        /// <summary>
        /// 该汇率的使用场景
        /// </summary>
        [Newtonsoft.Json.JsonProperty("segment_id")]
        public string SegmentId { get; set; }

        /// <summary>
        /// 所在时区，所有的时间都是该时区的时间  支持 GMT+8 UTC+0 Europe/London 的格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_zone")]
        public string TimeZone { get; set; }
    }
}
