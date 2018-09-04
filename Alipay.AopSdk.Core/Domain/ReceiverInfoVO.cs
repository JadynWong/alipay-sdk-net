using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiverInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiverInfoVO : AopObject
    {
        /// <summary>
        /// 区域
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }
    }
}
