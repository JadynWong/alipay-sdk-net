using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketShopModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改门店请求受理成功后返回的支付宝流水ID，根据此ID调用接口  alipay.offline.market.applyorder.batchquery，能够获取当前修改店铺请求审核状态、驳回原因等信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 废弃字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 同步请求如果支付宝受理成功，将返回AUDITING状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 废弃字段，T表示上架,F表示未上架。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_online")]
        public string IsOnline { get; set; }

        /// <summary>
        /// 废弃字段，T表示显示，F表示隐藏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_show")]
        public string IsShow { get; set; }
    }
}
