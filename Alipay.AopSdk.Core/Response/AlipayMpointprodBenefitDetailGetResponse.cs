using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMpointprodBenefitDetailGetResponse.
    /// </summary>
    public class AlipayMpointprodBenefitDetailGetResponse : AopResponse
    {
        /// <summary>
        /// 权益详情列表
        /// </summary>
        [XmlArray("benefit_infos")]
        [XmlArrayItem("benefit_info")]
        public List<BenefitInfo> BenefitInfos { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 响应描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
