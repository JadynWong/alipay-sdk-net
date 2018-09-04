using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDeliveryItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryItem : AopObject
    {
        /// <summary>
        /// SEND - 发货指令(执行向目的地进行发货动作) , RECEIVE - 收货指令(执行从来源地进行收货动作)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 配送数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 配送订单唯一Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 支付宝内部的配送流水号, 可供物料商和物流商用于对账.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assign_out_order_id")]
        public string AssignOutOrderId { get; set; }

        /// <summary>
        /// 物料渠道标识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 发送地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 配送指令生成日期, 格式:yyyy-MM-dd HH：mm:ss
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_assign")]
        public string GmtAssign { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 1. 如果该物料是套组的子物料, 那么该值为套组物料id;  2, 其他情况和物料id(即, item_id)一致或者为空.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_item_id")]
        public string ParentItemId { get; set; }

        /// <summary>
        /// 面单信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 生产调拨对应的生产指令.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("produce_order_item_id")]
        public string ProduceOrderItemId { get; set; }

        /// <summary>
        /// TO_CUSTOMER : 到客户的配送指令; INTERIM : 中转配送指令. 可选值详见openApi文档.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// 对应供应商pid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 对应供应商名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 接收地址(目的地址)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }
    }
}
