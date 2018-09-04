using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDeliveryAddress Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryAddress : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 区信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_id")]
        public string WarehouseId { get; set; }

        /// <summary>
        /// 供应商的仓库名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_name")]
        public string WarehouseName { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }
}
