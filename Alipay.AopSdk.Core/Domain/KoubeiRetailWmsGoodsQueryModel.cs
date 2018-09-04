using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodsQueryModel : AopObject
    {
        /// <summary>
        /// 根据状态查询货品  EFFECTIVE：生效  INVALID ：无效
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 根据货品前缀名称查询
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 页码，分页参数，当以 goods_code为查询条件时不用传，默认1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 页面大小，分页参数，当以goods_code为查询条件时不用传，默认20
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 生产厂商ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("producer_id")]
        public string ProducerId { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_id")]
        public string SupplierId { get; set; }
    }
}
