using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// McardTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class McardTemplate : AopObject
    {
        /// <summary>
        /// 会员卡类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 会员卡模板创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 会员卡模板修改时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 会员卡模板展示样式，会员卡在卡包中的卡面展示效果
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }
    }
}
