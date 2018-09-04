using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessPurchaseOrderSendResult Data Structure.
    /// </summary>
    [Serializable]
    public class AccessPurchaseOrderSendResult : AopObject
    {
        /// <summary>
        /// 申请单明细号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_item_id")]
        public string AssetItemId { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_order_id")]
        public string AssetOrderId { get; set; }

        /// <summary>
        /// 采购单ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 错误CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 外部单号（调用方业务主键标识）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 处理是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
