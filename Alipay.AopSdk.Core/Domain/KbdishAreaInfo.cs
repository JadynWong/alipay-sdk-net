using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishAreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishAreaInfo : AopObject
    {
        /// <summary>
        /// 餐区开台菜列表
        /// </summary>
        [XmlArray("area_free_list")]
        [XmlArrayItem("kbdish_area_free_info")]
        public List<KbdishAreaFreeInfo> AreaFreeList { get; set; }

        /// <summary>
        /// 餐区id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 餐区排序序号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_sort")]
        public string AreaSort { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 餐区服务费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_price")]
        public string FeePrice { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id 支付宝的
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 餐区的餐桌数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tab_count")]
        public string TabCount { get; set; }

        /// <summary>
        /// 餐区下的餐台列表
        /// </summary>
        [XmlArray("tab_list")]
        [XmlArrayItem("kbdish_tab_info")]
        public List<KbdishTabInfo> TabList { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_user")]
        public string UpdateUser { get; set; }
    }
}
