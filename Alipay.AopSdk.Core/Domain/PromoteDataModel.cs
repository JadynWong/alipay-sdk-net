using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoteDataModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDataModel : AopObject
    {
        /// <summary>
        /// 核销数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checked_voucher_num")]
        public long CheckedVoucherNum { get; set; }

        /// <summary>
        /// 领券数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_voucher_num")]
        public long ClaimVoucherNum { get; set; }

        /// <summary>
        /// 分佣金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_amount")]
        public string CommissionAmount { get; set; }
    }
}
