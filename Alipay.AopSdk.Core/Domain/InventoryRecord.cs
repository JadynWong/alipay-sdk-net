using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InventoryRecord Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryRecord : AopObject
    {
        /// <summary>
        /// 可用库存变更之后
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_modify_lock_quantity")]
        public long AfterModifyLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变更之后
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_modify_quantity")]
        public long AfterModifyQuantity { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 占用库存变更之前
        /// </summary>
        [Newtonsoft.Json.JsonProperty("before_modify_lock_quantity")]
        public string BeforeModifyLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变更之前
        /// </summary>
        [Newtonsoft.Json.JsonProperty("before_modify_quantity")]
        public long BeforeModifyQuantity { get; set; }

        /// <summary>
        /// 占用库存
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diff_lock_quantity")]
        public long DiffLockQuantity { get; set; }

        /// <summary>
        /// 可用库存变化量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diff_quantity")]
        public long DiffQuantity { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 库存类型（ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 操作类型（INBOUND＝入库  OUTBOUND＝出库）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
