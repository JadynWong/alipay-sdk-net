using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBizinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBizinfoQueryModel : AopObject
    {
        /// <summary>
        /// 业务机构简称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型，公服业务：IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务数据码，标识业务场景
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_code")]
        public string DataCode { get; set; }

        /// <summary>
        /// 请求上下文，json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_context")]
        public string RequestContext { get; set; }
    }
}
