using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAccessApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductAccessApplyModel : AopObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 外部业务字段，幂等字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        public string Source { get; set; }
    }
}
