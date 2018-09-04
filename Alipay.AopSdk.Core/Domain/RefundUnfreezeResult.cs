using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundUnfreezeResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundUnfreezeResult : AopObject
    {
        /// <summary>
        /// 冻结单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freeze_no")]
        public string FreezeNo { get; set; }

        /// <summary>
        /// 解冻结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 解冻状态。S成功，F失败。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 解冻金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfreeze_no")]
        public string UnfreezeNo { get; set; }

        /// <summary>
        /// 解冻时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfreeze_time")]
        public string UnfreezeTime { get; set; }
    }
}
