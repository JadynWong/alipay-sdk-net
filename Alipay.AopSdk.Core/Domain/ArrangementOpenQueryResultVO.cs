using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArrangementOpenQueryResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementOpenQueryResultVO : AopObject
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 合约状态  未生效：UN_INVALID  已取消：CANCEL  已生效：VALID  已失效：INVALID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ar_status")]
        public string ArStatus { get; set; }

        /// <summary>
        /// JSON结构的扩展字段，备用字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 有效期截止时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 有效期起始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_date")]
        public string ValidDate { get; set; }
    }
}
