using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthUserinfoApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthUserinfoApplyModel : AopObject
    {
        /// <summary>
        /// 业务号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_data")]
        public string ExtData { get; set; }
    }
}
