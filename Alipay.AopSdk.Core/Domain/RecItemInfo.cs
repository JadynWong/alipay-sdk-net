using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecItemInfo : AopObject
    {
        /// <summary>
        /// 归属地区
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 业务分类
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息,JSONSTRING格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Item编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 推荐Item名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Item分类
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Item地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
