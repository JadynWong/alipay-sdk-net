using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJfexportInstbillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfexportInstbillQueryModel : AopObject
    {
        /// <summary>
        /// 账期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型英文名称 ，固定传JF，表示缴费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 账单拥有者姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 子业务类型英文名称，ELECTRIC-电费，WATER-水费，GAS-燃气费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
