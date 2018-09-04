using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieSitesCreateModel : AopObject
    {
        /// <summary>
        /// 云凤蝶站点初始化数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity")]
        public FengdieSitesCreateModel Activity { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作的空间 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_id")]
        public string SpaceId { get; set; }

        /// <summary>
        /// 创建站点使用的模板名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }
}
