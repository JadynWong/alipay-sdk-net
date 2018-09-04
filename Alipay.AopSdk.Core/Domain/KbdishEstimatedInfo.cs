using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishEstimatedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishEstimatedInfo : AopObject
    {
        /// <summary>
        /// 估清的菜品dishid或者skuid,该值对应的类型由dsType指定。目前暂时只支持dishid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_id")]
        public string DsId { get; set; }

        /// <summary>
        /// skuid:sku维度估清  dishid:菜品维度估清
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_type")]
        public string DsType { get; set; }

        /// <summary>
        /// 估清后临时库存.大于等于0的数字。  status=open必须要传一个数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 状态。open:启用;stop:停用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 估清最后修改人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_user")]
        public string UpdateUser { get; set; }
    }
}
