using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthQuerybypageModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderEquipmentAuthQuerybypageModel : AopObject
    {
        /// <summary>
        /// 解绑起始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 机具类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 解绑截止时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，传json格式的字符串，包含operator=操作人；operator_id =操作人ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 当前页，***注意页数从1开始***
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
