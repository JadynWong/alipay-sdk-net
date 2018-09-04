using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingExtData Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingExtData : AopObject
    {
        /// <summary>
        /// 复杂模型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lbs_info")]
        public AlipayMarketingIbsInfo LbsInfo { get; set; }

        /// <summary>
        /// 外部uid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_user_id")]
        public string OutUserId { get; set; }
    }
}
