using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorChannelInfo : AopObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 渠道描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 渠道是否可用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_status")]
        public string ItemStatus { get; set; }
    }
}
