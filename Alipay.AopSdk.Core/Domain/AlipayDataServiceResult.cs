using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataServiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataServiceResult : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 调用结果，json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }
    }
}
