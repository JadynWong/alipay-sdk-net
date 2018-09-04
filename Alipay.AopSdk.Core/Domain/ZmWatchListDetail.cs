using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmWatchListDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZmWatchListDetail : AopObject
    {
        /// <summary>
        /// 风险信息行业编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 风险编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("extend_info")]
        [XmlArrayItem("zm_watch_list_extend_info")]
        public List<ZmWatchListExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// 数据刷新时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 结清状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement")]
        public bool Settlement { get; set; }

        /// <summary>
        /// 当用户进行异议处理，并核查完毕之后，仍有异议时，给出的声明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statement")]
        public string Statement { get; set; }

        /// <summary>
        /// 用户本人对该条负面记录有异议时，表示该异议处理流程的状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 行业名单风险类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
