using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CPAliveBillEntrySet Data Structure.
    /// </summary>
    [Serializable]
    public class CPAliveBillEntrySet : AopObject
    {
        /// <summary>
        /// 物业费账单应收明细条目ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_entry_id")]
        public string BillEntryId { get; set; }

        /// <summary>
        /// 未能删除的账单明细条目状态，状态值：  FINISH_PAYMENT - 用户完成支付和销账  UNDER_PAYMENT - 账单锁定待用户完成支付
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
