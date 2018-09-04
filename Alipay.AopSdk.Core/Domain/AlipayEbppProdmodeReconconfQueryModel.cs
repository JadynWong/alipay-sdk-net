using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeReconconfQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeReconconfQueryModel : AopObject
    {
        /// <summary>
        /// 缴费业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 销账机构编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chargeoff_code")]
        public string ChargeoffCode { get; set; }
    }
}
