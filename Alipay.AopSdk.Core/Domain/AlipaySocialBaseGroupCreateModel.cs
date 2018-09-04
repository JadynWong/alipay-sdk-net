using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseGroupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseGroupCreateModel : AopObject
    {
        /// <summary>
        /// 业务方传入的唯一id，做为幂等使用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 群的业务类型，目前只能为0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 建群时初始化的群设置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_settings")]
        public GroupSetting GroupSettings { get; set; }

        /// <summary>
        /// 建群的时候，群主的userid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("master_id")]
        public string MasterId { get; set; }
    }
}
