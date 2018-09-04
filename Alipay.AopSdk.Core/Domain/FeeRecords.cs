using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeRecords Data Structure.
    /// </summary>
    [Serializable]
    public class FeeRecords : AopObject
    {
        /// <summary>
        /// 费用余额，单位为元，小数点保留2位
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 费用交易流水备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 费用交易额度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
