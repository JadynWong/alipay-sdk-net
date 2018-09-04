using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpScoreGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpScoreGetModel : AopObject
    {
        /// <summary>
        /// 产品码，直接使用［示例］给出的值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
