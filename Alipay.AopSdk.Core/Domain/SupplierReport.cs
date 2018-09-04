using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierReport Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierReport : AopObject
    {
        /// <summary>
        /// 盘点单创建渠道 notify:菜鸟通知,daily:日常调度,manual:手动定制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作者类型，只会是system
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 盘点单下单日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_date")]
        public string OrderDate { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 盘点单状态  INIT:未完成 FINISHED:已完成
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 供货商id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_report_id")]
        public string SupplierReportId { get; set; }

        /// <summary>
        /// 唯一约束
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
