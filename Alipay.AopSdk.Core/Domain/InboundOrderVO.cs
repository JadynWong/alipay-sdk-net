using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InboundOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class InboundOrderVO : AopObject
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 入库通知单id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_order_id")]
        public string InboundOrderId { get; set; }

        /// <summary>
        /// 入库业务类型，BHRK=补货入库，CGRK=采购入库，CGTHRK=采购退货入库，DDTHRK=订单退货入库，PDRK=盘点入库
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_type")]
        public string InboundType { get; set; }

        /// <summary>
        /// 通知日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_date")]
        public string NoticeDate { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作者类型，PROVIDER:服务商,PROVIDER_STAFF:服务商员工,MER:商户,MER_STAFF:商户员工,SALES:阿里销售小二,SYSTEM:系统
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 入库单类型：INIT（初始化）, PROCESSING（处理中）,FINISHED（完成）, CANCELLED（取消）;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
