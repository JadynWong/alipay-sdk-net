using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryPackageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPackageDetail : AopObject
    {
        /// <summary>
        /// 运单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_code")]
        public string ExpressCode { get; set; }

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
        /// 货品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_quantity")]
        public string GoodsQuantity { get; set; }

        /// <summary>
        /// 包裹编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_code")]
        public string PackageCode { get; set; }
    }
}
