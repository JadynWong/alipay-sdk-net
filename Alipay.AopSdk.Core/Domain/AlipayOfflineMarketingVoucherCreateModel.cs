using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherCreateModel : AopObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget_info")]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 券码池编号。该值调用：alipay.offline.marketing.voucher.code.upload接口生成
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_inventory_id")]
        public string CodeInventoryId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发放规则信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_rule")]
        public GetRuleInfo GetRule { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_info")]
        public VoucherInfo VoucherInfo { get; set; }
    }
}
