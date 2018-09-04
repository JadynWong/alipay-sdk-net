using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductProvider Data Structure.
    /// </summary>
    [Serializable]
    public class ProductProvider : AopObject
    {
        /// <summary>
        /// 卡代英文名称 备注:淘宝交易为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agency")]
        public string Agency { get; set; }

        /// <summary>
        /// 卡代中文名称 备注：淘宝交易为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agency_name")]
        public string AgencyName { get; set; }

        /// <summary>
        /// 业务 类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 充值产品主表ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 子运营商英文名称 备注:淘宝交易为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_operator")]
        public string SubOperator { get; set; }

        /// <summary>
        /// 子运营商中文名称 ,如浙江移动
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_operator_name")]
        public string SubOperatorName { get; set; }
    }
}
