using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInventoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInventoryQueryModel : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品类型，ZP("正品"),CC("残次"),JS("机损"), XS("箱损"),ZT("在途库存")
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 页码（默认1，正整数）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小(最小为1，默认20，最大100)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
