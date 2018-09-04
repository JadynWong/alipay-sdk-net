using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiQualityTestCloudacptItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestCloudacptItemQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// partener id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
