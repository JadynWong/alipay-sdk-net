using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodEnquriyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodEnquriyApplyModel : AopObject
    {
        /// <summary>
        /// 代理人身份信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent")]
        public InsPerson Agent { get; set; }

        /// <summary>
        /// 代理人userId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_user_id")]
        public string AgentUserId { get; set; }

        /// <summary>
        /// 投保人身份信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car")]
        public Car Car { get; set; }

        /// <summary>
        /// 车主身份信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("car_owner")]
        public InsPerson CarOwner { get; set; }

        /// <summary>
        /// 投保城市编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 被保人身份信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 外部询价申请业务单号（幂等字段）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
