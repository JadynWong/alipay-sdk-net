using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataSendBusinessResult Data Structure.
    /// </summary>
    [Serializable]
    public class DataSendBusinessResult : AopObject
    {
        /// <summary>
        /// 数据发送业务处理结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 数据发送业务处理结果描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_msg")]
        public string BizMsg { get; set; }
    }
}
