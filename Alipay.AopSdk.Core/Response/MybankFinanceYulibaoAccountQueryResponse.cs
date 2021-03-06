using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用份额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 业务冻结份额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 系统冻结份额，单位为元（建议不展示给用户）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sys_freeze_amount")]
        public string SysFreezeAmount { get; set; }

        /// <summary>
        /// 余利宝总余额，单位为元
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 余利宝收益详情
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ylb_profit_detail_info")]
        public YLBProfitDetailInfo YlbProfitDetailInfo { get; set; }
    }
}
