using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SmartCityCommodityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartCityCommodityInfo : AopObject
    {
        /// <summary>
        /// 服务归属
        /// </summary>
        [Newtonsoft.Json.JsonProperty("affiliation")]
        public string Affiliation { get; set; }

        /// <summary>
        /// 授权文件
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_file")]
        public string AuthFile { get; set; }

        /// <summary>
        /// 测试验收说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("test_detail")]
        public string TestDetail { get; set; }

        /// <summary>
        /// 测试报表
        /// </summary>
        [Newtonsoft.Json.JsonProperty("test_report")]
        public string TestReport { get; set; }

        /// <summary>
        /// 用户指南
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_guide")]
        public string UserGuide { get; set; }
    }
}
