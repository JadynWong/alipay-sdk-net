using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetResult Data Structure.
    /// </summary>
    [Serializable]
    public class AssetResult : AopObject
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 是否处理成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
