using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicSettingCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenPublicSettingCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回已设置的一级行业分类名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primary_category")]
        public string PrimaryCategory { get; set; }

        /// <summary>
        /// 返回已设置的二级行业分类名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secondary_category")]
        public string SecondaryCategory { get; set; }
    }
}
